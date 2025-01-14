namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            Console.WriteLine("Digite um numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            num2 = Convert.ToInt32(Console.ReadLine());


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

            Console.WriteLine("a divisão de {0} / {1} = {2}", num1, num4, resposta); ;
        }
    }
}
