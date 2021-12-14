using System;


namespace ConsoleAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dog myDog = new Dog("Grivei", "Maricica");
            //myDog.Name
            //var birthYear = myDog.birthYea
             //var lifeSpan = myDog.lifespan

            
        //    Console.WriteLine(Dog.GetTotalInstancessCreated());
            

         //   Dog YourDog = new Dog("Puffy", "Cristian");
           
        //    Console.WriteLine(Dog.GetTotalInstancessCreated());

         //   Dog randomDog= new Dog(Dog.Breed.Sharpei) - cand enum exista in cadrul clasei DOG
            
            Dog randomDog= new Dog(Breed.Akita);
        }
    }
}
