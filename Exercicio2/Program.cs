//[M1S01] Ex 2 - Área do Triângulo 
int baseTriangulo=0, alturaTriangulo=0;

Console.WriteLine("Calcular a área do triângulo ");

Console.Write("Informe a base do triângulo: ");
baseTriangulo=int.Parse(Console.ReadLine());

Console.Write("Informe a altura do triângulo: ");
alturaTriangulo=int.Parse(Console.ReadLine());

int resultado=baseTriangulo*alturaTriangulo/2;
Console.WriteLine("A área do triângulo é: " + resultado);

