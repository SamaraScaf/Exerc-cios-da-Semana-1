//[M1S01] Ex 5 - Tipo do triângulo
int lado1=0, lado2=0, lado3=0;
Console.WriteLine("Tipos de triângulo");

Console.WriteLine("Informe primeiro lado: ");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe segundo lado: ");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro lado: ");
lado3 = int.Parse(Console.ReadLine());

if ((lado1+lado2)>lado3|| (lado2+lado3)>lado1){

if (lado1==lado2 && lado2==lado3){    
 Console.WriteLine("Ele é um triângulo equilátero.");}   

else if (lado1==lado2 || lado2==lado3 || lado3==lado1){
    Console.WriteLine("Ele é um trângulo isósceles.");}

else {
    Console.WriteLine("Ele é um triângulo escaleno.");}
}
else {
Console.WriteLine("Não é um triângulo.");
}