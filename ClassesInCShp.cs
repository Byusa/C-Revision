using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate double GetSum(double num1, double num2);

namespace ClassesInCShp
{
/*-----------------------------------1)a)Animal(setters,getters,constructors)------------------------------------ */
    class Animal{
        public double height {get; set;}
        public double weight {get; set;}
        public string sound  {get; set;}

        public string name;

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }
        //Constructors
        public Animal(){
            this.height=0;
            this.weight=0;
            this.name="name";
            this.sound="sound";
        }

        //Constructors
        public Animal(double height, double weight, string name, string sound ){
            this.height=height;
            this.weight=weight;
            this.name=name;
            this.sound=sound;

            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        //get the number of animal method
        public static int getNumOfAnimals(){
            return numOfAnimals;
        }

        public  string toString(){
            return String.Format("{0} is {1} inches tall, weight {2} lbs and likes to say {3}", 
                                    name, height, weight,sound);
        }

        public int getSum(int num1=1, int num2=1){
            return num1+num2;
        }
        //Overload
        public double getSum(double num1=1, double num2=1){
            return num1+num2;
        }


        static void Main(string[] args){
            /*--------Part 1)Animal-------------- */

            /*Animal dog  = new Animal( 15, 10, "Dog", "Woof");
            Console.WriteLine("{0} says {1}", dog.name, dog.sound);
            Console.WriteLine("Number of Animals "+ Animal.getNumOfAnimals());
            Console.WriteLine(dog.toString());

            Console.WriteLine(dog.getSum(num2:1.4, num1:2.7));//nice way of twisting them
        
            Animal Gorilla = new Animal{
                name="Gorilla",
                height =16,
                weight = 18,
                sound = "rrihh"
            };

            Cat katty = new Cat();
            Console.WriteLine(katty.toString());

            katty = new Cat(20,15, "katty", "myaow", "fish");
            Console.WriteLine(katty.toString()); */
            
            /*--------Part 2)Shape-------------- */

           /* Shape rect = new Rectangle(5,5);
            Shape tri = new Triangle(5,5);

            Console.WriteLine("Rect Area: " + rect.area());
            Console.WriteLine("Tri Area: " + tri.area());

            Rectangle  combRect  = new Rectangle(5,5) + new Rectangle(5,5);
            Console.WriteLine("combRect Area: "+ combRect.area()); */

            /*--------Part 3)Generic Type-------------- */
            /*KeyValue<string, string> superman = new KeyValue<string, string>("","");
            
            superman.key = "Superman";
            superman.value ="Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0,"");

            samsungTV.key = 4;
            samsungTV.value = " a 50 in TV";

            superman.showData();
            samsungTV.showData(); */

            /*--------Part 4)Enumerators-------------- */
            /*Temperature micTemp = Temperature.Low;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;

                default:
                    Console.WriteLine("Not Applicable");
                    break;
            } */

            /*--------Part 5)Struct-------------- */
            /*Customer bob = new Customer();
            
            bob.createCust("Bob", 15.50, 12345);

            bob.showCust(); */

            /*--------6)Delegate-------------- */
        //pass methods as args to other methods
        //anonmyous method/class has no name
       /* GetSum sum = delegate(double num1, double num2){            //Anonymous method
            return num1 + num2;
        };

        Console.WriteLine("Addition in Anonymous Method: "+sum(5,10)); */

        /*--------Part 6)Delegate-------------- */
        //Lambda is like an anonymous method or an express tree
        //part 1
        /*Func<int, int, int> getSum = (x,y)=> x+y;

        Console.WriteLine("Addition in Delegate: " + getSum.Invoke(5,10));

        //part 2
        List<int> numList = new List<int>{5, 10, 15, 20, 25};
        List<int> oddNums = numList.Where(n => n%2 ==1).ToList(); //store them in a list
                    
        Console.WriteLine("mod with list in Delegate: ");

        foreach(int num in oddNums ){
            Console.WriteLine(num + ",");
        }*/

        /*--------Part 7)File I/O-------------- */
        string [] custs = new string [] {"Nazzy", "Ebou", "Axel"};
            using (StreamWriter sw = new StreamWriter("custs.txt")){
                foreach (string cust in custs){
                    sw.WriteLine(cust); //writing int the text file
                }
            }
        string custName="";
            using (StreamReader sr = new StreamReader("custs.txt")){
                while ( (custName = sr.ReadLine()) != null ){
                    Console.WriteLine(custName);
                }
            }
    
        }
    }

/*-----------------------------------1)b)Animal(overload)------------------------------------ */

    //Adding a class with an extra variable in constructor
    class Cat: Animal{
        public string favFood { get; set; }

        public Cat(): base(){
            this.favFood = favFood;
        }

        public Cat(double height, double weight, string name, string sound, string favFood): 
                    base(height, weight, name, sound){//adding the base will initialize with everything
            this.favFood = favFood;
        }
        //override we type new
        new public  string toString(){
            return String.Format("{0} is {1} inches tall, weight {2} lbs and likes to say {3} eats {4}", 
                                    name, height, weight,sound, favFood);
        }
    }

/*-----------------------------------2)Shapes(Abstract,Interface (overrides))------------------------------------ */
    //you can't instantiate or create an object of an abstract class
    abstract class Shape{
        public abstract double area();

        public void sayHi(){
            Console.WriteLine("Hello");
        }
    }

    public interface ShapeItem{
        double area();
    }

    class Rectangle: Shape{
            private double length;
            private double width;

            public Rectangle( double num1, double num2 ){
                length = num1;
                width = num2;
            }
            public override double area(){
            //public  double area(){
                //throw new NotImplementedException();
                return length * width;
            }
            public static Rectangle operator+ (Rectangle rect1, Rectangle rect2){
                double rectLength = rect1.length + rect2.length;
                double rectWidth = rect1.width + rect2.width;

                return new Rectangle(rectLength, rectWidth);
            }
    }

    class Triangle: Shape{
            private double theBase;
            private double height;

            public Triangle(double num1, double num2){
                theBase = num1;
                height = num2;
            }
            public override double area(){
                //throw new NotImplementedException();
                return .5 * (theBase * height);
            }
    }

/*-----------------------------------3)GenericTypes------------------------------------ */
    //You use the generic types when you're not sure of the datatype to use 
    class KeyValue<TKey,TValue>
    {
        public TKey key { get; set;}
        public TValue value { get; set;}

        public KeyValue(TKey k, TValue v){
            key = k;
            value = v;
        }
        public void showData(){
            Console.WriteLine("{0} is {1} " , this.key, this.value);
        }
    }

/*-----------------------------------4)Enumerators------------------------------------ */
    //unique symbolic names and associated values
    public enum Temperature{
        Freeze,
        Low,
        warm,
        Boil
    }   

/*-----------------------------------5)Struct------------------------------------ */
    //Holds data from many different data types
    struct Customer{
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i){
            name =n;
            balance=b;
            id=i; 
        }

        public void showCust(){
            Console.WriteLine("Name: "+name);
            Console.WriteLine("balance: "+balance);
            Console.WriteLine("id: "+id);
        }
    }
}
