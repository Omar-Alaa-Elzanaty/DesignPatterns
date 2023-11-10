using AbstractFactoryPattern.Furniture;
using BuilderPattern.Models;
using BuilderPattern;
namespace StartPoint
{
    internal class Program
	{
		static void Main(string[] args)
		{
			#region FacotoryPattern

			FactoryPattern.ClientFactoryPattern facotoryModel = new FactoryPattern.ClientFactoryPattern();

			//facotoryModel.RunEnemyShapSenario(); 
			//facotoryModel.RunFlyingCompanySenario();

			#endregion

			#region AbstractFactoryPattern

			//AbstractFactoryPattern.Furniture.Client.RunSenarioFurnitureSenario(new ModernFurniture());
			//Console.WriteLine("------------");
			//AbstractFactoryPattern.Furniture.Client.RunSenarioFurnitureSenario(new ClassicFurniture());

			#endregion

			#region BuilderPattern
			//BuilderPattern.Client.RunPublicAirplaneSenario();
			//Console.WriteLine();
			//BuilderPattern.Client.RunPrivateAirplaneSenario();
			#endregion
		}
	}
}