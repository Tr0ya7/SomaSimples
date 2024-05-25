namespace App
{
    internal class Program
    {
        static int firstValue;
        static int secondValue;

        static void Main(string[] args)
        {
            GetFirstValue();
            GetSecondValue();

            int operationResult = firstValue + secondValue;

            Console.WriteLine($"Resultado: {operationResult}");
        }

        /* static void ValidationValues(int var, Action methodName)         tentativa de previnir mensagens de erro padrão do programa
        {
            while (true)
            {
                try
                {
                    break;
                }
                catch (FormatException) //(var.GetType() != typeof(int) || firstValue == 0)
                {
                    methodName();
                }
            }
        } */

        static void GetFirstValue()
        {
            Console.Write("Digite o primeiro valor da soma: ");
            firstValue = int.Parse(Console.ReadLine());

            //ValidationValues(firstValue, GetFirstValue);
        }

        static void GetSecondValue()
        {
            Console.Write("Digite o segundo valor da soma: ");
            secondValue = int.Parse(Console.ReadLine());

            //ValidationValues(secondValue, GetSecondValue);
        }
    }
}