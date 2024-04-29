using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Student_Management.StartupOwin))]

namespace Student_Management
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
