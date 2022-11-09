namespace vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 1
             * 
            int[] vec = { 10, 20, 5, 15, 30, 20 };
            int mayor = vec[0], total = 0, cont = 0;

            for (int n = 0; n < vec.Length; n++) {

                total = total + vec[n];

                if (n % 2 == 1) {
                    Console.WriteLine($"Posicion impar {n} valor: {vec[n]}");
                }

                if (vec[n] > mayor) {
                    mayor = vec[n];
                }

                if (vec[n] == 20) {
                    cont++;
                }
            }

            Console.WriteLine($"El total es: {total}");
            Console.WriteLine($"El mayor es: {mayor}");
            Console.WriteLine($"El 20 aparece: {cont} veces");
            Console.ReadKey();

            
             * Ejercicio 2 y 3

            double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            string[] mes = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            double total = 0, minimo = inflacion[0], maximo = inflacion[0];
            string mes_min = "", mes_max = "";

            for (int n = 0; n < inflacion.Length; n++) {

                total = total + inflacion[n];

                if (inflacion[n] < minimo) {
                    minimo = inflacion[n];
                    mes_min = mes[n];
                }

                if (inflacion[n] > maximo) {
                    maximo = inflacion[n];
                    mes_max = mes[n];
                }
            }

            Console.WriteLine($"Inflación más baja: {minimo}, en el mes: {mes_min}");
            Console.WriteLine($"Inflación más alta: {maximo}, en el mes: {mes_max}");
            Console.WriteLine($"Promedio: " + total / 12);
            Console.ReadKey();
            
            // Ejercicio 4

            double[] facturacion = new double[6];
            double total = 0, maximo = 0, minimo;
            int n;

            for ( n = 0; n < facturacion.Length; n++) {
                Console.WriteLine("Ingrese facturación: ");
                facturacion[n] = double.Parse(Console.ReadLine());
            }

            minimo = facturacion[0];

            for ( n = 0; n < facturacion.Length; n++) {

                total = total + facturacion[n]; //total += facturacion[n];

                if (facturacion[n] > maximo) {
                    maximo = facturacion[n];
                }

                if (facturacion[n] < minimo){
                    minimo = facturacion[n];
                }
            }
            Console.WriteLine($"Facturación total: {total}");
            Console.WriteLine("Promedio: " + total / 6);
            Console.WriteLine($"Maxima facturación: {maximo}");
            Console.WriteLine($"Minima facturación: {minimo}");
            Console.ReadKey();

            // Ejercicio 5

            int[] origen = { 2, 10, -4, 8, 0 };
            int[] destino = new int[origen.Length];

            for (int n = 0; n < origen.Length; n++) {
                destino[n] = origen[n];
            }

            for (int n= 0; n < origen.Length; n++) {
                Console.WriteLine($"Indice: {n}, valor: {destino[n]}");
            }

            Console.ReadKey();

            // Desafio 1

            int[] origen = { 1002, 104, 309, 500};
            int[] destino = new int[ origen.Length ];

            for (int n = 0; n < origen.Length; n++) {
                destino[n] = origen[ origen.Length - n - 1];
            }

            for (int n = 0; n < origen.Length; n++) {
                Console.WriteLine($"Indice: {n}, valor: {destino[n]}");
            }

            Console.ReadKey();

            */

            // desafio 2

            int[] facturacion = { 80, 20, 50, 40, 60, 70, 80, 30, 50, 20, 40, 60 };
            int[] trimestre = new int[5];
            int total1 = 0, total2 = 0, total3 = 0, total4 = 0;
            for (int n = 0; n < facturacion.Length; n++)
            {
                if (n <= 2)
                {
                    total1 = total1 + facturacion[n];
                }
                if (n >= 3 & n <= 5)
                {
                    total2 = total2 + facturacion[n];
                }

                if (n >= 6 & n <= 8)
                {
                    total3 = total3 + facturacion[n];
                }
                if (n >= 9)
                {
                    total4 = total4 + facturacion[n];
                }
            }
            trimestre[1] = total1;
            trimestre[2] = total2;
            trimestre[3] = total3;
            trimestre[4] = total4;
            for (int n = 1; n < trimestre.Length; n++)
            {
                Console.WriteLine("Trimestre: " + n + " Facturacion: " + trimestre[n]);
            }
            Console.ReadKey();
        }
    }
}