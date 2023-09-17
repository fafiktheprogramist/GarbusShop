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
            services.AddSession();
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
            app.UseSession();

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



            Supplier ronal = new Supplier { Name = "Ronal", Description = "Producent of rims" };
            supplierDataStore.Add(ronal);

            Supplier dotz = new Supplier { Name = "Dotz", Description = "Producent of rims" };
            supplierDataStore.Add(dotz);

            Supplier autec = new Supplier { Name = "Autec", Description = "Rims" };
            supplierDataStore.Add(autec);

            Supplier alutec = new Supplier { Name = "Alutec", Description = "Rims" };
            supplierDataStore.Add(alutec);

            Supplier pirelli = new Supplier { Name = "Pirelli", Description = "Producent of tires" };
            supplierDataStore.Add(pirelli);

            Supplier dezent = new Supplier { Name = "Dezent", Description = "Producent of rims" };
            supplierDataStore.Add(dezent);

            Supplier rial = new Supplier { Name = "Rial", Description = "Producent of rims" };
            supplierDataStore.Add(rial);

            ProductCategory rims = new ProductCategory { Name = "Rims", Department = "Wheel", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            productCategoryDataStore.Add(rims);

            ProductCategory tires = new ProductCategory { Name = "Tires", Department = "Tire", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            productCategoryDataStore.Add(tires);

            ProductCategory trunk = new ProductCategory { Name = "Trunk", Department = "Luggage", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            productCategoryDataStore.Add(trunk);

            ProductCategory accessories = new ProductCategory { Name = "Trunk", Department = "Accessories", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            productCategoryDataStore.Add(accessories);

            productDataStore.Add(new Product { Name = "Alutec Grip Polar", DefaultPrice = 399.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = alutec });
            productDataStore.Add(new Product { Name = "Alutec Grip", DefaultPrice = 379.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = alutec });
            productDataStore.Add(new Product { Name = "Autec Skandic Dark", DefaultPrice = 379.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Autec Skandic", DefaultPrice = 369.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Autec Xenos Dark", DefaultPrice = 499.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Dezent Ta Dark", DefaultPrice = 699.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dezent });
            productDataStore.Add(new Product { Name = "Dezent Ty Graphite", DefaultPrice = 589.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dezent });
            productDataStore.Add(new Product { Name = "Dezent Ty", DefaultPrice = 589.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dezent });
            productDataStore.Add(new Product { Name = "Dezent Tz Graphite", DefaultPrice = 389.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dezent });
            productDataStore.Add(new Product { Name = "Dezent Tz", DefaultPrice = 389.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dezent });
            productDataStore.Add(new Product { Name = "Dotz Dakar Dark", DefaultPrice = 385.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dotz });
            productDataStore.Add(new Product { Name = "Dotz Dakar", DefaultPrice = 385.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dotz });
            productDataStore.Add(new Product { Name = "Dotz Modular", DefaultPrice = 395.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dotz });
            productDataStore.Add(new Product { Name = "Dotz Pharao Dark", DefaultPrice = 499.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dotz });
            productDataStore.Add(new Product { Name = "Dotz Pharao", DefaultPrice = 499.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = dotz });
            productDataStore.Add(new Product { Name = "Rial Astorga", DefaultPrice = 650.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Kodiak Graphite", DefaultPrice = 439.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Kodiak", DefaultPrice = 439.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Lucca Polar", DefaultPrice = 599.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Milano", DefaultPrice = 699.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Ronal R46 Grey", DefaultPrice = 399.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R46 Jetblack", DefaultPrice = 465.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R54 Jetblack", DefaultPrice = 479.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R56", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });

            productDataStore.Add(new Product { Name = "Pirelli P7 Cinturato", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = tires, Supplier = pirelli });

        }

    }
    }

