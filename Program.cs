using System;

namespace LojaDeBicicletas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando variáveis
            int funcionarios, bicicletasVendidas;
            double salarioM, salarioF, custoBicicleta, valorVenda, faturamento, comissao, rendaLiquida, despesas;

            //entrada de dados
            Console.WriteLine("Digite os valores pedidos abaixo a seguir");
            Console.Write("Número de funcionarios: ");
            funcionarios = int.Parse(Console.ReadLine());
            Console.Write("Valor do salário: ");
            salarioM = int.Parse(Console.ReadLine());
            Console.Write("Custo de uma Bicicleta: ");
            custoBicicleta = int.Parse(Console.ReadLine());
            Console.Write("Número de Bicicletas vendidas: ");
            bicicletasVendidas = int.Parse(Console.ReadLine());

            //cálculo
            valorVenda = custoBicicleta * 1.5;
            comissao = bicicletasVendidas * custoBicicleta * 0.15 / funcionarios;
            faturamento = bicicletasVendidas * valorVenda;
            salarioF = 2 * salarioM + comissao;
            despesas = salarioF * funcionarios;
            rendaLiquida = faturamento - despesas;

            //entrada dos resultados cálculados
            Console.Write($"O salário final de cada funcionário (com a comissão) é de: R${salarioF}");
            Console.ReadLine();
            Console.Write($"A renda líquida da empresa foi de: R${faturamento - despesas}");
            Console.ReadLine();
        }
    }
}