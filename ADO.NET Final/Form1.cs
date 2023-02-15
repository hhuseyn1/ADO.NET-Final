using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

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

    private void SearchBtn_Click(object sender, EventArgs e)
    {
            
            try
            {

                if (cmbBox_Category.SelectedItem is null)
                {
                    MessageBox.Show("Please select any category","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Searchtxtbox.Text = null;
                    return;
                }

                command = new("SELECT Authors.[FirstName]+ ' ' +Authors.[LastName] AS [FullName] FROM Authors,Books INNER JOIN Categories ON Id_Category = Categories.Id WHERE LOWER(Categories.[Name])=LOWER(@p1) AND LOWER(Authors.[FirstName]) LIKE LOWER(%@st%) OR LOWER(Authors.[LastName]) LIKE LOWER(%@st%) GROUP BY Authors.FirstName,Authors.LastName", conn);
                command.Parameters.AddWithValue("@st", SqlDbType.Text).Value = Searchtxtbox.Text.ToString();
                command.Parameters.Add("@p1", SqlDbType.NVarChar).Value = cmbBox_Category.SelectedItem.ToString();

                conn.Open();

                DbDataReader dataReader = command.ExecuteReader();

                listView.Items.Clear();
                while (dataReader.Read())
                {
                    listView.Items.Add(dataReader[0].ToString() + " - " +
                    dataReader[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
}