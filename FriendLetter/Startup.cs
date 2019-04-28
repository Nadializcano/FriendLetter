using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  //Class
  public class Startup
  {
    //Constructor for Startup Class
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }
    //Requiered built-in method used to set up an application's server
    public void ConfigureServices(IServiceCollection services)
    {
      //adds the MVC service to the project
      services.AddMvc();
    }
    //Requiered built-in method. It calls Configure() when the app launches. responsible to tell our app how to handle requests to the server
    public void Configure(IApplicationBuilder app)
    {
      //Tells app that we'll be using MVC framework to respond to HTTP resquests. It tells to use Index action of the Home Controller as default route
      app.UseMvc(routes =>
      {
        routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
      });
      //not Requiered to launch our app but good for test our Configure() method
      // this lines tell our app to print "Hello World"
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
        });
    }
  }
}
