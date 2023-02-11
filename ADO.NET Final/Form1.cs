using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace ADO.NET_Final
{
    public partial class Form1 : Form
    {
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
        }
    }
}