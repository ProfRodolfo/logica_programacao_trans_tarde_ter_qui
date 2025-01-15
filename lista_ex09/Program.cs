// Ex.09 -  Desenvolva um programa que peça um número de 1 a 7 e exiba o dia da semana correspondente (1 para "Domingo", 2 para "Segunda-feira", etc.). Se o número estiver fora desse intervalo, exiba uma  mensagem de erro

Console.WriteLine("Digite o dia da semana em número: ");
int dia = int.Parse(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (dia == 2)
{
    Console.WriteLine("Segunda");
}
else if (dia == 3)
{
    Console.WriteLine("Terça");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta");
}
else if (dia == 5)
{
    Console.WriteLine("Quinta");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta");
}
else if (dia == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Número inválido. Digite entre 1 a 7" );
}