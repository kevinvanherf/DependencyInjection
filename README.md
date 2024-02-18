# Dependency Injection
## Template

- Clone repository
- Copy path
- Create new project:

![copy](https://raw.githubusercontent.com/PXL-CSWeb/DependencyInjection-Template/media/copypath.png)
![new](https://raw.githubusercontent.com/PXL-CSWeb/DependencyInjection-Template/media/newproject.png)

- Add NuGet packages for EntityFrameworkCore

![efcore](https://raw.githubusercontent.com/PXL-CSWeb/DependencyInjection-Template/media/nuget.png)

- Rename folder "Models" to "ViewModels"
- Create folder "Models"
- Add model "Product"

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; } = default!;
            public decimal? Stock { get; set; }
            [DataType(DataType.Currency)]
            public decimal? Price { get; set; }
        }

- Add folder "Data"
- Add class "ApplicationDbContext"

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            
            }

            public DbSet<Product> Products { get; set; } = default!;
        }

- Add DbContext to services in Program.cs:

        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbConnection"));
        });

- Add Connectionstring to appsettings.json

        {
          "Logging": {
            "LogLevel": {
              "Default": "Information",
              "Microsoft.AspNetCore": "Warning"
            }
          },
          "AllowedHosts": "*",
          "ConnectionStrings": {
            "ProductDbConnection": "Server=(localdb)\\mssqllocaldb;Database=ProductDb;Trusted_Connection=True;MultipleActiveResultSets=true"
          }
        }

- Build solution
- Execute commands:

      Add-Migration "Init Database"
      Update-Database

- Add Scaffolded controller with views for Products

![controller](https://raw.githubusercontent.com/PXL-CSWeb/DependencyInjection-Template/media/controller.png)
![controller](https://raw.githubusercontent.com/PXL-CSWeb/DependencyInjection-Template/media/scaffolded.png)

## Demo
- Add ProductRepository
- Add CounterService