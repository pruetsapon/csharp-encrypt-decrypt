using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EncryptAndDecrypt.Startup))]
namespace EncryptAndDecrypt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
