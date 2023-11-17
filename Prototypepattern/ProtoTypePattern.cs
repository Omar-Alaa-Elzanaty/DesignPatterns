using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototypepattern
{

	public class ProtoTypePattern
	{
		public void RunshapeTest() 
		{

			var circle = new Circle()
			{
				Name = "circle1",
				Vertices = new() { "UP"}
			};
			IShape shape = circle;

			var copyCircle = (Circle)shape.Clone();
			Console.WriteLine("Circle Name: "+circle.Name);
			Console.WriteLine("Circle vertices: "+circle.Vertices.First());
            Console.WriteLine($"Circle ref: {circle.GetHashCode()}");

            Console.WriteLine();
			
			Console.WriteLine("CopyCircle Name: "+copyCircle.Name);
			Console.WriteLine("CopyCircle vertices: " + copyCircle.Vertices.First());
			Console.WriteLine($"CopyCircle ref: {copyCircle.GetHashCode()}");

			Console.WriteLine();
            Console.WriteLine("Change name of CopyCircle");
			copyCircle.Name = "Circle2";
			copyCircle.Vertices[0] = "Down";
            Console.WriteLine();

            Console.WriteLine($"Circle ref: {circle.Name}");
			Console.WriteLine("Circle vertices: " + circle.Vertices.First());

			Console.WriteLine();
            Console.WriteLine($"CopyCircle ref: {copyCircle.Name}");
			Console.WriteLine("CopyCircle vertices: " + copyCircle.Vertices.First());

			Console.WriteLine();
			Console.WriteLine("Circle ref  ==  CopyCircle ref /" + (circle == copyCircle));
        }
	}
}
