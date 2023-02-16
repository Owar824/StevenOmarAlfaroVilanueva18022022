using TareaSemana4.Entidades;
using TareaSemana4.Negocios;

contadorLetras contadorletras = new contadorLetras();
ClscontadorLetras clscontadorletras = new ClscontadorLetras();

Console.WriteLine("Dame un frase cualquiera: ");
String holi = Console.ReadLine();

contadorletras.texto = holi;

int resultado = clscontadorletras.contadores(contadorletras);

Console.WriteLine($"la cantidad de letras de tu frase es: {resultado}");