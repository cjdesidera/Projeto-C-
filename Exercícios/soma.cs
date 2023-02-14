//Exercício utilizando comando this

using System;

class Calculo
{
	public int v1;
	public int v2;
	
	public int Somar()
	{
		return v1+v2;
	}
	
	public Calculo(int v1, int v2)
	{
		this.v1=v1;
		this.v2=v2;
	}
}


class Program {
	
	static void Main()
	{
		Calculo c=new Calculo(10,4);
		Console.WriteLine(c.Somar());
	}
}
