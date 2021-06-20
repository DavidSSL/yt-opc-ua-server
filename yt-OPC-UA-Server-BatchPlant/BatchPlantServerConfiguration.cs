using System.Runtime.Serialization;
using BatchPlant;

namespace yt_OPC_UA_Server_BatchPlant
{
    [DataContract(Namespace = Namespaces.BatchPlant)]
    public class BatchPlantServerConfiguration
    {
        public BatchPlantServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization
        /// </summary>
        /// <param name="context">The streaming context</param>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Initialize()
        {
        }
    }
}