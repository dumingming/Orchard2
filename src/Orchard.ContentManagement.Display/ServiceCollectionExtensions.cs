﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orchard.ContentManagement.Display.ContentDisplay;
using Orchard.ContentManagement.Display.Coordinators;

namespace Orchard.ContentManagement.Display
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddContentManagementDisplay(this IServiceCollection services)
        {
            services.TryAddTransient<IContentItemDisplayManager, ContentItemDisplayManager>();
            // TODO: Remove IDependency marker and use these registrations
            //services.AddScoped<IContentDisplayHandler, ContentFieldDisplayCoordinator>();
            //services.AddScoped<IContentDisplayHandler, ContentDisplayCoordinator>();
            return services;
        }
    }
}
