using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NencyKitchen.BusinessModel.BusinessEntites
{
    public class FoodCategoryResponse
    {
        public int FoodCategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
    }
}
