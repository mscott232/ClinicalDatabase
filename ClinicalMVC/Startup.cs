using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicalMVC.Startup))]
namespace ClinicalMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
