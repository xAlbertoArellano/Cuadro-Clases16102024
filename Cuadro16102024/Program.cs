// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class 16102024
{
    static void Main()
    {
        Console.WriteLine("Cuadro 3x3");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Alumno alumno = new Alumno
        {
            Nombre = "Alberto Arellano",
            Edad = 20,
            Matricula = "221090005",
            Carrera = "Ingeniería en Sistemas",
            Promedio = 9.2
        };

        Mascota mascota = new Mascota
        {
            Nombre = "Spanky",
            Especie = "Perro",
            Raza = "Perro",
            Edad = 5,
            Color = "Cafe"
        };

        Materia materia = new Materia
        {
            Nombre = "Matemáticas",
            Profesor = "Maria Gomez",
            HorasSemanales = 4,
            Creditos = 6,
            Aula = "301"
        };

        ProductoLimpieza productoLimpieza = new ProductoLimpieza
        {
            Nombre = "Cloro",
            Marca = "Cloralex",
            Contenido = "1 Litro",
            Tipo = "Desinfectante",
            Precio = 25.99
        };


        Cancion cancion = new Cancion
        {
            Titulo = "Smells Like Teen Spirit",
            Artista = "Nirvana",
            Album = "Nevermind",
            Año = 1991,
            Duracion = "5:01"
        };

    }
}



class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Matricula { get; set; }
    public string Carrera { get; set; }
    public double Promedio { get; set; }
}

class Mascota
{
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public string Raza { get; set; }
    public int Edad { get; set; }
    public string Color { get; set; }
}

class Materia
{
    public string Nombre { get; set; }
    public string Profesor { get; set; }
    public int HorasSemanales { get; set; }
    public int Creditos { get; set; }
    public string Aula { get; set; }
}

class ProductoLimpieza
{
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Contenido { get; set; }
    public string Tipo { get; set; }
    public double Precio { get; set; }
}

class Cancion
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public string Album { get; set; }
    public int Año { get; set; }
    public string Duracion { get; set; }
}
