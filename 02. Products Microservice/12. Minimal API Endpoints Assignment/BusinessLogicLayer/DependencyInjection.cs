using eCommerce.BusinessLogicLayer.Mappers;
using eCommerce.BusinessLogicLayer.ServiceContracts;
using eCommerce.BusinessLogicLayer.Validators;
using eCommerce.DataAccessLayer.Repositories;
using eCommerce.DataAccessLayer.RepositoryContracts;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.ProductsService.BusinessLogicLayer;

public static class DependencyInjection
{
  public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services)
  {
    //TO DO: Add Business Logic Layer services into the IoC container

    services.AddAutoMapper(typeof(ProductAddRequestToProductMappingProfile).Assembly);

    services.AddValidatorsFromAssemblyContaining<ProductAddRequestValidator>();

    services.AddScoped<IProductsService, eCommerce.BusinessLogicLayer.Services.ProductsService>();
    return services;
  }
}
