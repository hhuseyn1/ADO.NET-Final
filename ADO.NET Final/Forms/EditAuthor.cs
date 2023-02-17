using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace ADO.NET_Final;

public partial class EditAuthor : Form
{
    SqlConnection conn=null;
    SqlCommand command=null;
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
        //Create store procedure

        //CREATE PROCEDURE usp_UpdateAuthors
        //@aId int,
        //@aFirstName nvarchar(20),
        //@aLastName nvarchar(20)
        //AS
        //UPDATE Authors SET FirstName = @aFirstName,LastName = @aLastName WHERE Id = @aId
        //RETURN 0
        try
        {
            SqlCommand updateCommand = new SqlCommand()
            {
                CommandText = "dbo.usp_UpdateAuthors",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
            };
            updateCommand.Parameters.AddWithValue("@aId", int.Parse(Idtxtbox.Text));
            updateCommand.Parameters.AddWithValue("@aFirstname",FirstNametxtbox.Text);
            updateCommand.Parameters.AddWithValue("@aLastname", LastNametxtbox.Text);

            conn.Open() ;
            updateCommand.ExecuteNonQuery();
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
            LastNametxtbox.Text = null;
            FirstNametxtbox.Text = null;
            Idtxtbox.Text = null;
            this.Close();
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        LastNametxtbox.Text = null;
        FirstNametxtbox.Text = null;
        Idtxtbox.Text = null;
        this.Close();
    }

}
