// Ex.07 - Escreva um programa que solicita dois números ao usuário e determina qual deles é maior. Utilize if, else if e else para exibir a mensagem adequada.

Console.WriteLine("Digite o primeiro número");
int num1  = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"O primeiro número: {num1} é maior que o segundo número: {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"O segundo número: {num2} é maior que o primeiro número: {num1}");
}
else
{
    Console.WriteLine($"Os números são iguais, {num1} e {num2}" );
}
