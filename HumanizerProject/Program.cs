// See https://aka.ms/new-console-template for more information

using Humanizer;
using System.Globalization;


int number = 1234;

// Convert number to words in Arabic
string wordsInArabic = number.ToWords(new CultureInfo("ar"));
string wordsInEnglish = number.ToWords(new CultureInfo("en"));

// Output the result
Console.WriteLine(wordsInArabic);
Console.WriteLine(wordsInEnglish);
