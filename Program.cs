int Numero;
int Restante; 
int Unidades;
int Dezenas;
int Centenas;

Console.WriteLine("decomposição decimal\n");

Console.Write("Digite um valor inteiro");
Numero = Convert.ToInt32(Console.ReadLine())!;

Restante = Numero;

Unidades = Restante % 10;
Restante /= 10;

Dezenas = Restante % 10; 
Restante /= 10;
 
Centenas = Restante;

Console.WriteLine("$\no numero {numero}possui:");
Console.WriteLine($"{Unidades,10} unidade(s)");
Console.WriteLine($"{Dezenas,10} dezena(s)");
Console.WriteLine($"{Centenas,10} centena(s).");
