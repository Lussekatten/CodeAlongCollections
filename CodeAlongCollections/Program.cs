////----------------------------- Collections as arrays ------------------------
////Declare an array of integers
//int[] ints = new int[5];

//ints[0] = 6;
//ints[1] = 7;
//ints[2] = 8;
//ints[3] = 9;
//ints[4] = 10;

//Console.WriteLine("Array contents");
//for (int i = 0; i < ints.Length; i++)
//{
//    Console.WriteLine($"Element {i+1}: {ints[i]}");
//}

////foreach (int item in ints)
////{
////    Console.WriteLine($"{item}, ");
////}
//Console.WriteLine($"The sum of all elements: {ints.Sum()}");
//Console.WriteLine($"The smallest element: {ints.Min()}");

//int[,] someNumbers = new int[2, 4];

//int newValues = 1;
//for (int i = 0; i < someNumbers.GetLength(0); i++)
//{
//    for (int j = 0; j < someNumbers.GetLength(1); j++)
//    {
//        someNumbers[i, j] = newValues;
//        newValues++;
//    }
//}

////Contents of two dimensional array
//for (int i = 0; i < someNumbers.GetLength(0); i++)
//{
//    for (int j = 0; j < someNumbers.GetLength(1); j++)
//    {
//        Console.Write($"{ someNumbers[i, j]} ");        
//    }
//    Console.WriteLine();
//}


//----------------- Collections as lists -------------------------
//List<int> myIntList = new List<int> { 10, 20, 30, 40 };
//myIntList.Add(100);
//myIntList.Remove(20);
//myIntList.RemoveAt(0);
//if (myIntList.Contains(40))
//{
//    Console.WriteLine("The list contains this element");
//}
//Console.WriteLine("List contents");
//foreach (var item in myIntList)
//{
//    Console.WriteLine($"Element {myIntList.IndexOf(item)+1}= {item}");
//}

//----------------- Collections as dictionaries ------------------
Dictionary<string, string> myDictionary = new Dictionary<string, string>();
myDictionary["Id"]  = "Field that uniquely indentifies an element";
myDictionary["Name"] = "The name your parents gave you";

Console.WriteLine("Dictionary contents");
foreach (KeyValuePair<string,string> item in myDictionary)
{
    Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
}