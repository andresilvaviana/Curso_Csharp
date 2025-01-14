namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            num1 = 45;
            num2 = 35;
           
            
            num3 = num1 + num2;
            Console.WriteLine("a soma de {0} + {1} = {2}", num1, num2, num3);

            num3 = num1 - num2;
            Console.WriteLine("a subtração de {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;
            Console.WriteLine("a multiplição de {0} * {1} = {2}", num1, num2, num3);
           
            resposta = num1 / num2;
            Console.WriteLine("a divisão de {0} / {1} = {2}", num1, num2, resposta);

            resposta = num1 % num2;
            Console.WriteLine("o resto da divisão {0} % {1} = {2}", num1, num2, resposta);

            num4 = 35f;
            resposta = num1 / num4;

            Console.WriteLine("a divisão de {0} / {1} = {2}", num1, num4, resposta);
        }
    }
}
