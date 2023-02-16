using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace ADO.NET_Final;

public partial class EditAuthor : Form
{
    SqlConnection conn=null;
    SqlCommand command=null;
    SqlDataAdapter dataAdapter = null;
    string connectionString = null;
    int id;
    public EditAuthor(int id)
    {
        InitializeComponent();
        this.id= id;
        Configure();
    }

    private void Configure()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        connectionString = configuration.GetConnectionString("SqlServerLibrary");
        conn = new SqlConnection(connectionString);
        fillData(id);
    }

    private async Task fillData(int id)
    {
        try
        {
        conn.Open();
        command = new SqlCommand("SELECT Authors.[FirstName] AS [FirstName] , Authors.[LastName] AS [LastName]  FROM Authors WHERE @id=Authors.Id GROUP BY Authors.Id,Authors.[FirstName],Authors.[LastName]", conn);
        command.Parameters.AddWithValue("@id", id);
        DbDataReader dataReader = await command.ExecuteReaderAsync();
        Idtxtbox.Text=id.ToString();
            while(dataReader.Read()) {
            FirstNametxtbox.Text = dataReader["FirstName"].ToString();
            LastNametxtbox.Text = dataReader["LastName"].ToString();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
            
        }
    }


    private void SaveBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SqlCommand updateCommand = new SqlCommand()
            {
                CommandText = "usp_UpdateAuthors",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
            };


            updateCommand.Parameters.Add(new SqlParameter("@aId", SqlDbType.Int));
            updateCommand.Parameters["@aId"].SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters["@aId"].SourceColumn = "Id";

            updateCommand.Parameters.Add(new SqlParameter("@aFirstname", SqlDbType.NVarChar));
            updateCommand.Parameters["@aFirstname"].SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters["@aFirstname"].SourceColumn = "Firstname";

            updateCommand.Parameters.Add(new SqlParameter("@aLastname", SqlDbType.NVarChar));
            updateCommand.Parameters["@aLastname"].SourceVersion = DataRowVersion.Original;
            updateCommand.Parameters["@aLastname"].SourceColumn = "Lastname";

            DataSet dataSet = new DataSet();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Authors",conn);
            dataAdapter.Fill(dataSet, "myTable");
            dataAdapter.UpdateCommand = updateCommand;


        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            LastNametxtbox.Text = null;
            FirstNametxtbox.Text = null;
            Idtxtbox.Text = null;
        }
        Application.Exit();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        LastNametxtbox.Text = null;
        FirstNametxtbox.Text = null;
        Idtxtbox.Text = null;
        Application.Exit();
    }

}
