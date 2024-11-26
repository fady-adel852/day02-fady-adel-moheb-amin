//Question 1 Start:

/* multi-line comments:
   The following code demonstrates a simple addition operation:
   1. It initializes two integers, x and y, with values 10 and 20, respectively.
   2. It calculates their sum and stores it in the variable 'sum'.
   3. Finally, it prints the value of sum (which will be 30) to the console.
*/


//single-line Comment:

// Initialize variable x with a value of 10
int x = 10;

// Initialize variable y with a value of 20
int y = 20;

// Calculate the sum of x and y, and store the result in the variable 'sum'
int sum = x + y;

// Output the value of sum to the console
Console.WriteLine(sum);


//Question 1 End:




//Question 2 Start:

int x = 10; // Assigning an integer value directly
int y = 5;  // Assuming 'y' is also declared and initialized
Console.WriteLine(x + y); // Correct method name with proper casing




//Explanation of Runtime vs. Logical Errors
//Runtime Errors
int[] arr = new int[5];
Console.WriteLine(arr[10]); // This will throw an "Index Out Of Range Exception" at runtime
//The code tries to access an index of the array that is outside the bounds of the array



//Logical Errors
int x = 10;
int y = 5;
Console.WriteLine(x - y); // Expected result is 15, but the result is 5.
//the code incorrectly subtracts y from x instead of adding them

//Question 2 End:


//Question 3 Start:

using System;

public class Person
{
    // Full name of the person (PascalCase)
    public string FullName { get; set; }

    // Age of the person (PascalCase)
    public int Age { get; set; }

    // Monthly salary (PascalCase)
    public decimal MonthlySalary { get; set; }

    // Whether the person is a student (PascalCase)
    public bool IsStudent { get; set; }

    // Constructor to initialize the properties
    public Person(string fullName, int age, decimal monthlySalary, bool isStudent)
    {
        FullName = fullName;
        Age = age;
        MonthlySalary = monthlySalary;
        IsStudent = isStudent;
    }

    // Method to display the person's details
    public void DisplayDetails()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Monthly Salary: {MonthlySalary:C}");
        Console.WriteLine($"Is a Student: {IsStudent}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Person class
        Person person = new Person("Fady Adel Moheb", 21, 3600.00m, true);

        // Display the person's details
        person.DisplayDetails();
    }
}


//Following naming conventions like PascalCase in C# is important
//because it ensures consistency, readability, and maintainability of code.
//It makes the code easier to understand, helps developers quickly identify variables,
//methods, and classes, and aligns with industry standards for better collaboration.


//Question 3 End:





//Question 4 Start:

using System;

public class Program
{
    public class Person
    {
        public string Name { get; set; }
    }

    public static void Main()
    {
        // Create an instance of Person
        Person person1 = new Person();
        person1.Name = "Fady";

        // Create another reference to the same object
        Person person2 = person1;

        // Display the original values
        Console.WriteLine($"person1 Name: {person1.Name}"); // Fady
        Console.WriteLine($"person2 Name: {person2.Name}"); // Fady

        // Change the Name property through person2
        person2.Name = "Adel";

        // Display the values again
        Console.WriteLine($"person1 Name: {person1.Name}"); // Adel
        Console.WriteLine($"person2 Name: {person2.Name}"); // Adel
    }
}


//Difference Between Value Types and Reference Types in Terms of Memory Allocation
/*1-Value Types:

Stored directly in the memory location (stack).
When assigned to another variable, a copy of the value is made.
Examples: int, float, char, struct
Each variable holds its own copy of the data.*/

//Example:
int a = 10;
int b = a; // b gets a copy of a's value
a = 20;
Console.WriteLine(b); // Output: 10 (b is unaffected by a's change)



/*2:Reference Types:

Stored in the heap with a reference to their location in memory (stack holds the reference).
When assigned to another variable, both variables point to the same object in memory.
Examples: class, string, array, delegate
Changing the value through one reference affects all references to the same object.*/


//Example:

using System;

public class Person
{
    public string Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of Person
        Person p1 = new Person { Name = "Fady" };

        // Assign p1 to p2 - p2 now refers to the same object as p1
        Person p2 = p1;

        // Change the Name property via p1
        p1.Name = "Adel";

        // Since p1 and p2 refer to the same object, the change is reflected in p2 as well
        Console.WriteLine(p2.Name);  // Output: Adel
    }
}

//Question 4 End:


//Question 5 Start:

using System;

