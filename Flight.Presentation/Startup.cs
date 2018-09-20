using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Flight.Presentation.Startup))]
namespace Flight.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
