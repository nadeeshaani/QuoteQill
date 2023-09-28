using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuoteQill.Startup))]
namespace QuoteQill
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
