using Microsoft.EntityFrameworkCore;
using NencyKitchen.DataModel.Entities;
using NencyKitchen.Services.DbContexts;
using NencyKitchen.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.Services
{
    public class RecipeIngredientService : IRecipeIngredientService
    {
        private readonly NencyKitchenDbContext _nencyKitchenDbContext;

        public RecipeIngredientService(NencyKitchenDbContext nencyKitchenDbContext)
        {
            _nencyKitchenDbContext = nencyKitchenDbContext;
        }
        public async Task<IEnumerable<RecipeIngredient>> GetAllIngredientsAsync(int recipeId)
        {
            return await _nencyKitchenDbContext.RecipeIngredients.
                Include(i => i.Ingredient).
                Include(m => m.MeasurementUnit).
                Where(r => r.RecipeId == recipeId ).ToListAsync();
        }
    }
}
