// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Choice for users
enum Operations {
                a, 
                s,
                m,
                d,
                p
           }

namespace Calculator
{
//Calcualtor operations class 
    class CalculatorOperation{
        float Input1;
        float Input2;
        string Choice;
        public CalculatorOperation(float input1, float input2, string choice){
            this.Input1 = input1;
            this.Input2 = input2;
            this.Choice = choice;
        }
        float result = 0;
        public void getResult(){
            switch(Enum.Parse<Operations>(this.Choice)){
                case Operations.a:
                    addition(this.Input1, this.Input2);
                        break;
                case Operations.s:
                    subtraction(this.Input1, this.Input2);
                          break;
                case Operations.m:
                      multiplication(this.Input1, this.Input2);
                          break;
                case Operations.d:
                        division(this.Input1, this.Input2);
                          break;
                case Operations.p:
                        power(this.Input1, this.Input2);
                          break;
               default: 
                 Console.WriteLine("Operation not recognized");
                    break;
             }
        }
             
        public void addition(float num1, float num2){
            Console.WriteLine( $" Result: {num1 + num2}");

        }
        public void subtraction(float num1, float num2){
            Console.WriteLine ($" Result: {num1 - num2}");

        }
        public void multiplication(float num1, float num2){
            Console.WriteLine ($" Result: {num1 * num2}");

        }
        public void division(float num1, float num2){
               try {
                   if(num2 > 0){
                       Console.WriteLine ($" Result: {num1 / num2}");     
                    } 
                }catch
                {
                    Console.Write("Error occurred.");
                }
                finally
                {
                    Console.Write("Re-try with a different number");
                }
            }
        public static void power(float num1, float num2){
            Console.WriteLine ($"Result{(float)Math.Pow(num1, num2)}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            
            float input1, input2;
            string? choice;
            Console.WriteLine(".........................");
            Console.WriteLine("Enter first number");
            input1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            input2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            Console.WriteLine("Choose a => Addition\ns => Subtraction\nm => Multiplication\nd => Division\np => Power");
            choice = Console.ReadLine();
            var isValid = validateInput(input1, input2, choice);
            //validate if user has inputed values
            if(isValid){
                CalculatorOperation calc =  new CalculatorOperation(input1, input2, choice);
                calc.getResult();
            } else{
                Console.WriteLine("Enter proper values");
            }
        }   

        public static bool validateInput(float? input1, float? input2, string? choice){
    
            try{
                if(input1 != null && input2 != null && choice !=null){
                    return true;
                }
            } catch(Exception e){
                Console.WriteLine("Enter Proper values" + e.Message);
                
            }
            return false;
        }    
    }     
}

