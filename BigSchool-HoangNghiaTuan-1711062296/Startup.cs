using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_HoangNghiaTuan_1711062296.Startup))]
namespace BigSchool_HoangNghiaTuan_1711062296
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
