using NencyKitchen.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.DataModel.EntitesForCreation
{
    public class RecipeIngredientForCreationDM
    {
        public Ingredient Ingredient { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public decimal QtyAmount { get; set; }
    }
}
