﻿using Orchard.Environment.Recipes.Models;
using Orchard.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace Orchard.Environment.Recipes.Services
{
    public interface IRecipeParser : IDependency
    {
        Recipe ParseRecipe(JObject recipeDocument);
    }

    public static class RecipeParserExtensions
    {
        public static Recipe ParseRecipe(this IRecipeParser recipeParser, string recipeText)
        {
            var recipeDocument = JObject.Parse(recipeText);
            return recipeParser.ParseRecipe(recipeDocument);
        }
    }
}