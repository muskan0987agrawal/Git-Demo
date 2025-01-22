//import C#.util.Scanner;
/*using System;


public class UserInputExample {
public static void main(String[] args) {
Scanner input = new Scanner(System.in);

System.out.print("Enter your name: ");
String name = input.nextLine();

System.out.print("Enter your age: ");
int age = input.nextInt();

System.out.println("Name: " + name + ", Age: " + age);

input.close(); // Close scanner
}
}*/
using System;

namespace UserInputExampleApp // Optional namespace for better organization
{
    public class UserInputExample
    {
        public static void Main(string[] args)
        {
            // Prompt for name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Prompt for age
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine(); // Read input as a string
            int age;
            if (int.TryParse(ageInput, out age)) // Validate and parse the input
            {
                // Print the result
               Console.WriteLine("Name: " + name + ", Age: " + age);
			   Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid age entered. Please enter a valid number.");
            }
        }
    }
}
