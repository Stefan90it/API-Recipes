using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.DataModel.EntitesForCreation
{
    public class RecipeStepForCreationDM
    {
        public int StepNumber { get; set; }
        public string Instruction { get; set; } = string.Empty;
    }
}
