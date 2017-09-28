using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Lab13George
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
/* Add/Adjust Taghelpers/HTML/CSS to your site to make it more client ready.
 * Add at least one Model named Register, with basic properties of what a student registration should consist of DONE
 * Use Scaffolding to generate the CRUD actions off of a "Register" Control. DONE
 * Create an initial Migration DONE
 * Have a solid Home page for when users when they visit your site. 
 * Include a link to the Register pages for a student to register
 */
