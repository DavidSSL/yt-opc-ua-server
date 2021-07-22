using System;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Configuration;

namespace yt_OPC_UA_Server_BatchPlant
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            var application = new ApplicationInstance
            {
                ApplicationType = ApplicationType.Server,
                ConfigSectionName = "BatchPlantServer"
            };

            try
            {
                // Process and command line arguments
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service
                var batchPlantServer = new BatchPlantServer();

                if (!Environment.UserInteractive)
                {
                    application.StartAsService(batchPlantServer);
                    return;
                }

                // load the application configuration
                application.LoadApplicationConfiguration("BatchPlantServer.Config.xml", false).Wait();

                // check the application certificate
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Start the server
                application.Start(batchPlantServer).Wait();

                // Run the application interactively
                Application.Run(new Form1(application));
                
            }
            catch (Exception e)
            {
                var text = $"Exception: {e.Message}";
                if (e.InnerException != null)
                {
                    text += $"{Environment.NewLine}Inner exception: ";
                    text += e.InnerException.Message;
                }

                MessageBox.Show(text, application.ApplicationName);
            }
        }
    }
}