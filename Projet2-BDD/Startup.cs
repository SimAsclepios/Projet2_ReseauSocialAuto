using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Hosting;
using Projet2_BDD.Hubs;
using Projet2_BDD.Models;

using Stripe;
using Projet2_BDD.DataStripe;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;



namespace Projet2_BDD.Dal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {
                options.LoginPath = "/Login/Index";

            });
            services.AddControllersWithViews();
            services.Configure<StripeSettings>(Configuration.GetSection( "Stripe"));
          // services.AddSignalR();
            //services.AddDbContext<ContextBDD>();
            //services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ContextBDD>().AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string test = Configuration.GetSection("Stripe")["Secretkey"];
            StripeConfiguration.SetApiKey(test);
            
            using (ContextBDD ctx = new ContextBDD())
            {
                ctx.InitializeDb();
            }
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            //app.UseHttpsRedirection();
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            
/*#pragma warning disable CS0618 // Le type ou le membre est obsolète
            app.UseSignalR(route => {
                route.MapHub<ChatHub>("/Home/Accueil");
            });*/
#pragma warning restore CS0618 // Le type ou le membre est obsolète
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
