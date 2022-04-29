// See https://aka.ms/new-console-template for more information
using StringCompression;

Solution sol = new Solution();

string test1 = "aabcccccaaa";
Console.WriteLine($"Input: {test1}\nOuput: {sol.StringOutput(test1)}");

string test2 = "abccccca";
Console.WriteLine($"Input: {test2}\nOuput: {sol.StringOutput(test2)}");

string test3 = "aabcvvvcccza";
Console.WriteLine($"Input: {test3}\nOuput: {sol.StringOutput(test3)}");

string test4 = "a";
Console.WriteLine($"Input: {test4}\nOuput: {sol.StringOutput(test4)}");