Console.Write("Digite o primeiro numero a ser calculado: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo numero a ser calculado: ");
int numero2 = Convert.ToInt32(Console.ReadLine());


int soma = numero1 + numero2;
int subtracao = numero1 - numero2;
int multiplicacao = numero1 * numero2;

if (numero2 == 0)
    Console.WriteLine("Erro divisão por 0");
else
    Console.WriteLine($"Resultado Divisão: {numero1 / numero2}"); ;

Console.WriteLine($"Resultado Soma: {soma}");
Console.WriteLine($"Resultado Subtracao: {subtracao}");
Console.WriteLine($"Resultado Multiplicacao: {multiplicacao}");

