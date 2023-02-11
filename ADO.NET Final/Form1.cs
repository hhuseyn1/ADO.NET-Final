using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ADO.NET_Final;

public partial class Form1 : Form
{
    SqlConnection connection;
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

        connection = new SqlConnection(connectionString);

    }



}