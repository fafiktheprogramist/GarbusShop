using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Codecool.CodecoolShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Product/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}");
            });

            SetupInMemoryDatabases();
        }

        private void SetupInMemoryDatabases()
        {
            IProductDao productDataStore = ProductDaoMemory.GetInstance();
            IProductCategoryDao productCategoryDataStore = ProductCategoryDaoMemory.GetInstance();
            ISupplierDao supplierDataStore = SupplierDaoMemory.GetInstance();

            Supplier amazon = new Supplier { Name = "Amazon", Description = "Digital content and services" };
            supplierDataStore.Add(amazon);

            Supplier lenovo = new Supplier { Name = "Lenovo", Description = "Computers" };
            supplierDataStore.Add(lenovo);

            Supplier oppo = new Supplier { Name = "Oppo", Description = "Phone" };
            supplierDataStore.Add(oppo);
            
            ProductCategory tablet = new ProductCategory { Name = "Tablet", Department = "Hardware", Description = "A tablet computer, commonly shortened to tablet, is a thin, flat mobile computer with a touchscreen display." };
            productCategoryDataStore.Add(tablet);

            ProductCategory phone = new ProductCategory { Name = "Phone", Department = "Hardware", Description = "A cell phone, device primary designed to make calls but have the same functionalities as tablet." };
            productCategoryDataStore.Add(phone);

            ProductCategory desktop = new ProductCategory { Name = "Desktop", Department = "Hardware", Description = "A desktop computer (often abbreviated desktop) is a personal computer designed for regular use at a stationary location on or near a desk (as opposed to a portable computer) due to its size and power requirements." };
            productCategoryDataStore.Add(desktop);

            productDataStore.Add(new Product { Name = "Amazon Fire", DefaultPrice = 49.9m, Currency = "USD", Description = "Fantastic price. Large content ecosystem. Good parental controls. Helpful technical support.", ProductCategory = tablet, Supplier = amazon });
            productDataStore.Add(new Product { Name = "Lenovo IdeaPad Miix 700", DefaultPrice = 479.0m, Currency = "USD", Description = "Keyboard cover is included. Fanless Core m5 processor. Full-size USB ports. Adjustable kickstand.", ProductCategory = tablet, Supplier = lenovo });
            productDataStore.Add(new Product { Name = "Amazon Fire HD 8", DefaultPrice = 89.0m, Currency = "USD", Description = "Amazon's latest Fire HD 8 tablet is a great value for media consumption.", ProductCategory = tablet, Supplier = amazon });
            productDataStore.Add(new Product { Name = "Oppo A1K", DefaultPrice = 500m, Currency = "USD", Description = "Basic model of cell phone from Oppo sroppo", ProductCategory = phone, Supplier = oppo });
            productDataStore.Add(new Product { Name = "Lenovo 2022 Newest Ideapad 3 Laptop", DefaultPrice = 394m , Currency = "USD", Description = "Memory is 8GB high-bandwidth RAM to smoothly run multiple applications and browser tabs all at once. Hard Drive is 256GB PCIe Solid State Drive which allows to fast bootup and data transfer.", ProductCategory = desktop, Supplier = lenovo});
        }
    }
}
