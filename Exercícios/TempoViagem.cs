using System;
					
public class Program
{
	public static void Main()
	{
		int tempo=0;
		char escolha;
		
		inicio:
		Console.Clear();
		
		Console.WriteLine("Tempos de viagem entre as cidades de São Paulo e Rio de Janeiro:");
		Console.WriteLine("[A] Avião| [C] Carro | [O]ônibus");
		
		escolha=char.Parse(Console.ReadLine());
		
		switch(escolha){
			case 'A':
			case 'a':
				tempo=2;
				break;
			case 'C':
			case 'c':
				tempo=6;
				break;
			case 'O':
			case 'o':
				tempo=7;
				break;
			default:
				tempo=-1;
				break;
		}
		if(tempo<0) {
		Console.WriteLine("Transporte inválido");
		} else {
		Console.WriteLine("Para o transporte escolhido o tempo é: {0} horas", tempo);
		}
		
		Console.WriteLine("Calcular outro transporte?: [S|N]");
		escolha=char.Parse(Console.ReadLine());
		if(escolha=='s'||escolha=='S'){
		goto inicio;
		}else{
		Console.Clear();
		Console.Write("Fim do Programa");
		}
	}
}
