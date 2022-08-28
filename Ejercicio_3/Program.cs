namespace Ejercicio_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(factorial(3));
            
        }
        public static int factorial(int num)
        {
            int resultado = num;
            for (int x = num - 1; x > 1; x--)
            {
                resultado *= x;
            }
            return resultado;
        }

     
    }


}