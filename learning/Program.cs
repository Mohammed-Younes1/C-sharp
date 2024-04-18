using System;
using static System.Net.Mime.MediaTypeNames;

namespace learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programs.RunGame();
            StudyingTest.StudyingClean();

            //Book book1 = new Book("test title1", "test author1",762);
            //Book book2 = new Book("test title2", "test author2",315);
            //book2.pages = 304;
            //Book book3 = new Book("test title3", "test author3", 826);



            //Console.WriteLine(book1.pages);
            //Console.WriteLine(book2.pages);
            //Console.WriteLine(book3.pages);
            //Console.WriteLine(book3);

            //Student student1 = new Student("Mohammed", "CIS", 3);
            //Student student2 = new Student("Pam", "Art", 3.2);


            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());


            //Movie avengers = new Movie("The Avengers","Joss Whedon","PG-13");
            //Movie Shrek = new Movie("Shrek", "Adam Adamson", "R");

            //Shrek.Rating="d";
            //Console.WriteLine(Shrek.Rating);


            //Song holiday = new Song("Holiday","Green day", 200);
            //Console.WriteLine(Song.SongCount);
            //Song stan = new Song("Stan", "eminem", 300);
            //Console.WriteLine(stan.getSongCount());


            //UsefulTools.SayHi("me");



            Chef chef = new Chef();
            chef.MakeSpcialDish();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpcialDish();


            //string charName;
            //int charAge = 20;
            //charName = "nottest";


            //Console.WriteLine("There once was a man named " + charName);
            //Console.WriteLine("He was "+ charAge +" years old");
            //Console.WriteLine("He really liked the name "+ charName);
            //Console.WriteLine("But didnt like being " +charName);

            //Console.Write("Enter your name ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age ");
            //string age = Console.ReadLine();
            //Console.WriteLine("Your name is " + name +" age is "+ age);


            //int num = 2;
            //int nums = Convert.ToInt32("2");

            //Console.WriteLine("Enter a first num: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter a second num: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(" The sum of both numbers : " + num1 + " + " + num2 + " = " + (num1 + num2));



            //string color, pluralNoun, celebrity;
            //Console.WriteLine("Enter your favorite color: ");
            //color = Console.ReadLine();
            //Console.WriteLine("Enter your favorite pluralNoun: ");
            //pluralNoun = Console.ReadLine();
            //Console.WriteLine("Enter your favorite celebrity: ");
            //celebrity = Console.ReadLine();


            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun+" are blue");
            //Console.WriteLine("I Dislike "+ celebrity);


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //string[] names = new string[3];
            //names[0] = "jim";
            //names[1] = "jims";
            //names[2] = "jimss";

            //Console.WriteLine(numbers[1]);



            //Testman("tests");

            //Console.WriteLine(cube(9));


            //bool isMale = false;
            //bool isHere = true;

            //if (isMale && isHere)
            //{
            //    Console.WriteLine("You are a male and here");
            //}
            //else if(isMale && !isHere){
            //    Console.WriteLine("You are a male and not here");
            //}
            //else if (!isMale && isHere)
            //{
            //    Console.WriteLine("You are not a male and here");
            //}
            //else if (!isMale && !isHere)
            //{
            //    Console.WriteLine("You are not a male and not here");
            //}

            //else
            //{
            //    Console.WriteLine("You are not a male and not here");

            //}

            //CompareNum(20, 120);

            //Console.WriteLine(CompareNums(123,50,190));


            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the Operator: ");
            //string oprator = Console.ReadLine();

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (oprator == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}else if(oprator== "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (oprator == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (oprator == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else
            //{
            //    Console.WriteLine("invalid oprator!");
            //}



            //Console.WriteLine(GetDay(5));


            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //Console.ReadLine();
        }
        //static string GetDay(int dayNum)
        //{
        //    string dayName;

        //    switch (dayNum)
        //    {
        //        case 0:
        //            dayName = "Saturday";
        //            break;
        //        case 1:
        //            dayName = "Sunday";
        //            break;
        //        case 2:
        //            dayName = "Monday";
        //            break;
        //        case 3:
        //            dayName = "Tuesday";
        //            break;
        //        case 4:
        //            dayName = "Wednesday";
        //            break;
        //        case 5:
        //            dayName = "Thursday";
        //            break;
        //        case 6:
        //            dayName = "Friday";
        //            break;
        //        default:
        //            dayName = "invalid day";
        //            break;
        //    }

        //    return dayName;
        //}

        //static void CompareNum(double num1, double num2)
        //{
        //    if (num1 > num2)
        //    {
        //        Console.WriteLine("Number 1: "+ num1 + " is bigger");
        //    }else if (num1 < num2)
        //    {
        //        Console.WriteLine("Number 2: " + num2 + " is bigger");
        //    }else 
        //    {
        //        Console.WriteLine("Number 1: " + num1 + " and Number 2: " +num2+ " are equal");

        //    }
        //}
        //static double CompareNums(double num1, double num2, double num3)
        //{
        //    double result;
        //    if (num1 >= num2 && num1 >= num3)
        //    {
        //        result = num1;
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }
        //    return result;
        //}
        //static void Testman(string name)
        //{
        //    Console.WriteLine("Hello "+ name);
        //}
        //static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}
    }
}
