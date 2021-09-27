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
            double userInput1, userInput2, result;
            Console.Clear();
            Console.WriteLine("Välkommen att använda miniräknarfunktionen:");
            Console.WriteLine("Skriv in ditt första tal och tryck enter:\n");
            userInput1 = GetNumberFromUser();  
            
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
            

            switch (userCT)
            {
                #region 1 Addition
                case 1:

                    
                    //Start calculation
                    Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                    userInput2 = GetNumberFromUser();
                    result = userInput1 + userInput2;
                    Console.WriteLine("\n" + userInput1 + " + " + userInput2 + " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 2 Subtraktion
                case 2:


                    //Start calculation
                    Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                    userInput2 = GetNumberFromUser();
                    result = userInput1 - userInput2;
                    Console.WriteLine("\n" + userInput1 + " - " + userInput2 + " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 3 Multiplikation
                case 3:


                    //Start calculation
                    Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                    userInput2 = GetNumberFromUser();
                    result = userInput1 * userInput2;
                    Console.WriteLine("\n" + userInput1 + " * " + userInput2 + " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 4 Division
                case 4:


                    //Start calculation
                    Console.WriteLine("\nSkriv in ditt andra tal och tryck enter:");
                    userInput2 = GetNumberFromUser();
                    result = userInput1 / userInput2;
                    Console.WriteLine("\n" + userInput1 + " / " + userInput2 + " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 4 Kvadraten (x^2)
                case 5:


                    //Start calculation
                    
                    result = Math.Pow(userInput1, 2);
                    Console.WriteLine("\n" + userInput1 + "^2 " +  " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 4 Kvadratroten
                case 6:


                    //Start calculation

                    result = Math.Sqrt(userInput1);
                    Console.WriteLine("\nKvadratroten ur " + userInput1 + " = " + result + "\n");
                    Console.ReadLine();

                    return true;

                #endregion

                #region 7 Avsluta
                case 7:
                    return false;
                #endregion
                default:
                    return true;
            }



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
