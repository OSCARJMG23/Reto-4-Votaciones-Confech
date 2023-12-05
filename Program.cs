// See https://aka.ms/new-console-template for more information
using System.Collections;
using Reto_4_Votaciones_Confech;

int totalAceptaron = 0;
int totalRechazaron = 0;
int totalEmpataron = 0;

Console.WriteLine("Bienvenido a las Votaciones de la Confech");

List<Universidad> Universidades = new List<Universidad>();

Console.Write("Ingrese el numero de Universidades: ");
int numUniversidades = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numUniversidades; i++)
{
    Console.Write("Universidad: ");
    string? Universidad = Console.ReadLine();
    string? Voto;
    var Aceptan = 0;
    var Rechazan = 0;
    var Blancos = 0;
    var Nulos = 0;
    do
    {

        Console.Write("Voto: ");
        Voto = Console.ReadLine();
        if (Voto?.ToLower() == "a")
        {
            Aceptan = Aceptan + 1;
        }
        if (Voto?.ToLower() == "r")
        {
            Rechazan = Rechazan + 1;
        }
        if (Voto?.ToLower() == "b")
        {
            Blancos = Blancos + 1;
        }
        if (Voto?.ToLower() == "n")
        {
            Nulos = Nulos + 1;
        }
    } while (Voto?.ToLower() !="x");
    Console.WriteLine($"{Universidad} {Aceptan} aceptan, {Rechazan} rechazan, {Blancos} blancos, {Nulos} Nulos");
    Universidades.Add(new Universidad(Universidad!, Aceptan, Rechazan, Blancos, Nulos));
    
}
foreach (var universidad in Universidades)
{
    if(universidad.Aceptan > universidad.Rechazan){
        totalAceptaron +=1;
    }if(universidad.Rechazan > universidad.Aceptan){
        totalRechazaron += 1;
    }if(universidad.Aceptan == universidad.Rechazan){
        totalEmpataron +=1;
    }
}


Console.WriteLine($"Universidades que aceptan: {totalAceptaron}"); 
Console.WriteLine($"Universidades que Rechazan:{totalRechazaron} "); 
Console.WriteLine($"Universidades que Empatan: {totalEmpataron}"); 