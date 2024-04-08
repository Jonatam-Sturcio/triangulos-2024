namespace Triangulos.ConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Triangulo tri = new Triangulo();
            while (true) {
                try {
                    Console.WriteLine("Informe o valor de X:");
                    tri.x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor de Y:");
                    tri.y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor de Z:");
                    tri.z = int.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado:");
                    tri.VerificaCategoriaTriangulo();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex) {
                    Console.WriteLine("Apenas numeros são aceitos!!");
                    Console.ReadLine();
                    Console.Clear();
                }
            });
        }
    }
}
