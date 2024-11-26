using eCommerce.Infrastructure;
using eCommerce.Core;
using eCommerce.API.Middlewares;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();

// Add controllers to the service collection
builder.Services.AddControllers().AddJsonOptions
    (
        Options => { 
            Options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); //Converts string values to correspondent enums, like in our case Gender is enum type
        }
    );

//Build the web application
var app = builder.Build();

app.UseExceptionHandlingMiddleware();

//Routing
app.UseRouting();

//Auth
app.UseAuthentication();
app.UseAuthorization();

//Controller routes
app.MapControllers();

app.Run();
