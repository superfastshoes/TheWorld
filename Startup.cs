using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TheWorld.Services;

namespace TheWorld
{
    public class Startup
    {
        private IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            if (_env.IsEnvironment("Development") || _env.IsEnvironment("Testing"))
            {
                // Create an instance of the debug service for each set of requests.
                services.AddScoped<IMailService, DebugMailService>();
            } 
            else
            {
                //
            }
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Middleware - I'm going to hand you some code and want you to do something as the request is happening.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if(env.IsEnvironment("Development"))
            app.UseDeveloperExceptionPage();

            //App standard files that will look for index.html, etc. in the root folder.
            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                //MapRoute allows us to create different routes will take a patern of a URL of different options
                // that are in the URL that's being specified in a request and map them to specific controllers
                config.MapRoute(
                    name: "Default",
                    // URL ex. - "http://localhost:51294/app/about" app = controller, about = action.
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index"}
                    );
            }); 
        }
    }
}
