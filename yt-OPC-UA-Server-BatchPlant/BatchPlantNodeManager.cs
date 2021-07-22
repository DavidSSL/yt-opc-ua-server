using System;
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
        private readonly BatchPlantState m_batchPlant1;


        public BatchPlantNodeManager(IServerInternal server, ApplicationConfiguration configuration) : base(server,
            configuration)
        {
            m_batchPlant1 = new BatchPlantState(null);
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

        public BatchPlantState BatchPlant1 => m_batchPlant1;

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
                var passiveNode = (BaseObjectState) FindPredefinedNode(
                    new NodeId(BatchPlant.Objects.BatchPlant1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // Convert the untyped Node to a Typed Node that can be manipulated within the Server
                m_batchPlant1.Create(SystemContext, passiveNode);

                // Replaces the Untyped Predefined Nodes with their strongly Typed versions
                AddPredefinedNode(SystemContext, BatchPlant1);

                BatchPlant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                BatchPlant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                new Timer(DoSimulation, null, 5000, 1000);
            }
        }

        // This is simulating the Node
        private void DoSimulation(object state)
        {
            var rnd = new Random();
            BatchPlant1.Mixer.LoadcellTransmitter.Output.ClearChangeMasks(SystemContext, false);
            BatchPlant1.Mixer.LoadcellTransmitter.Output.Value = rnd.Next(1,100);
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
            IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
            IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }
    }
}