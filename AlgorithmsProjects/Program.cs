//// See https://aka.ms/new-console-template for more information
//using System.Reflection.Metadata.Ecma335;

//Console.WriteLine("Hello, World!");

////var index = BinarySearch(Enumerable.Range(0, 100), 15);

////var index = BinarySearch(new int[] { 1, 3, 5, 7, 9 }, 3);

//var ttt = Enumerable.Range(0, 100).Select(s => s * 2 + 1).ToList().BinarySearch(65);

//var index = BinarySearch(Enumerable.Range(0, 100000050).Select(s => s * 2 + 1), 0);
////var index = BinarySearch(Enumerable.Range(0, 5).Select(s => s * 2 + 1), 3);



//Console.WriteLine($" Index ===> {index}");
//Console.ReadLine();

//int? BinarySearch(IEnumerable<int> list, int item)
//{
//    var low = 0;
//    var high = list.Count() - 1;
//    var step = 0;

//    while (low <= high)
//    {
//        var mid = (low + high) / 2;
//        var guess = list.ElementAt(mid);

//        if (guess == item)
//            return mid;

//        if (guess > item)
//            high = mid - 1;
//        else
//            low = mid + 1;

//        step++;
//    }

//    Console.WriteLine($" --- Result: => {step} step(s)");

//    return null;
//}

// ============================

using AlgorithmsProjects.Core;
using System.Drawing;
using System;

//var context = new ContextStrategy(new BinarySearch());
//var context = new ContextStrategy(new RecursiveBinarySearch());

//var ind = context.Execute(Enumerable.Range(0, 2000000000), 60101);
//var ind = context.Execute(Enumerable.Range(0, 10005000).Select(s => s * 2 + 1), 60101);
//var ind = context.Execute(new int[] { 1, 3, 5, 7, 9 }, 7);



var generator = new Random();
var length = 16;
var count = 100;
var strList = new string[count];
const string src = "abcdefghijklmnopqrstuvwxyz0123456789";

for (var j = 0; j < count; j++)
{
    //for (var i = 0; i < length; i++)
    //{
    //    //strList[j] += ((char)(generator.Next(1, 26) + 64)).ToString().ToLower();

    //    Console.WriteLine();
    //}

    //for (int i = 0; i < size; i++)
    {
        Console.WriteLine(Convert.ToChar(Convert.ToInt32(j + 65)));
        //builder.Append(ch);
    }
}


var context = new ContextStringTypeStrategy(new BinaryStringTypeSearch());
var ind = context.Execute(strList, "dvhwtjxlqcgwjuvr");




//GIT test
//GIT test
//GIT test
//GIT test

Console.WriteLine($"Index = {ind}");

// ==============================
