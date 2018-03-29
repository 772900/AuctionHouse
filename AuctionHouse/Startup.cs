using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionHouse.Startup))]
namespace AuctionHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
