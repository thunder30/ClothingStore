using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothingStore.Startup))]
namespace ClothingStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
