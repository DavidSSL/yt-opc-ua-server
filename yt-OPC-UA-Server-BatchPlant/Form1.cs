using System.Linq;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace yt_OPC_UA_Server_BatchPlant
{
    public partial class Form1 : Form
    {
        private readonly ApplicationInstance m_application;
        private readonly StandardServer m_server;
        private readonly ApplicationConfiguration m_configuration;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(ApplicationInstance application)
        {
            InitializeComponent();
            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            // Add the URLs to the combobox
            comboBox1.Items.Clear();

            foreach (var endpoint in m_server.GetEndpoints()
                .Where(endpoint => comboBox1.FindStringExact(endpoint.EndpointUrl) == -1))
            {
                comboBox1.Items.Add(endpoint.EndpointUrl);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}