using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
Console.WriteLine("Welcome to the calculator.");

float a = 0f;
float b = 0f;

while(true){

Console.Write("What do you want to do ->\n\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit\n\n--> ");  
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.Clear();
          
        if (c == 1 || c == 2 || c == 3 || c == 4){  
              
            Console.Write("Enter your first number --> ");  
            a = Convert.ToSingle(Console.ReadLine());  
              
            Console.Write("Enter your second number --> ");  
            b = Convert.ToSingle(Console.ReadLine());  
              
        }  
          
        else {  
              
            Console.WriteLine("Thanks for using");  
            break;  
              
        }  
          
        if (c == 1){  
              
            Console.WriteLine($"The sum of your numbers is {a + b}");  
              
        }  
          
        else if (c == 2){  
              
            Console.WriteLine($"The subtraction of your numbers is {a - b}");  
              
        }  
          
        else if (c == 3){  
              
            Console.WriteLine($"The multiplication of your numbers is {a * b}");  
              
        }  
          
        else {  
              
            Console.WriteLine($"The division of your number is {a / b}");  
              
        }  
          
        Console.Clear();      
              
              
        }  
      
    }

}
