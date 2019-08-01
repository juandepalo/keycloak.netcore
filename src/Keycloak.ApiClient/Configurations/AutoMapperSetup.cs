﻿using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;


namespace Keycloak.ApiClient.Configurations
{
    public static class AutoMapperSetup
  {
      public static void AddAutoMapperSetup(this IServiceCollection services)
      {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

          // Registering Mappings automatically only works if the
          // Automapper Profile classes are in ASP.NET project
          AutoMapperConfig.RegisterMappings();
      }
  }
}