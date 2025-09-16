/* Odd or Even program
    Created by Finn Gilbert
    Created on September 16, 2025
    Takes a numbers and then tells you if it is odd or even
*/
// Ask the user for a number
Console.Write("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
// Uses mod to find out whether it is odd or even
int y = x % 2;
// Uses IF to find out. If it = 0 then its even, else it is odd.
if (y == 0)
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}