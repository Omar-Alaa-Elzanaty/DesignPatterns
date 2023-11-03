
namespace AbstractFactoryPattern.Furniture
{
	public class ModernFurniture : IFurnitureFactory
	{
		public BedFactory CreateBed()
		{
			return new ModernBed();
		}

		public ChairFactory CreateChair()
		{
			return new ModernChair();
		}
	}
}
