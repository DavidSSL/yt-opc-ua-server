using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using BatchPlant;
using Opc.Ua;
using Opc.Ua.Server;

namespace yt_OPC_UA_Server_BatchPlant
{
    public class BatchPlantNodeManager : CustomNodeManager2
    {
        private readonly BatchPlantServerConfiguration m_configuration;
        private BatchPlantState m_batchPlant1;
        private Timer m_simulationTimer;

        public BatchPlantNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server,
            configuration)
        {
            SystemContext.NodeIdFactory = this;

            // set 1 namespace for the type model and 1 name for dynamically created Nodes
            var namespaceUrls = new string[2];
            namespaceUrls[0] = BatchPlant.Namespaces.BatchPlant;
            namespaceUrls[1] = BatchPlant.Namespaces.BatchPlant + "/Instance";
            SetNamespaces(namespaceUrls);

            // Get the configuration for the Node Manager
            m_configuration = configuration.ParseExtension<BatchPlantServerConfiguration>();

            // Use suitable default if no configuration exists
            if (m_configuration == null)
            {
                m_configuration = new BatchPlantServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            var predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context, "BatchPlant.PredefinedNodes.uanodes",
                typeof(BatchPlantNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // Find the untyped Batch Plan 1 Node that was created when the Model was loaded
                var passiveMode = (BaseObjectState) FindPredefinedNode(
                    new NodeId(BatchPlant.Objects.BatchPlant1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // Convert the untyped Node to a Typed Node that can be manipulated within the Server
                m_batchPlant1 = new BatchPlantState(null);
                m_batchPlant1.Create(SystemContext, passiveMode);

                // Replaces the Untyped Predefined Nodes with their strongly Typed versions
                AddPredefinedNode(SystemContext, passiveMode);

                m_batchPlant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_batchPlant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputarguments,
            IList<object> outputarguments)
        {
            return ServiceResult.Good;
        }
        
        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputarguments,
            IList<object> outputarguments)
        {
            return ServiceResult.Good;
        }

        // This is simulating the Node
        private void DoSimulation(object state)
        {
            m_batchPlant1.Mixer.LoadcellTransmitter.Output.Value = 85;
        }
    }
}