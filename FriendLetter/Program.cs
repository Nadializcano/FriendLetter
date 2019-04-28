using System.IO;
using Microsoft.AspNetCore.Hosting;
//same namespace as Startup.cs This ensures both can access each other.
namespace FriendLetter
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
      .UseKestrel()
      .UseContentRoot(Directory.GetCurrentDirectory())
      .UseIISIntegration()
      .UseStartup<Startup>()
      .Build();

    host.Run();

    }
  }
}
