using Generic.Models;


int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = "O numero " + numero + " " + "é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);