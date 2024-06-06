
Personas p1 = new Personas();
p1.Name = "Erick";
p1.edad = 29;
p1.Hola_persona();

Personas p2 = new Personas();

p2.Name = "Edgar";
p2.edad = 24;
p2.Hola_persona();

public class Personas
{
    public string Name { get; set; }
    public int edad { get; set; }

    public void Hola_persona()
    {
        Console.WriteLine($"Nombre:{Name}, Edad: {edad}");
    }    
}