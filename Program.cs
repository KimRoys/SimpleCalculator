using System;

namespace SimpleCalculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Shows a menu until the program is exited
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        
        private static bool MainMenu()
        {
            int userCT;
            double userInput1, userInput2;
            Console.Clear();
            Console.WriteLine("Välkommen att använda miniräknarfunktionen:");            
            Console.WriteLine("\nVälj räknesätt: ");
            Console.WriteLine("1 för +) - Addition");
            Console.WriteLine("2 för -) - Subtraktion");
            Console.WriteLine("3 för *) - Multiplikation");
            Console.WriteLine("4 för /) - Division");
            Console.WriteLine("5 för k) - Kvadraten (x^2)");
            Console.WriteLine("6 för r) - Kvadratroten");
            Console.WriteLine("7 för att Avsluta");
            bool menu = int.TryParse(Console.ReadLine(), out userCT);
            if (menu == false)
            {
                Console.WriteLine("Du måste skriva siffran som representerar ditt välda räknesätt!");
                return true;
            }
            if (userCT == 7)
            {
                return false;
            }

            Console.WriteLine("Skriv in ditt första tal och tryck enter:\n");
            userInput1 = GetNumberFromUser();
            Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
            userInput2 = GetNumberFromUser();

            switch (userCT)
            {
                #region 1 Addition
                case 1:
                    {                    
                    var res = Addition(userInput1, userInput2);
                        Console.WriteLine(userInput1 + " + " + userInput2 + " = " + res);
                        Console.ReadLine();
                    }
                    return true;

                #endregion

                #region 2 Subtraktion
                case 2:
                    {
                        var res = Subtraction(userInput1, userInput2);
                        Console.WriteLine(userInput1 + " - " + userInput2 + " = " + res);
                        Console.ReadLine();
                        return true;

                    }

                #endregion

                #region 3 Multiplikation
                case 3:
                    {
                        var res = Multiplication(userInput1, userInput2);
                        Console.WriteLine(userInput1 + " * " + userInput2 + " = " + res);
                        Console.ReadLine();
                        return true;
                    }

                #endregion

                #region 4 Division
                case 4:
                    {
                        if (userInput2 != 0)
                        {
                            var res = Division(userInput1, userInput2);
                            Console.WriteLine(userInput1 + " / " + userInput2 + " = " + res );
                        Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig inmatning. Du kan inte dividera ett tal med 0");
                            Console.ReadLine();
                            return true;
                        }
                        
                        
                        return true;
                    }

                #endregion

                #region 5 Kvadraten (x^2)
                case 5:
                    {
                        var userInput = userInput1;
                        var res1 = Pow2(userInput);
                        Console.WriteLine("Kvadraten av " + userInput1 + " = " + res1);
                        userInput = userInput2;
                        var res2 = Pow2(userInput);
                        Console.WriteLine("Kvadraten av " + userInput2 + " = " + res2);
                        Console.ReadLine();
                        return true;
                    }

                #endregion

                #region 6 Kvadratroten
                case 6:
                    {
                        var userInput = userInput1;
                        var res1 = Sqrroot(userInput);
                        Console.WriteLine("Kvadratroten av " + userInput1 + " = " + res1);
                        userInput = userInput2;
                        var res2 = Sqrroot(userInput);
                        Console.WriteLine("Kvadratroten av " + userInput2 + " = " + res2);
                        Console.ReadLine();
                        return true;
                    }


                #endregion 

                default:
                    return true;
            }



        }

        private static double Sqrroot(double userInput)
        {
            var result = Math.Sqrt(userInput);
            return result;
        }

        private static double Pow2(double userInput)
        {
            var result = Math.Pow(userInput, 2);
            return result;
        }

        private static double Division(double userInput1, double userInput2)
        {
                var result = userInput1 / userInput2;
                return result;            
        }

        private static double Multiplication(double userInput1, double userInput2)
        {
            var result = userInput1 * userInput2;
            return result;
        }

        private static double Subtraction(double userInput1, double userInput2)
        {
            var result = userInput1 -userInput2;
            return result;
        }

        private static double Addition(double userInput1, double userInput2)
        {
            var result = userInput1 + userInput2;
            return result;
        }

        static double GetNumberFromUser()
        {
            double userInput = 0;
            bool succeeded = false;
            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
    }
}
