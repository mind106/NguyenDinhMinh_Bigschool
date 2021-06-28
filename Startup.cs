using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenDinhMinh_Bigschool.Startup))]
namespace NguyenDinhMinh_Bigschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
