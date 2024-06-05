Animal[] animals = new Animal[3];
animals[0] = new Animal("Animal", 1);
animals[1] = new Dog("Firulais", 2);
animals[2] = new Cat("mañaro", 4);

foreach (Animal animal in animals)
{
      animal.MakeSound();
}




public class Animal
{
    protected string Name { get; set; }
    protected int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

        public virtual void MakeSound()
        {
                Console.WriteLine("El animal hace sonido");
        }

}

public class Dog : Animal
{
    public Dog(string name, int age): base(name, age)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} ladra");
    }


}

public class Cat: Animal
{
    public Cat (string name, int age) : base(name, age)
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} maulla");
    }


}