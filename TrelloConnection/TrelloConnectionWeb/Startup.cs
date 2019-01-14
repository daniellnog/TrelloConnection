using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrelloConnectionWeb.Startup))]
namespace TrelloConnectionWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
