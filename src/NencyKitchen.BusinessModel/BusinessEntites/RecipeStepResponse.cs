namespace NencyKitchen.BusinessModel.BusinessEntites
{
    public class RecipeStepResponse
    {
        public int RecipeStepId { get; set; }
        public int StepNumber { get; set; }
        public string Instruction { get; set; } = string.Empty;
    }
}
