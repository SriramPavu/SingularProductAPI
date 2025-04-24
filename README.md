#Setup instructions

Install Visual Studio 2022 with the “.NET desktop & web development” workload (.NET 8 SDK included).
Create a new ASP.NET Core Web API (.NET 8) project named SingularProductAPI
Add three folders: Models, Controllers, Services.
Build in Models, API endpoints in Controllers, and JobDbContext + service classes in Services.
Insert your SQL connection string in appsettings.json; register JobDbContext in Program.cs.
Description of your approach

1.Models — Models Created a classes decorated with EF Core attributes. 2.Services — ApplicationDBContext dbcontext was created and add the Dbset class in the models 3.Controllers — call the services and models to get the data from the backend and return the data 4.Appsettings.Json - Created the connectionstring from the local db connection to database in the appsettings.json 5.Program.cs - In this file indicates the program start from here. 7. Migration - After creating the migration in the package manager console the class are created by default in the migration files. 7.Properties - LaunchSetings.Json: we can change the URL and display in the frontend

Any challenges you faced and how you solved them

Data isn’t reaching the front‑end—the app throws connection‑string errors and can’t open the database.
In the controller, an “invalid object reference” error from DbContext suggests the table (or view) doesn’t exist or the model is mis‑mapped. 3.Data does come through, but the JSON format is incorrect.
OutPut:

https://github.com/user-attachments/assets/fb95aa7e-ce64-4855-9908-794f74f92ddd


