// See https://aka.ms/new-console-template for more information

using Utility;

Console.WriteLine("Reverse string");


var value = "Microsoft Learn";
string reversedValue = Utilities.Reverse(value);
Console.WriteLine($"Secret message: {reversedValue}");

//static string Reverse(string message)
//{
//    char[] letters = message.ToCharArray();
//    Array.Reverse(letters);
//    return new string(letters);
