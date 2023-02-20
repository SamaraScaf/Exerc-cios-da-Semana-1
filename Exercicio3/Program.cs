
//[M1S01] Ex 3 - Boletim
double nota1 = 0, nota2 = 0, nota3 = 0;
Console.WriteLine("Boletim Escolar");

Console.WriteLine("Informe a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a terceira nota: ");
nota3 = double.Parse(Console.ReadLine());

double mediaNota = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("A média da nota do aluno é: " + mediaNota);

if (mediaNota >= 6){
Console.WriteLine("Aluno Aprovado com média " + mediaNota);}

else if (mediaNota > 5 && mediaNota < 6){

Console.WriteLine("Aluno em Recuperação com média " + mediaNota);
}else{
Console.WriteLine("Aluno Reprovado com média " + mediaNota);};