class Program
{
    static void Main()
    {
        // Part 1: Calculate
        // sum, difference, product, division result,
        // and remainder for x = 15 and y = 4
        int x = 15;
        int y = 4;

        int sum = x + y;
        int difference = x - y;
        int product = x * y;
        double divisionResult = (double)x / y;  // Casting to double to get decimal result
        int remainder = x % y;

        // Display the results
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Division Result: " + divisionResult);
        Console.WriteLine("Remainder: " + remainder);

        // Part 2: Modulus operation with a = 2 and b = 7
        int a = 2;
        int b = 7;
        Console.WriteLine("a % b: " + (a % b));  // Modulus operation
    }
}


/*Explain why: 
int a = 2, b = 7;
Console.WriteLine(a % b);
*/

/*I'm dividing a = 2 by b = 7.
When I divide 2 by 7, 7 doesn't fit into 2 at all (because 2 is smaller than 7).
The remainder of this division is just 2, because nothing can be subtracted from 2.
So, the answer to 2 % 7 is simply 2, because that's what’s left over after dividing.

Division: 2 ÷ 7 = 0 (you can't fit 7 into 2 even once)
Remainder: Since 2 is smaller than 7, the remainder is 2.
*/


//Question 5 End:






//Question 6 Start:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is greater than 10 and even
        if (number > 10 && number % 2 == 0)
        {
            Console.WriteLine("The number is greater than 10 and even.");
        }
        else
        {
            Console.WriteLine("The number does not satisfy both conditions.");
        }
    }
}



/*How the && (Logical AND) and & (Bitwise AND) Operators Differ:
In C#, the && (logical AND) and & (bitwise AND) operators are used in different contexts,
and their behavior differs in the following ways:*/

//&& (Logical AND Operator):

//Purpose: Used for logical operations between two boolean expressions.

/*Behavior: It evaluates the second condition only if necessary.
If the first condition is false, it will not evaluate the 
second condition (this is called "short-circuiting").*/


//Example:

/*bool condition1 = (x > 10);
bool condition2 = (x % 2 == 0);
if (condition1 && condition2)
{
    // Do something if both conditions are true
}*/

/*Short-circuiting: If x > 10 is false, the second condition (x % 2 == 0) won't even be checked,
making the operation more efficient.*/


//& (Bitwise AND Operator):

/*Purpose: Primarily used for bitwise operations between integer values. 
It compares individual bits of two integers.*/

/*Behavior: Unlike &&, the & operator always evaluates both sides of the expression,
even if the first condition is false.*/

//Example:

/*bool condition1 = (x > 10);
bool condition2 = (x % 2 == 0);
if (condition1 & condition2)
{
    // Do something if both conditions are true
}*/

/*No short-circuiting: Even if condition1 is false,
condition2 will still be evaluated. This can be inefficient when 
condition2 involves expensive or unnecessary calculations.*/

//Bitwise AND on Integer Values:

/*When applied to integer values, the & operator performs a bitwise AND
on the binary representations of the operands.*/

//Example:

//int a = 5;  // 0101 in binary
//int b = 3;  // 0011 in binary
//int result = a & b;  // result = 1, which is 0001 in binary

//Question 6 End:



//Question 7 Start:

using System;

class Program
{
    static void Main()
    {
        // Prompt the user for a double input
        Console.Write("Please enter a double value: ");
        double userInput = Convert.ToDouble(Console.ReadLine());

        // Implicit casting (not applicable in this case, as double to int requires explicit casting)
        // Instead, we will demonstrate explicit casting
        int explicitCast = (int)userInput; // Explicit casting from double to int

        // Note: Implicit casting would work from int to double, but not the other way around
        // For demonstration purposes, we can show an example of implicit casting:
        int intValue = 10;
        double implicitCast = intValue; // Implicit casting from int to double

        // Print the results
        Console.WriteLine($"Original double value: {userInput}");
        Console.WriteLine($"Explicitly casted to int: {explicitCast}");
        Console.WriteLine($"Implicitly casted int to double: {implicitCast}");
    }
}

/*Explicit Casting is required when converting a double to an int 
because of the potential loss of data. A double can represent both whole numbers
and fractional values (e.g., 3.14), while an int can only represent whole numbers (e.g., 3).*/

/*Why is Explicit Casting Required?
Data Loss: When converting from double to int, any fractional part of the double value
will be discarded. For example, converting 3.99 to int will result in 3.
This loss of information is significant,
and C# requires you to explicitly acknowledge this by using a cast.*/

//Question 7 End:



//Question 8 Start:

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();

        try
        {
            // Convert the string input to an integer
            int age = int.Parse(input);

            // Check if the age is valid
            if (age > 0)
            {
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                Console.WriteLine("Age must be greater than 0.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number for your age.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number entered is too large or too small for an age.");
        }
        catch (Exception ex)
        {
            // Catch any other exceptions that might occur
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

//Question 8 End: