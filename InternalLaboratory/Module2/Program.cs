// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Module2.ArrayTools.FindMaxIntElement(new int[] { 1, 2, 3}));

Console.WriteLine(Module2.ArrayTools.FindSymmetryCenter(new[] { 1.0, 2.0, 1.0, 3.1 }));

Console.WriteLine(Module2.StringTools.ConcatNonrepeating("sssssssssssss", "ssssssssssssssssssssssd"));

Console.WriteLine(Module2.NumberTools.FindNextBiggerNumber(456));

foreach (int i in Module2.ArrayTools.FilterDigit(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7))
{    
    Console.Write(i.ToString() + ' ');
}
Console.WriteLine();
string executionTime;

Console.WriteLine(Module2.NumberTools.FindNextBiggerNumber(555, out executionTime));
Console.WriteLine(executionTime);

Console.WriteLine(Module2.NumberTools.InsertNumber(8, 15, 3, 8));

Console.WriteLine(Module2.NumberTools.InsertNumber(15, 15, 0, 0));
Console.WriteLine(Module2.NumberTools.InsertNumber(8, 15, 0, 0));