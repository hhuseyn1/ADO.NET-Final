using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO.NET_Final;

public partial class AddProduct : Form
{
    SqlConnection conn = null;
    SqlCommand command = null;
    string connectionString = null;
    int id;

    public AddProduct()
    {
        InitializeComponent();
        Configure();
    }


    private void Configure()
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        connectionString = configuration.GetConnectionString("ProductDb");
        conn = new SqlConnection(connectionString);
    }


    private void ClearTextBox()
    {
        Ratingtxtbox.Text = null;
        Nametxtbox.Text = null;
        CatIdtxtbox.Text = null;
        Pricetxtbox.Text = null;
        Quantitytxtbox.Text = null;
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {

        if (Ratingtxtbox.Text == null ||
        Nametxtbox.Text == null ||
        CatIdtxtbox.Text == null ||
        Pricetxtbox.Text == null ||
        Quantitytxtbox.Text == null)
        {
            MessageBox.Show("Please fill all textboxes ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return;
        }

        //Create store procedure

        //CREATE PROCEDURE usp_AddProduct
        //@pId int,
        //@pName nvarchar(20),
        //@pQuantity int,
        //@pPrice decimal(18, 0),
        //@pRating decimal(18, 0),
        //@pCategoryId int
        //AS
        //INSERT INTO Product(Id, Name, Quantity, Price, Rating, CategoryId) VALUES(@pId, @pName, @pQuantity, @pPrice, @pRating, @pCategoryId);
        //RETURN 0

        try
        {
            SqlCommand addCommand = new SqlCommand()
            {
                CommandText = "dbo.usp_AddProduct",
                Connection = conn,
                CommandType = CommandType.StoredProcedure,
            };
            addCommand.Parameters.AddWithValue("@pName", SqlDbType.NVarChar).Value= Nametxtbox.Text;
            addCommand.Parameters.AddWithValue("@pPrice", SqlDbType.Decimal).Value = Pricetxtbox.Text;
            addCommand.Parameters.AddWithValue("@pQuantity", SqlDbType.Int).Value = Quantitytxtbox.Text;
            addCommand.Parameters.AddWithValue("@pCategoryId", SqlDbType.Int).Value = CatIdtxtbox.Text;
            addCommand.Parameters.AddWithValue("@pRating", SqlDbType.Decimal).Value = Ratingtxtbox.Text;

            conn.Open();
            addCommand.ExecuteNonQuery();

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
