using System.Collections.Generic;
//Creating HashSet
HashSet<string> fruits=new HashSet<string>();
//Adding Values
bool result = fruits.Add("Apple");
bool result2 = fruits.Add("Orange");
bool result3 = fruits.Add("Apple");
Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine("After Adding elemetns ");
foreach (string fru in fruits)
    Console.WriteLine(fru);
//Removing element
Console.WriteLine("Using Remove Method  ");
fruits.Remove("Apple");
Console.WriteLine("After using remove method ");
foreach (string fru in fruits)
    Console.WriteLine(fru);

fruits.Add("Grape");
fruits.Add("Peach");
Console.WriteLine("Using RemoveWhere Method  ");
foreach (string fru in fruits)
    Console.WriteLine(fru);
Console.WriteLine("After using  RemoveWhere method ");
// Removing all elements contains Peach 
fruits.RemoveWhere(x => x.Equals("Peach"));


foreach (string fru in fruits)
    Console.WriteLine(fru);


// using contains method 
Console.WriteLine("Using Contains  Method  ");
bool resultcont = fruits.Contains("Orange");
Console.WriteLine(resultcont);

// printing count of hashset element

Console.WriteLine(fruits.Count);