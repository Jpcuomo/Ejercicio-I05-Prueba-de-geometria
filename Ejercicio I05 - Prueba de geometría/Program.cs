using Geometria;

namespace Ejercicio_I05___Prueba_de_geometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(5, 10); 
            Punto vertice3 = new Punto(20, 40);
            Rectangulo rectangulo1 = new Rectangulo(vertice1, vertice3);

            MostrarDatos(rectangulo1, vertice1, vertice3);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Area y perimetro: ");
            Console.WriteLine(rectangulo1.Area);
            Console.WriteLine(rectangulo1.Perimetro);
        }

        static void MostrarDatos (Rectangulo rectangulo, Punto vertice1, Punto vertice3)
        {
            Console.WriteLine("Datos de instancia de Rectangulo: ");
            Console.WriteLine($"Valor x de vértice1: {vertice1.X}");
            Console.WriteLine($"Valor y de vértice1: {vertice1.Y}");
            Console.WriteLine($"Valor x de vértice3: {vertice3.X}");
            Console.WriteLine($"Valor y de vértice3: {vertice3.Y}");
            Console.WriteLine("Area: " + rectangulo.Area);
            Console.WriteLine("Perímetro: "+ rectangulo.Perimetro);
        }
    }

}
