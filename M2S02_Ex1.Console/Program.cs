/*1. Crie um programa 
**Entrada: **o nome, ano de nascimento, salário do funcionário e a % de reajuste. 
**Saída**: deve mostrar o nome do funcionário, idade e o valor do salário já calculado com o reajuste.*/
System.Console.Write("Digite a nome: ");
string nome = Console.ReadLine();
System.Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());
System.Console.Write("Digite o salário do funcionário: ");
float salario = float.Parse(Console.ReadLine());
System.Console.Write("Digite o percentual de reajuste(%): ");
int percentualReajuste = int.Parse(Console.ReadLine());

int idade = 2022 - anoNascimento;
float salarioReajustado = salario + ((salario * percentualReajuste)/100);

Console.WriteLine($"Olá {nome}, você tem {idade} anos e seu salário com reajuste é de R$ {salarioReajustado}");
