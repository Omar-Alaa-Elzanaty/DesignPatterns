namespace StartPoint
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region FacotoryPattern

			FactoryPattern.EnemyShips.FactoryPattern facotoryModel = new FactoryPattern.EnemyShips.FactoryPattern();

			facotoryModel.RunSenario1(); 

			#endregion
		}
	}
}