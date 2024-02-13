using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PhoneBookMVC.Domain;
using PhoneBookMVC.Domain.Entities;
using PhoneBookMVC.Domain.Repositories.Abstract;
using PhoneBookMVC.Domain.Repositories.EF;
using Microsoft.AspNetCore.Identity;

namespace PhoneBookMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //���������� Config �� appsettings.json ��� ��������� connectionString
            Configuration.Bind("PhoneBook", new Config());

            //���������� �������
            services.AddTransient<IPhoneBookRecordsRepository, EFPhoneBookRecordsRepository>();
            services.AddTransient<DataManager>();

            //���������� �������� ��
            services.AddDbContext<AppDBContext>(x => x.UseSqlServer(Config.ConnectionString));

            //��������� ������������ � �������������
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //���������� ������� �������������
            app.UseRouting();

            //���������� ��������� ��������� ������
            app.UseStaticFiles();

            //������������ ��������(endpoints)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
