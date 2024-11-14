string cadena;
int entero;
bool bolean;
float flotante;
double doble;
char caracter;

cadena = "15.557294";
entero = 15;
bolean = false;
flotante = 15.557294f;
doble = 15.557294;
caracter = '1';

Console.WriteLine("String " + cadena);
Console.WriteLine("Int " + entero);
Console.WriteLine("Bool " + bolean);
Console.WriteLine("Float " + flotante);
Console.WriteLine("Double " + doble);
Console.WriteLine("Char " + caracter);

entero = int.Parse(Console.ReadLine());

Console.WriteLine(entero);

Console.ReadKey();
