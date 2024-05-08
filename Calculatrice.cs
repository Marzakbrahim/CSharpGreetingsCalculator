using System;

public class Calculatrice
{
	public double Addition(double a , double b)
	{
		return a+b ;
	}

	public double Soustraction(double a , double b)
		{
			return a-b ;
		}
	public double Multiplication(double a , double b)
	{
		return a*b ;
	}
	public double Division(double a , double b)
	{
        return a / b;

    }
	public void Quitter()
	{
        Console.WriteLine("Vous avez quitté");
        

    } 

}
