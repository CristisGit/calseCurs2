using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{ 
    public enum Breed
        { 
        Sharpei,
        ChowChow,
        Tomberonez,
        Akita,
        Husky
        }
    
    class Dog
    {
        //parameterless constructor
        //public Dog()
        //{
 
        //}
 
        //fields
        private string _name;
        string _owner; // private string _owner;
 
 
        private readonly DateTime _birthDate;
        public const decimal PI = 78.141516M;
        public const decimal FurDensity = 78.141516M;
        public static int numberOfInstances;
 
 
        public string Name
        {
            get { return _name; }
            set { _name = value + " 2"; }
 
        }
 
        public int BirthYear
        {
            get
            {
                // NUMBER OF YEARS
                return _birthDate.Year;
            }
        }
 
        public int LifeSpan
        {
            get
            {
                return _birthDate.Year + 15;
            }
        }
 
 //       public int NumberOfOwners { get; }
 
        public string NameAndOwner
        {
            get
            {
                return _name + " " + _owner;
            }
        }
 
        public Dog(string name, string owner)
        {
            _name = name;
            _owner = owner;
            _birthDate = DateTime.Now;
            numberOfInstances++;
        }
 
        //public Dog(string name)
        //{
 
        //}
 
        public void Bark()
        {
            string _name = "local name";
            Console.WriteLine("ham ham");
            decimal awesomePi = PI * 2;
            //PI = 4.15;
        }
 
        public static int GetTotalInstancesCreated()
        {
            return numberOfInstances;
        }
    
        //public int NumberOfOwners { get;}
   

        public Breed BreedType { get; set; }

           public Dog(Breed breed) : this("N/A","N/A")
        { 
            BreedType=breed;
        }
    }
    // proprtues
    // helps us exoise data
    // aids encapsulation
    // 4 types: (by the wwhay we are using them): read-only; write-only; read-write; automatic
    // - can have multiple 
     //- its an automatic proprety.
            //- use when 




}
