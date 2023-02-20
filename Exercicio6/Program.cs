//[M1S01] Ex 6 -  Tabuada
int numero = 0;

Console.Write("Informe a tabuada que você quer treinar: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("Segue abaixo a tabuada desejada:");

for (int i =0; i<=10; i=i+1){
int resultado =  numero*i;
Console.WriteLine($"{numero} x {i} = {resultado}");
}
