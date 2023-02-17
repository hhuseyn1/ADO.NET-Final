using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace ADO.NET_Final;

public partial class Form1 : Form
{
    SqlConnection conn = null;
    SqlDataReader? reader = null;
    SqlCommand command = null;
    string connectionString = null;
    public Form1()
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
        fillData();
    }
    public async Task fillData()
    {
        try
        {
            conn?.Open();

            command = new SqlCommand("SELECT Category.[Name] AS [Category] FROM Category", conn);
            reader = await command.ExecuteReaderAsync();
            cmbBox_Category.Items.Add("-");
            while (reader.Read())
            {
                cmbBox_Category.Items.Add(reader["Category"]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn?.Close();
            reader?.Close();
        }
    }
    private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataReader dataReader = null;
        listView.Columns.Clear();
        listView.Items.Clear();
        if (cmbBox_Category.SelectedItem != null)
        {

            try
            {
                conn?.Open();
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");
                listView.Columns.Add("Price");
                listView.Columns.Add("Quantity");
                listView.Columns.Add("Rating");
                listView.Columns.Add("CategoryId");
                command = new("SELECT Product.Id AS [Id] ,Product.[Name] AS [Name],Product.[Price] AS [Price],Product.[Quantity] AS [Quantity],Product.[CategoryId] AS [CategoryId],Product.[Rating] AS [Rating] FROM Product INNER JOIN Category ON CategoryId = Category.Id WHERE LOWER(Category.[Name])=LOWER(@p1)  GROUP BY Product.Id ,Product.[Name] ,Product.Price,Product.Quantity ,Product.CategoryId,Product.Rating", conn);
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();

                listView.View = View.Details;
                for (int i = 1; i < listView.Columns.Count-1; i++)
                listView.Columns[i].Width += 100;

                dataReader = await command.ExecuteReaderAsync();
                while (dataReader.Read())
                {
                    listView.Items.Add(dataReader["Id"].ToString());
                    for (int i = 0; i < listView.Items.Count; i++)
                    {
                    listView.Items[i].SubItems.Add(dataReader["Name"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Price"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Quantity"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Rating"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["CategoryId"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn?.Close();
                reader?.Close();
            }
        }
    }

    private async void SearchBtn_ClickAsync(object sender, EventArgs e)
    {
            try
            {

            if (cmbBox_Category.SelectedItem is null )
                {
                    MessageBox.Show("Please select any category","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Searchtxtbox.Text = null;
                    return;
                }

                command = new("SELECT Product.Id AS [Id] ,Product.[Name] AS [Name],Product.[Price] AS [Price],Product.[Quantity] AS [Quantity],Product.[CategoryId] AS [CategoryId],Product.[Rating] AS [Rating] FROM Product INNER JOIN Category ON CategoryId = Category.Id WHERE LOWER(Category.[Name])=LOWER(@p1) AND LOWER(Product.[Name]) LIKE '%' + LOWER(@st) +'%' GROUP BY Product.Id ,Product.[Name] ,Product.Price,Product.Quantity ,Product.CategoryId,Product.Rating", conn);
                command.Parameters.AddWithValue("@st", SqlDbType.Text).Value = Searchtxtbox.Text.ToString();
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();
           
                conn.Open();

                DbDataReader dataReader =await command.ExecuteReaderAsync();

                listView.Items.Clear();
                while (dataReader.Read())
                {
                listView.Items.Add(dataReader[0].ToString());
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    listView.Items[i].SubItems.Add(dataReader["Name"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Price"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Quantity"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["Rating"].ToString());
                    listView.Items[i].SubItems.Add(dataReader["CategoryId"].ToString());
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                Searchtxtbox.Text = null;
            }
    }
    private bool CheckSelectedItem()
    {
        foreach (var item in listView.SelectedItems)
        {
            if (item is not null)
                return true;
        }
        return false;
    }
    private void AddBtn_Click(object sender, EventArgs e)
    {
     AddProduct addAuthor = new();
     addAuthor.Show();
    }
   
    private void EditBtn_Click(object sender, EventArgs e)
    {
       
        if (cmbBox_Category.SelectedItem is null || !CheckSelectedItem())
        {
            MessageBox.Show("Please select any author","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            return;
        }
        else
        {
            int id = 0;
            id = Int32.Parse(listView.SelectedItems[0].Text);
            EditProduct editAuthor = new(id);
            editAuthor.Show();
        }

    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        if (cmbBox_Category.SelectedItem is null || !CheckSelectedItem())
        {
            MessageBox.Show("Please select any author", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        else
        {
            //Create Store Procedure

            //CREATE PROCEDURE usp_DeleteProduct
            //@pId int
            //AS

            //DELETE FROM Product WHERE Product.Id = @pId
            //RETURN 0
            try
            {
                SqlCommand deleteCommand = new SqlCommand()
                {
                    CommandText = "dbo.usp_DeleteProduct",
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure,
                };
                deleteCommand.Parameters.AddWithValue("@pId", int.Parse(listView.SelectedItems[0].Text));

                conn.Open();
                deleteCommand.ExecuteNonQuery();

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
    }
}