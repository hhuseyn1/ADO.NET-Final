using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

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

    public void fillData()
    {
        try
        {
            conn?.Open();

            command = new SqlCommand("SELECT Categories.[Name] AS [Category] FROM Categories", conn);
            reader = command.ExecuteReader();
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
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                command = new("SELECT Authors.[FirstName]+ ' ' +Authors.[LastName] AS [FullName] FROM Authors,Books INNER JOIN Categories ON Id_Category = Categories.Id WHERE LOWER(Categories.[Name])=LOWER(@p1)  GROUP BY Authors.FirstName,Authors.LastName", conn);
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();

                listView.View = View.Details;
                dataReader = command.ExecuteReader();
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
}