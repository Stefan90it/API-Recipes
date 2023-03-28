namespace NencyKitchen.BusinessModel.BusinessEntites
{
    public class RecipeIngredientResponse
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public IngredientResponse Ingredient { get; set; }
        public int IngredientId { get; set; }
        public MeasurementUnitResponse MeasurementUnit { get; set; }
        public int MeasurementUnitId { get; set; }
        public decimal QtyAmount { get; set; }
    }
}
