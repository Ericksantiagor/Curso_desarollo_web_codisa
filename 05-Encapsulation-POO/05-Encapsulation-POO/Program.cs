person person = new person("Erick",29);
person.HelloPerson();
public class person
{
    private string Name { get; set; }

    private int Edad { get; set; }

    public person(string name, int edad)
    {
        Name = name;
        Edad = edad;
    }
    
    public void HelloPerson()
    {
        Console.WriteLine($"Nombre:{Name}, Edad {Edad}");
        IsAdult(Edad);

    }
    private void IsAdult( int edad)
    {
        if (edad > 18)
        
            Console.WriteLine("Es adulto");
        else    
            Console.WriteLine("No es adulto");
         
    
    }

}
