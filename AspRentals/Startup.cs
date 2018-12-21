using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspRentals.Startup))]
namespace AspRentals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
