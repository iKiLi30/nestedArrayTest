using System;
using System.Security.AccessControl;
using System.Linq;
using System.Collections;

namespace nestedArrayTest
{
    internal class Program
    {   


        static void Main(string[] args)
        {           

         Program program = new Program();
            //program.ArrayOfArray();
            //program.ExampleOne();
            //program.ThirdCycleIteration();
            //program.DrawRectangle();
            //program.StartInArray();
            //program.InitioalizeArrayByEnum();
            //program.ArrayHomeWork();
            //program.PutOfDoubleArray();


        }
            //void ArrayOfArray()
            //{
            //    Random random = new Random();
            //    int[][] myArray = new int[4][];
            //    myArray[0] = new int[random.Next(3, 5)];
            //    myArray[1] = new int[random.Next(10, 16)];
            //    myArray[2] = new int[random.Next(8, 12)];
            //    myArray[3] = new int[random.Next(1, 3)];

            //    for (int i = 0; i < myArray.Length; i++)
            //    {
            //        for (int j = 0; j < myArray[i].Length; j++)
            //        {
            //            myArray[i][j] = random.Next(50);
            //            Console.Write(myArray[i][j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    for (int j = 0; j < myArray[i].Length; j++)
            //    {
            //    }
            //    Console.WriteLine();
            //}
        }

        //void OutOfDoubleArray()
        //{
        //    int[,] litArray = new int[3, 5] { {1,5,3,7,8 }, {5,8,5,3,4 }, {1,2,3,4,5 }};


        //    for (int i = 0; i < litArray.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < litArray.GetLength(1); j++)
        //        {
        //            Console.Write(litArray[i,j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //void InitioalizeArrayByEnum()
        //{
        //    int[] myArray = Enumerable.Range(5,10).ToArray();
        //    foreach (int i in myArray)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //void StartInArray()
        //{
        //    int[] myArray;
        //    myArray = new int[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        myArray[i] = random.Next(0, 10);
        //    }
        //    int firstInArray = myArray[0];
        //    int secondInArray = myArray[2];
        //    Console.WriteLine($"First in array is {firstInArray},second in array is {secondInArray}");
        //    Console.WriteLine("Sum of second and thied element is " + (myArray[2] + myArray[1]));

        //}
        //void ThirdCycleIteration()
        //{

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.WriteLine("First cycle iteration's: " + i);
        //        for (int j = 0; j < 5; j++)
        //        {
        //            Console.WriteLine("\tSecond cycle iteration's " + j);

        //            for (int k = 0; k < 2; k++)
        //            {
        //                Console.WriteLine("\t\tThird cycle iteration's " + k);
        //            }
        //        }
        //        Console.ReadLine();
        //    };
        //}
        //void DrawRectangle()
        //{
        //    Console.WriteLine("Input hight rectangle:");
        //    int height = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Input width rectangle:");
        //    int width = int.Parse(Console.ReadLine());


        //    for (int i = 0; i < height; i++)
        //    {

        //        for (int j = 0; j < width; j++)
        //        {
        //            Console.Write("#");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}
        //void ExampleOne()
        //{
        //    static int[,] GetRandomArray(int rows, int columns)
        //    {
        //        Random random = new Random();
        //        var result = new int[rows, columns];

        //        for (int i = 0; i <rows; i++)
        //        {
        //            for(int j = 0;j < columns; j++)
        //            {
        //                result[i,j] = random.Next(100);
        //            }
        //        }
        //        return result;

        //    }
        //    int row = 5; int col = 5;
        //    var myArray = GetRandomArray(row, col);

        //    for (int i = 0;i < row; i++)
        //    {
        //        for (int j = 0; j < col; j++)
        //        {
        //            Console.Write($"{myArray[i, j]}\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //void ArrayHomeWork()
        //{
        //    int[] HomeArray = new int[5];
        //    for (int i = 0; i < HomeArray.Length; i++)
        //    {
        //        HomeArray[i] = Convert.ToInt32(Console.ReadLine());

        //    }

        //    for (int i = 0; i<HomeArray.Length; i++)
        //    {
        //        Console.Write(HomeArray[i]+" ");
        //    }

        //    for (int i = HomeArray.Length-1; i >=  0 ; i--)
        //    {
        //        Console.Write(HomeArray[i] + " ");
        //    }

        //    int maxHomeArray = HomeArray.Max();
        //    Console.WriteLine("\n" + maxHomeArray);

        //    int sum = 0;

        //    foreach (int i in HomeArray)
        //    {
        //        if(i % 2 != 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    Console.WriteLine(sum); 
        //}

    }

}
