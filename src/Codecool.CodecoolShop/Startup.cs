using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using Codecool.CodecoolShop.Data;
using Microsoft.EntityFrameworkCore;
using Codecool.CodecoolShop.Domain;

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
            services.AddDbContext<ShopContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Shop")));
            services.AddScoped<IProductCategoryDao, ProductCategoryDaoEF>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
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

            Supplier autec = new Supplier { Name = "Autec", Description = "Producent of rims" };
            supplierDataStore.Add(autec);

            Supplier alutec = new Supplier { Name = "Alutec", Description = "Producent of rims" };
            supplierDataStore.Add(alutec);

            Supplier pirelli = new Supplier { Name = "Pirelli", Description = "Producent of tires" };
            supplierDataStore.Add(pirelli);

            Supplier dezent = new Supplier { Name = "Dezent", Description = "Producent of rims" };
            supplierDataStore.Add(dezent);

            Supplier rial = new Supplier { Name = "Rial", Description = "Producent of rims" };
            supplierDataStore.Add(rial);

            Supplier bridgestone = new Supplier { Name = "Bridgestone", Description = "Producent of tires" };
            supplierDataStore.Add(bridgestone);

            Supplier debica = new Supplier { Name = "D�bica", Description = "Polish producent of tires" };
            supplierDataStore.Add(debica);

            Supplier dunlop = new Supplier { Name = "Dunlop", Description = "Producent of expensive tires" };
            supplierDataStore.Add(dunlop);

            Supplier kormoran = new Supplier { Name = "Kormoran", Description = "Polish producent of good tires" };
            supplierDataStore.Add(kormoran);

            Supplier laufenn = new Supplier { Name = "Laufenn", Description = "German producent of tires." };
            supplierDataStore.Add(laufenn);

            Supplier tompar = new Supplier { Name = "tompar", Description = "Polish producent of car accessories>" };
            supplierDataStore.Add(tompar);

            Supplier thule = new Supplier { Name = "Thule", Description = "Swedish producent of trunks." };
            supplierDataStore.Add(thule);

            ProductCategory rims = new ProductCategory { Name = "Rims", Department = "Rims", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            productCategoryDataStore.Add(rims);

            ProductCategory tires = new ProductCategory { Name = "Tires", Department = "Tires", Description = "Tires are ones of the most important part of your car for safety and efficiency reasons." };
            productCategoryDataStore.Add(tires);

            ProductCategory trunks = new ProductCategory { Name = "Trunks", Department = "Trunks", Description = "Things to carry your luggage." };
            productCategoryDataStore.Add(trunks);

            ProductCategory accessories = new ProductCategory { Name = "Accesories", Department = "Accessories", Description = "Various car accessories." };
            productCategoryDataStore.Add(accessories);

            productDataStore.Add(new Product { Name = "Alutec Grip Polar", DefaultPrice = 399.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = alutec });
            productDataStore.Add(new Product { Name = "Alutec Grip", DefaultPrice = 379.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = alutec });
            productDataStore.Add(new Product { Name = "Autec Skandic Dark", DefaultPrice = 379.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Autec Skandic", DefaultPrice = 369.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Autec Xenos Dark", DefaultPrice = 499.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = autec });
            productDataStore.Add(new Product { Name = "Bridgestone Ecopia", DefaultPrice = 500.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = bridgestone });
            productDataStore.Add(new Product { Name = "Bridgestone Er300", DefaultPrice = 600.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = bridgestone });
            productDataStore.Add(new Product { Name = "Bridgestone Turanza T005", DefaultPrice = 700.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = bridgestone });
            productDataStore.Add(new Product { Name = "Bridgestone Turanza T006", DefaultPrice = 750.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = bridgestone });
            productDataStore.Add(new Product { Name = "Bridgestone Turanza", DefaultPrice = 650.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = bridgestone });
            productDataStore.Add(new Product { Name = "Debica Presto Hp", DefaultPrice = 250.0m, Currency = "USD", Description = "Fantastic price for a low quality product. Cheap polish tire.", ProductCategory = tires, Supplier = debica });
            productDataStore.Add(new Product { Name = "Debica Presto hp 2", DefaultPrice = 250.0m, Currency = "USD", Description = "Fantastic price for a low quality product. Cheap polish tire.", ProductCategory = tires, Supplier = debica });
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
            productDataStore.Add(new Product { Name = "dunlop-sp-sport-bluresponse", DefaultPrice = 900.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = dunlop });
            productDataStore.Add(new Product { Name = "dunlop-sp-sport-maxx-tt", DefaultPrice = 800.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = dunlop });
            productDataStore.Add(new Product { Name = "kormoran-road-performance", DefaultPrice = 300.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = kormoran });
            productDataStore.Add(new Product { Name = "laufenn-s-fit", DefaultPrice = 900.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = laufenn });
            productDataStore.Add(new Product { Name = "laufenn-s-fit-eq", DefaultPrice = 950.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great performance tire.", ProductCategory = tires, Supplier = laufenn });
            productDataStore.Add(new Product { Name = "pirelli-p7-cinturato", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = tires, Supplier = pirelli });
            productDataStore.Add(new Product { Name = "pirelli-p1-cinturato-verde", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = tires, Supplier = pirelli });
            productDataStore.Add(new Product { Name = "pirelli-p7-cinturato-4548", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = tires, Supplier = pirelli });
            productDataStore.Add(new Product { Name = "Rial Astorga", DefaultPrice = 650.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Kodiak Graphite", DefaultPrice = 439.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Kodiak", DefaultPrice = 439.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Lucca Polar", DefaultPrice = 599.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Rial Milano", DefaultPrice = 699.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = rial });
            productDataStore.Add(new Product { Name = "Ronal R46 Grey", DefaultPrice = 399.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R46 Jetblack", DefaultPrice = 465.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R54 Jetblack", DefaultPrice = 479.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Ronal R56", DefaultPrice = 299.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategory = rims, Supplier = ronal });
            productDataStore.Add(new Product { Name = "Bicycle rack", DefaultPrice = 2419.0m, Currency = "USD", Description = "Universal bicycle rack at great price.", ProductCategory = trunks, Supplier = thule });
            productDataStore.Add(new Product { Name = "Roof box", DefaultPrice = 1350.0m, Currency = "USD", Description = "Universal roof box.", ProductCategory = trunks, Supplier = thule });
            productDataStore.Add(new Product { Name = "Universal trunk", DefaultPrice = 3560.0m, Currency = "USD", Description = "Universal roof rack.", ProductCategory = trunks, Supplier = tompar });
            productDataStore.Add(new Product { Name = "Accessories set", DefaultPrice = 129.0m, Currency = "USD", Description = "A set of first necessities so that you are never surprised.", ProductCategory = accessories, Supplier = tompar });
            productDataStore.Add(new Product { Name = "Emergency triangle", DefaultPrice = 19.0m, Currency = "USD", Description = "An emergency triangle to set up when neccessary.", ProductCategory = accessories, Supplier = tompar });

        }

    }


}


