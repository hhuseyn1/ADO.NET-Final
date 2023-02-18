using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace ADO.NET_Final;

public partial class EditProduct : Form
{
    SqlConnection conn = null;
    SqlCommand command = null;
    string connectionString = null;
    int id;
    public EditProduct(int id)
    {
        InitializeComponent();
        this.id = id;
        Configure();
    }

    private void Configure()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        connectionString = configuration.GetConnectionString("ProductDb");
        conn = new SqlConnection(connectionString);
        fillData(id);
    }

    private void ClearTextBox()
    {
        Ratingtxtbox.Text = null;
        Nametxtbox.Text = null;
        CatIdtxtbox.Text = null;
        Pricetxtbox.Text = null;
        Quantitytxtbox.Text = null;
    }
    private async Task fillData(int id)
    {
        try
        {
            conn.Open();
            command = new SqlCommand("SELECT Authors.[FirstName] AS [FirstName] , Authors.[LastName] AS [LastName]  FROM Authors WHERE @id=Authors.Id GROUP BY Authors.Id,Authors.[FirstName],Authors.[LastName]", conn);
            command.Parameters.AddWithValue("@id", id);
            DbDataReader dataReader = await command.ExecuteReaderAsync();
            Idtxtbox.Text = id.ToString();
            while (dataReader.Read())
            {
                Nametxtbox.Text = dataReader["FirstName"].ToString();
                Ratingtxtbox.Text = dataReader["LastName"].ToString();
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

        //CREATE PROCEDURE usp_UpdateProduct
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
                CommandText = "dbo.usp_UpdateProduct",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
            };
            updateCommand.Parameters.AddWithValue("@pName",SqlDbType.NVarChar ).Value=Nametxtbox.Text;
            updateCommand.Parameters.AddWithValue("@pPrice",SqlDbType.Decimal ).Value= decimal.Parse(Pricetxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pQuantity",SqlDbType.Int ).Value=int.Parse(Quantitytxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pRating",SqlDbType.Decimal ).Value=decimal.Parse(Ratingtxtbox.Text);
            updateCommand.Parameters.AddWithValue("@pCategoryId",SqlDbType.Int ).Value=int.Parse(CatIdtxtbox.Text);

            conn.Open();
            updateCommand.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            conn.Close();
            ClearTextBox();
            this.Close();
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        ClearTextBox();
        this.Close();
    }

}
