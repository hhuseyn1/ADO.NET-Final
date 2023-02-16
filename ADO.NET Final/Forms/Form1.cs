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

        connectionString = configuration.GetConnectionString("SqlServerLibrary");

        conn = new SqlConnection(connectionString);
        fillData();
    }

    public async Task fillData()
    {
        try
        {
            conn?.Open();

            command = new SqlCommand("SELECT Categories.[Name] AS [Category] FROM Categories", conn);
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
                listView.Columns.Add("FullName");
                listView.Columns[0].Width += 100;
                command = new("SELECT Authors.[FirstName]+ ' ' +Authors.[LastName] AS [FullName] FROM Authors,Books INNER JOIN Categories ON Id_Category = Categories.Id WHERE LOWER(Categories.[Name])=LOWER(@p1)  GROUP BY Authors.FirstName,Authors.LastName", conn);
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();

                listView.View = View.Details;
                dataReader = await command.ExecuteReaderAsync();
                while (dataReader.Read())
                {
                    listView.Items.Add((string)dataReader["FullName"]);
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

                command = new("SELECT Authors.[FirstName]+ ' ' +Authors.[LastName] AS [FullName] FROM Authors,Books INNER JOIN Categories ON Id_Category = Categories.Id WHERE LOWER(Categories.[Name])=LOWER(@p1) AND LOWER(Authors.[FirstName]) LIKE '%' + LOWER(@st) +'%' OR LOWER(Authors.[LastName]) LIKE '%' + LOWER(@st) + '%' GROUP BY Authors.[FirstName],Authors.[LastName]", conn);
                command.Parameters.AddWithValue("@st", SqlDbType.Text).Value = Searchtxtbox.Text.ToString();
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();
           
                conn.Open();

                DbDataReader dataReader =await command.ExecuteReaderAsync();

                listView.Items.Clear();
                while (dataReader.Read())
                {
                listView.Items.Add(dataReader[0].ToString());
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

    private void AddBtn_Click(object sender, EventArgs e)
    {

    }

    private void EditBtn_Click(object sender, EventArgs e)
    {

    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {

    }
}