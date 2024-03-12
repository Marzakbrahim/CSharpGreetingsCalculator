/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue !");
        double moyenne = CalculerMoyenne();
        Console.WriteLine("La moyenne est : " + moyenne);
    }

    static double CalculerMoyenne()
    {
    double num1 = 0, num2 = 0, num3 = 0;
    bool saisieValide = false;

    while (!saisieValide)
    {
        Console.WriteLine("Entrez le premier nombre :");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Vous n'avez pas entré un nombre valide. Veuillez réessayer.");
        }
        else
        {
            saisieValide = true;
        }
    }

    saisieValide = false;
    while (!saisieValide)
    {
        Console.WriteLine("Entrez le deuxième nombre :");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Vous n'avez pas entré un nombre valide. Veuillez réessayer.");
        }
        else
        {
            saisieValide = true;
        }
    }

    saisieValide = false;
    while (!saisieValide)
    {
        Console.WriteLine("Entrez le troisième nombre :");
        if (!double.TryParse(Console.ReadLine(), out num3))
        {
            Console.WriteLine("Vous n'avez pas entré un nombre valide. Veuillez réessayer.");
        }
        else
        {
            saisieValide = true;
        }
    }

    double moyenne = (num1 + num2 + num3) / 3;
    return moyenne;
    }

}
*/
using System ;
class Program 
{
    static void Main(String[] args)
    {
        //String nom ;
        //Console.WriteLine("Entrez votre nom svt !");
        //nom=Console.ReadLine();
        //Console.WriteLine("Salut {0}! bienvenue dans notre programme :",nom);
        DateTime dateCourante=DateTime.Now;
        if (dateCourante.DayOfWeek != DayOfWeek.Saturday && dateCourante.DayOfWeek != DayOfWeek.Sunday && (dateCourante.DayOfWeek != DayOfWeek.Friday || dateCourante.Hour <= 18))
        {
            // on est en semaine 
            if (dateCourante.Hour > 6 && dateCourante.Hour < 18)
            {
                // on est le jour
                afficherBonjour();
            }
            else
            {
                // on est le soir 
                afficherBonsoir();
            }
        }
        else
        {
            // on est le weekend
            afficherBonWeekEnd();
        }
        int somme=calculeroperation();
        Console.WriteLine("le résultat est : {0}",somme);

    }
    static void afficherBonjour(){
        Console.WriteLine("Bonjour " + Environment.UserName);
    }

    static void afficherBonsoir(){
        Console.WriteLine("Bonsoir " + Environment.UserName);
    }

    static void afficherBonWeekEnd(){
        Console.WriteLine("Bon Week-end " + Environment.UserName);
    }
    static int calculeroperation()
    {
        int a=0 ;
        int b=0;
        char op=' ';
        bool saisieValide= false;
        while(!saisieValide)
        {
            Console.WriteLine("Entrer le 1er nombre :");
            if(!int.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Vous n'avez pas entré un entier ! veuillez saisir un nombre entier svp");
            }
            else 
            {
                saisieValide= true;
            }
        }



        saisieValide= false;
        while(!saisieValide)
        {
            Console.WriteLine("Entrer le 2emme nombre :");
            if(!int.TryParse(Console.ReadLine(),out b))
            {
                Console.WriteLine("Vous n'avez pas entré un entier ! veuillez saisir un nombre entier svp");
            }
            else 
            {
                saisieValide= true;
            }
        }


        saisieValide= false;
        while(!saisieValide)
        {
            Console.WriteLine("Entrer une opération (*,+,-,/):");
            op=char.Parse(Console.ReadLine());
            if(op !='*' && op !='-' && op !='+' && op !='/')
            {
                Console.WriteLine("L\'opération est invalide ! entrez une opération valide svp !");
            }
            else 
            {
                saisieValide= true;
            }
        }
        int result=0;
        switch(op)
        {
            case '+':
            {
                result=a+b;
                break;
            }
            case '-':
            {
                result=a-b;
                break;
            }
            case '*':
            {
                result=a*b;
                break;
            }
            case '/':
            {
                result=a/b;
                break;
            }
        }
        return result;
    }

}

