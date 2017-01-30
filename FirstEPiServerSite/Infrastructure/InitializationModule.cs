using System.Web.Routing;

using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace FirstEPiServerSite.Infrastructure
{
    [InitializableModule]
    
    public class InitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
