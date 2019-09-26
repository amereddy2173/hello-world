using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1

{
    public class Program
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;
            while (validMenuSelect == false)
            {
                Console.WriteLine("1=Get Rectangle Length");
                Console.WriteLine("2=Change Rectangle Length");
                Console.WriteLine("3=Get Rectangle Width");
                Console.WriteLine("4=Change Rectangle Width");
                Console.WriteLine("5=Get Rectangle Perimeter");
                Console.WriteLine("6==Get Rectangle Area");
                Console.WriteLine("7=Exit\n");

                Console.WriteLine("Please select an option by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option please try again:\n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }
        public static int ValidateInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide}: of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("its not a valid input,please try again.\n");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number cannot be less than 0,please try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is : {number}.\n");
                }


            }
            Console.WriteLine();
            return number;
        }
        static void Main(string[] args)

        {
            Rectclass r = new Rectclass();
            bool ValidRectangleSelect = false;
            string RectangleSelection;



            while (ValidRectangleSelect == false)
            {
                Console.WriteLine("1=default rectangle of (1*1)\n");
                Console.WriteLine("2=create your own rectangle\n");
                Console.WriteLine();
                Console.WriteLine("Choose a menu to begin:");
                RectangleSelection = Console.ReadLine();


                if (RectangleSelection != "1" && RectangleSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(RectangleSelection) == 1)
                {
                    ValidRectangleSelect = true;
                    int Length = 1;
                    int Width = 1;
                    Console.WriteLine($"your default rectangle is {Length} * {Width}\n");

                }
                else if (int.Parse(RectangleSelection) == 2)
                {
                    ValidRectangleSelect = true;
                    int Length = 1;
                    int Width = 1;
                    Length = ValidateInput("Length");
                    Width = ValidateInput("Width");

                    Console.WriteLine($"your custom numbers are {Length} and {Width}\n");
                    Rectclass CustomRectangle = new Rectclass(Length, Width);

                }
            }

            int Input = ValidateMenuSelection();

            while (Input != 7)
            {
                int result;
                switch (Input)
                {
                    case 1:
                        Console.WriteLine($"Length is:{r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateInput("Length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateInput("Width");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The result of rectangle  is {r.GetLength() * 2} + {r.GetWidth() * 2} is:{r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The result of rectangle is{r.GetLength()} + {r.GetWidth()}is: ({r.GetArea()} \n");
                        break;
                    default:
                        break;
                }

                Input = ValidateMenuSelection();

            }

        }

    }

}





