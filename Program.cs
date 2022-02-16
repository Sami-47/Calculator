// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

//Choice for users
enum Operations {
                A, 
                S,
                M,
                D,
                P
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
                case Operations.A:
                    result = addition(this.Input1, this.Input2);
                        break;
                case Operations.S:
                        result = subtraction(this.Input1, this.Input2);
                          break;
                case Operations.M:
                        result = multiplication(this.Input1, this.Input2);
                          break;
                case Operations.D:
                        result = division(this.Input1, this.Input2);
                          break;
                case Operations.P:
                        result = power(this.Input1, this.Input2);
                          break;
               default: 
                 Console.WriteLine("Operation not recognized");
                    break;
             }
             Console.WriteLine("Result is "+result);
        }
             
        public float addition(float num1, float num2){
            return num1 + num2;

        }
        public float subtraction(float num1, float num2){
            return num1 - num2;

        }
        public float multiplication(float num1, float num2){
            return num1 * num2;

        }
        public float division(float num1, float num2){
            float value = -1;
            string ErrorString = "Cannot divide by Zero";
               try {
                   if(num2 > 0) return num1 / num2;
                }catch (DivideByZeroException e) {
                ErrorString = e.Message;
                Console.WriteLine (ErrorString);
            }
            return value; 
        }
        public static float power(float num1, float num2){
            return (float)Math.Pow(num1, num2);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            
            float input1, input2;
            string choice;
            Console.WriteLine(".........................");
            Console.WriteLine("Enter first number");
            input1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            input2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            Console.WriteLine("Choose A => Addition\nS => Subtraction\nM => Multiplication\nD => Division\nP => Power");
            choice = Console.ReadLine();

            var isValid = validateInput(input1, input2, choice);
            //validate if user has inputed values
            if(isValid){
                CalculatorOperation calc =  new CalculatorOperation(input1, input2, choice);
                calc.getResult();
            } else{
                Console.WriteLine("Please input proper values");
            }    
        }

        public static bool validateInput(float? input1, float? input2, string? choice){
    
            if(input1 != null && input2 != null && choice !=null){
                return true;
            } else{
                return false;
            }
        }    
    }     
}

