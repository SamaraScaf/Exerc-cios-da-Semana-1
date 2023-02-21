// [M1S01] Ex 9 - Banco (Desafio)
List<float> listaDeTransacoes = new List<float>();
float extratoBancario = 0;
string opcao;

do{
Console.WriteLine("Bem vindo ao Banco Nacional Fullstack!");
Console.WriteLine("Por favor selecione uma opção para continuar: ");
Console.WriteLine("1 - Adicionar Transação");
Console.WriteLine("2 - Consultar extrato");
Console.WriteLine("3 - Sair");
opcao = Console.ReadLine ();
 
if (opcao =="1"){
Console.WriteLine("Adicionar Transação");
float Transação = float.Parse(Console.ReadLine());
Console.WriteLine ("Transação realizada!");}

if (opcao =="2"){
Console.WriteLine("Consultar Extrato");
Console.WriteLine("Seu saldo é de: R$" + extratoBancario);}

else if (opcao == "3"){
Console.WriteLine ("Operação Finalizada");} 
}
while (!(opcao=="1" || opcao=="2" || opcao=="3"));