// [M1S01] Ex 7 - Boletim 2.0
float notaMedia = 0;
Console.WriteLine("Boletim Escolar");

Console.WriteLine("Qual o nome completo do aluno(a)?");
string nome = Console.ReadLine();

Console.WriteLine("Quantas notas serão inseridas?");
int n = int.Parse(Console.ReadLine());

float[] notas = new float[n];
for (int i = 0; i < n; i=i+1){
    Console.Write($"Digite {i + 1}º nota : ");
    notas[i] = float.Parse(Console.ReadLine());
    notaMedia = notas[i] + notaMedia;}

notaMedia = notaMedia / n;
Console.WriteLine($"Aluno: {nome}");

for (int i = 0; i < n; i=i+1){
    Console.WriteLine($"Nota {i}: {notas[i]}");}

if (notaMedia >= 6){
    Console.WriteLine($"Média: {notaMedia} - Aprovado!");}

else if (notaMedia >= 5){
    Console.WriteLine($"Média: {notaMedia} - Recuperação!");}

else {
    Console.WriteLine($"Média: {notaMedia} - Reprovado!");}

