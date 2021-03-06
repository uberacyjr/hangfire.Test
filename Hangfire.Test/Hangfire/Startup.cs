﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hangfire.Startup))]
namespace Hangfire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GlobalConfiguration.Configuration
                .UseSqlServerStorage("Hangfire");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
