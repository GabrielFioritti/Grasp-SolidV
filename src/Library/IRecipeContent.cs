namespace Full_GRASP_And_SOLID;

public interface IRecipeContent
{
    public Product FinalProduct { get; set; }
    public void AddStep(Product input, double quantity, Equipment equipment, int time);
    public void AddStep(string description, int time);
    public void RemoveStep(BaseStep step);
    string GetTextToPrint();
    public double GetProductionCost();
}