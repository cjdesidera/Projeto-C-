using System;
					
public class Program
{
	public static void Main()
	{
		int num=0;
		Console.WriteLine("Digite um número");
		num = int.Parse(Console.ReadLine());
		
		Dobrar(ref num);
		Triplicar(ref num);
	}
	
	static void Dobrar(ref int valor){
	valor*=2;
	Console.WriteLine("O dobro é {0}",valor);
	}
	static void Triplicar(ref int valor){
	valor*=3;
	Console.WriteLine("O triplo do dobro é {0}",valor);
	}
}
