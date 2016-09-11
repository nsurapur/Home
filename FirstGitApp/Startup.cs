using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FirstGitApp.Startup))]

namespace FirstGitApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //This configures auth
            ConfigureAuth(app);
        }
    }
}
