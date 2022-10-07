using System;
using System.Collections.Generic;

Stack<char> cstack = new Stack<char>();

//collection of variable
Console.Write("Enter the string: ");
var input = Console.ReadLine();

/*assuming case senstivity is not to be considered */
var inputToUpper = input.ToUpper();

//puts each char in word as a position in the stack
foreach (char c in inputToUpper)
{
    cstack.Push(c);
}

bool isPalindrome = true;
var noOfItems = cstack.Count;

//testing if input is palindrome or not
for (int i = 0; i < noOfItems; i++)
{
    if (inputToUpper[i] != cstack.Pop())
    {
        isPalindrome = false; break;
    }
}

//writing on console whether or not the word is a palindrome
if (isPalindrome)
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Non Palindrome");
}
Console.ReadLine();

