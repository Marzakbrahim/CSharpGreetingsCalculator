using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace calculatrice
{
    class Program
    {
        private static string choose = string.Empty ;
        static void Main(string[] args)
        {
            try
            {
                mainApplication();
            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


        }

        private static void mainApplication()
        {
            double a = 0; // 1er nombre
            double b = 0; // 2eme nombre
            String c = string.Empty;  // l'opération
            double resultat = 0;
            bool saisieValide = false;


            while (saisieValide == false)
            {
                //////////////////////////////////////////////////
                Console.WriteLine("Entrer le 1er nombre :");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Vous n'avez pas entré un entier ! veuillez saisir un nombre entier svp");
                }
                else
                {
                    saisieValide = true;
                }
            }
            saisieValide = false;
            while (saisieValide == false)
            {
                Console.WriteLine("Entrer le 2er nombre :");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Vous n'avez pas entré un entier ! veuillez saisir un nombre entier svp");
                }
                else
                {
                    saisieValide = true;
                }
            }

            saisieValide = false;
            while (saisieValide == false)
            {
                Console.WriteLine("Entrez une opération (+ ou - ou * ou /) ou 'Q' pour quitter");
                c = Console.ReadLine();
                if (c == "+" || c == "*" || c == "-" || c == "/" || c == "Q")
                {
                    saisieValide = true;
                }
                else
                {
                    Console.WriteLine("Votre saisie est invalide !");
                }
            }


            Calculatrice calculatrice = new Calculatrice();
            switch (c)
            {
                case "+":
                    resultat = calculatrice.Addition(a, b);
                    Console.WriteLine("le résultat est : " + resultat);
                    menu();
                    break;
                case "-":
                    resultat = calculatrice.Soustraction(a, b);
                    Console.WriteLine("le résultat est : " + resultat);
                    menu();
                    break;
                case "*":
                    
                    resultat = calculatrice.Multiplication(a, b);
                    Console.WriteLine("le résultat est : " + resultat);
                    menu();
                    break;
                case "/":
                    try
                    {
                        if (b == 0) 
                        {
                            Console.WriteLine("Attention, on ne peut pas diviser sur 0");
                            menu();
                        }
                        else
                        {
                            resultat = calculatrice.Division(a, b);
                            Console.WriteLine("le résultat est : " + resultat);
                            menu();
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "Q":

                    calculatrice.Quitter();
                    break;
            }
            Console.ReadKey();
        }

        // Application menu pour gérer l'arrêt : 
        private static void menu()
        {
            while(choose != "Q")
            {
                Console.WriteLine("Tapez R pour refaire une opération ou Q pour quitter l'application.");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "R":
                        mainApplication();
                        break;
                    case "Q":
                        Console.WriteLine("Vous avez Quitter l'application au revoir !");
                        break;
                    default: Console.WriteLine("Votre saisie est invalide !");
                        break;
                }
            }
        }
    }
}