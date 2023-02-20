// [M1S01] Ex 8 - Fibonacci
Console.WriteLine("Sequência Fibonacci");

int f1 = 0;
int f2 = 1;
int fibo;

Console.Write(1 + ",");
for (int i = 0; i < 20; i=i+1){
fibo = f1 + f2;
Console.Write(fibo + ",");
f1 = f2;
f2 = fibo;
}