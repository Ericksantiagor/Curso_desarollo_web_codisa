Dog dog = new Dog("Firulais", 3, "chiguagua");
dog.eat();
dog.sleep();
dog.ShowBreead();

public class Animal
{
    protected string Name { get; set; }
    protected int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void eat()
    {
        Console.WriteLine($"{Name} esta comiendo.");
    }

    public void sleep()
    {
        Console.WriteLine($"{Name} esta dumiendo.");
    }
}


public class Dog : Animal
{
    public string Raza { get; set; }

    public Dog(string name, int age, string raza) : base(name, age)
    {
        Raza = raza;

    }

    public void ShowBreead()
    {
        Console.WriteLine($"{Name} es de raza {Raza}");
    }

}