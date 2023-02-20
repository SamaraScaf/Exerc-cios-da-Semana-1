//[M1S01] Ex 4 - Imposto sobre folha
float salarioBruto = 0; 
Console.WriteLine("Imposto sobre folha de pagamento");

Console.WriteLine("Informe o salário bruto: ");
salarioBruto = float.Parse(Console.ReadLine());

if(salarioBruto <= 900 ){
    Console.WriteLine("Está isento do Imposto de Renda");}

else if(salarioBruto > 900 && salarioBruto  <= 1500){
Console.WriteLine("O desconto do Imposto de Renda será de R$" + salarioBruto/100*5);}

else if(salarioBruto > 1500 && salarioBruto <= 2500){
Console.WriteLine("O desconto do Imposto de Renda será de R$" + salarioBruto/100*10);}

else {
    Console.WriteLine("O desconto do Imposto de Renda será de R$" + salarioBruto/100*20);}
    