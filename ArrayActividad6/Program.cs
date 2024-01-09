namespace ArrayActividad6
{
    class program
    {
        public static void Main(String[] args)
        {
            int[] numeros = { 10, 45, 60, 6, 7, 3, 2, 10 };
            Console.WriteLine("Longitud del array: " + numeros.Length);
            Console.WriteLine(numeros[numeros.Length - 8]);
            Console.WriteLine(numeros[numeros.Length - 2]);
            Console.WriteLine(numeros[numeros.Length - 1]);
            Console.WriteLine("");

            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");

            Console.WriteLine(numeros[7] = 100);
            Console.WriteLine("");

            Array.Reverse(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");

            int[] numerosDos = { 45, 56, 2, -1, 98, 34 };
            Console.WriteLine(numerosDos.Length);
            Console.WriteLine(numerosDos[numerosDos.Length - 2]);
            Console.WriteLine(numerosDos[numerosDos.Length - 1]);
            Console.WriteLine(numerosDos[numerosDos.Length - 6]);
        }
    }
}