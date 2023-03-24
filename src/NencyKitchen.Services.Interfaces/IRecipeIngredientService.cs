﻿using NencyKitchen.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.Services.Interfaces
{
    public interface IRecipeIngredientService
    {
        Task<IEnumerable<RecipeIngredient>> GetAllIngredientsAsync(int recipeId);
        
    }
}
