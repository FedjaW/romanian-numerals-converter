﻿
Console.WriteLine("Please enter an integer between 1 and 3999");
var integer = Int32.Parse(Console.ReadLine());
var romanNumber = Converter.ConvertRecursive(integer);
Console.WriteLine(integer + " = " + romanNumber);