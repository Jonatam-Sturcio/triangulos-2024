namespace Triangulos.ConsoleApp {
    internal class Triangulo {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        private bool _ehEquilatero(int x, int y, int z) {
            if (x == y && y == z)
                return true;
            else
                return false;
        }
        private bool _ehIsosceles(int x, int y, int z) {
            if (x == y || y == z || x == z)
                return true;
            else
                return false;
        }
        private bool _ehEscaleno(int x, int y, int z) {
            if (x != y && y != z && x != z)
                return true;
            else
                return false;
        }
        private bool _ehTriangulo(int x, int y, int z) {
            if ((x + y) > z && (x + z) > y && (z + y) > x)
                return true;
            else
                return false;
        }
        public void VerificaCategoriaTriangulo() {
            if (_ehTriangulo(x, y, z)) {
                if (_ehEquilatero(x, y, z)) {
                    Console.WriteLine("O triangulo é Equilátero");
                }
                else if (_ehIsosceles(x, y, z)) {
                    Console.WriteLine("O triangulo é Isosceles");
                }
                else if (_ehEscaleno(x, y, z)) {
                    Console.WriteLine("O triangulo é Escaleno");
                }
            }
            else {
                Console.WriteLine("Não é possível formar um triangulo com tais medidas!");
            }
        }
    }
}
