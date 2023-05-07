// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nomes_E_frases = "nathalia";
char um_caracter = 'd';
bool booleanos = false;

int numeros_inteiros = 2023;
long numeros_gigantes_inteiros = 2348308932482395983;// aceita 19 casas de um numero inteiro

decimal decimal_Moeda = 20.05M; // presicao de 28 casas decimais
float float_Moeda = 20.08F; // presisao de 6 casas decimais
double double_Moeda = 20.89D; // precisao de 10 casas decimais

// pode-se usar 'var' no lugar type.

// Convercao de types:
string valor1 = "10";
int valor1Esperado = int.Parse(valor1); //OU:
var valor1Esperado = long.Parse(valor1);// OU:
string valor1esperado = numeros_gigantes_inteiros.ToString();



