using Microsoft.Owin;
using Owin;
using Stripe;
using System.Configuration;

[assembly: OwinStartupAttribute(typeof(FastBar.Startup))]
namespace FastBar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            StripeConfiguration.SetApiKey(ConfigurationManager.AppSettings["StripeApiKey"]);
        }
    }
}
