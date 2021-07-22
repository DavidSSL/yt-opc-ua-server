using System.Collections.Generic;
using Opc.Ua;
using Opc.Ua.Server;

namespace yt_OPC_UA_Server_BatchPlant
{
    public class BatchPlantServer : StandardServer
    {
        private readonly List<INodeManager> m_nodeManagers;

        public List<INodeManager> NodeManagers => m_nodeManagers;

        public BatchPlantServer()
        {
            m_nodeManagers= new List<INodeManager>();
        }
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server,
            ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            // create the custom Node Managers.
            m_nodeManagers.Add(new BatchPlantNodeManager(server, configuration));

            // Create Master Node Manager
            return new MasterNodeManager(server, configuration, null, m_nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            var properties = new ServerProperties
            {
                ManufacturerName = "Industry40tv",
                ProductName = "BatchPlant InformationModel Server",
                ProductUri = "http://opcfoundation.org/BatchPlant/InformationModelServer/v1.0",
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = Utils.GetAssemblyBuildNumber(),
                BuildDate = Utils.GetAssemblyTimestamp()
                // TBD - All application have software certificates that need to be added to the properties
            };

            return properties;
        }
    }
}