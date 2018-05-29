using System;
using System.Text;
using  System.Collections.Generic;

//namespace ConsoleApplication
//{
    class Program{
        public static void Main(string [] args){
            bool canVote = true;
            char grade= 'A';
            //Data types
            //int,long, decimal, float, double, varls
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, "+name);
            Console.WriteLine("Your GPA is");

            var anything = "serge";
            Console.WriteLine("anything is a{0}",anything.GetTypeCode());//getting the type of the var

            //Math Library
            //Abs(),Ceiling(), Floor(), Max(), Min(), Pow(), Round(), Sqrt()
            int angle =90;
            Console.WriteLine("cos("+angle+")"+Math.Cos(angle));//getting the type of the var

            Random rand = new Random();
            Console.WriteLine("Number between 1 and 10 is "+(rand.Next(1,11)));

            double myGpa =3.0;
            bool Gpa = myGpa >=3.0 ? true:!true; 
            Console.WriteLine(Gpa);
            //if , case statement and for loops  same as in c

            //Do while loop 
            string guess;
            do{
                Console.WriteLine("Guess Number");
                guess = Console.ReadLine();
            }while(!guess.Equals("0"));

            //Looping through a string getting each char 
            string randStr = "I am at the airport";
            foreach(char c in randStr){
                Console.WriteLine(c);
            }

            //Strings in C#
            string myString = "I'm still at the airport";
            string myString2 = "I'm baording now";
            Console.WriteLine("Is empty? " + String.IsNullOrEmpty(myString));
            Console.WriteLine("has white space? " + String.IsNullOrWhiteSpace(myString));
            Console.WriteLine("String length " + myString.Length);
            Console.WriteLine("Index of airport is " + myString.IndexOf("airport"));
            Console.WriteLine("Substring between 5 and 16 is" + myString.Substring(5,16));
            Console.WriteLine("is equal " + myString.Equals(myString2));
            Console.WriteLine("Starts with  " + myString.StartsWith("I'm"));
            Console.WriteLine("End with  " + myString.EndsWith("airport"));

            string NewString = myString.Trim(); //TrimStart, TrimEnd
            Console.WriteLine("Trimmed String: " + NewString);
            NewString = NewString.Replace("still","not");
            Console.WriteLine(NewString);
            NewString = NewString.Remove(0,2);
            Console.WriteLine(NewString);



            //String array
            String[] names = new string[3]{"Serge", "Jabo", "Byusa"};
            Console.WriteLine("Name List: " + String.Join(",",names));

            string frmtStr= String.Format("{0:c}{1:00.00}{2:#.00}{3:0,0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(frmtStr);



            //each time you create a string you create another inside
            StringBuilder sb =  new StringBuilder();
            sb.Append("This is a the first sentence");
            sb.AppendFormat("My Name is {0} and I live in {1}", "Serge","Montreal");
            //sb.Clear();
            sb.Replace("a","@");
            sb.Remove(5,7);//remove from 5 to 7
            Console.WriteLine(sb.ToString());
    

            //Arrays
            int [] MyArray1  = new int[5];
            int [] MyArray = {10,40,56,23};
            //format is wonderful
            for(int i=0; i<MyArray.Length; i++ ){
                Console.WriteLine("{0}:{1}", i, MyArray[i]);
            }
            foreach(int r in MyArray){
                Console.WriteLine(r);
            }
                Console.WriteLine("The IndexOf is: "+ Array.IndexOf(MyArray,56));
            
            string[] names1 = {"Ebou","Nazzy","Axel"};
            string  mameStr = string.Join(",", names1);

            //multidimension array 
            int [,] multArray = new int [2,3];//or
            int [,] multArray2 = {{0,1},{2,3},{4,5}};

            foreach(int num in multArray2){
                Console.Write(" , "+num);
            }
            for (int x = 0 ; x<multArray2.GetLength(0); x++){ //multArrays2[0].length in java
                Console.WriteLine(" ");
                for (int y = 0 ; y<multArray2.GetLength(1); y++){
                    Console.Write("({0},{1}): {2}", x, y, multArray2[x,y]);
                }
            }
            Console.WriteLine();

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(15);
            numList.Add(20);
            numList.Add(5);
            
            int[] randArray = {1,2,3,4,5};

            numList.AddRange(randArray);
            //numList.Clear();

            //creating a list in array (2 ways)
            List<int> numList2 = new List<int>(randArray); 
            List<int> numList3 = new List<int>(new int[] {1,2,3,4}); 

            numList.Insert(1,10);//insert 10 at position 1
            numList.Remove(5);
            numList.RemoveAt(2);

            for(int i=0; i<numList.Count; i++){//numList.Count
                Console.WriteLine("{0}:{1}", i, numList[i]);
            }

            Console.WriteLine("4 is in index? "+ numList3.IndexOf(4));
            Console.WriteLine("5 in List? " + numList.Contains(5));

            List<string> strList = new List<string>(new string[]{"Ebou","Nazzy"});

            //error
            /*Console.WriteLine("EBou in  list " + strList.Contains("ebou",
                StringComparer.OrdinalIgnoreCase));* */

            strList.Sort();

            //Exception Handling
            try{
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1} ",  num, (10/num));
            }catch(DivideByZeroException ex){
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //throw ex;
                //throw new InvalidOperationException("Operationn Failed:",ex);
            }
            catch(Exception ex){
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }

    }
//}

