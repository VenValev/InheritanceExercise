using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            /*List<Animal> animals = new List<Animal>();

            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                

                Animal animal = null;

                if(command == "Dog")
                {
                    string gender = animalInfo[2];
                    animal = new Dog(name, age, gender);
                }
                else if(command == "Frog")
                {
                    string gender = animalInfo[2];
                    animal = new Frog(name, age, gender);
                }
                else if(command == "Cat")
                {
                    string gender = animalInfo[2];
                    animal = new Cat(name, age, gender);
                }
                else if(command == "Kitten")
                {
                    animal = new Kitten(name, age);
                }
                else if(command == "Tomcat")
                {
                    animal = new Tomcat(name, age);

                }
                else
                {
                    throw new InvalidOperationException("Invalid input!");
                }
                animals.Add(animal);
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal);
            }*/

            string spicies;

            while((spicies = Console.ReadLine()) !="Beast!")
            {
                try
                {
                    string[] spArg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = spArg[0];
                    int age = int.Parse(spArg[1]);
                    string gender = spArg[2];

                    if(spicies == "Dog")
                    {
                        var animal = new Dog(name, age, gender);
                        Console.WriteLine(animal);
                    }
                    else if(spicies == "Cat")
                    {
                        var animal = new Cat(name, age, gender);
                        Console.WriteLine(animal);
                    }
                    else if(spicies == "Frog")
                    {
                        var animal = new Frog(name, age, gender);
                        Console.WriteLine(animal);
                    }
                    else if (spicies == "Kitten")
                    {
                        var animal = new Kitten(name, age);
                        Console.WriteLine(animal);
                    }
                    else if(spicies == "Tomcat")
                    {
                        var animal = new Tomcat(name, age);
                        Console.WriteLine(animal);
                    }
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
