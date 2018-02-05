using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CategoryProduct.Startup))]
namespace CategoryProduct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
