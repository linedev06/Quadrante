double x, y;
Console.WriteLine("--- Quadrante Cartesiano ---");

Console.WriteLine("Entre com o ponto desejado.");

Console.Write("Coordenada x: ");
 x = Convert.ToDouble(Console.ReadLine());

Console.Write("Coordenada y: ");
 y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) 
{
Console.WriteLine("O ponto esta na origem.");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("O ponto esta sobre o eixo y.");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("O ponto esta sobre o eixo x.");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("O ponto esta no segundo quadrante.");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("O ponto eesta no primeiro quadrante.");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("O ponto eesta no terceiro quadrante.");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("O ponto eesta no quarto quadrante.");
}