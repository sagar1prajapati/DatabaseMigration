using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseMigration.Startup))]
namespace DatabaseMigration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
