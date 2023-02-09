using System;
					
public class vetor
{
	public static void Main()
	{
		int [] vetor1=new int[5];
		
		Random random= new Random();
		for(int i=0; i<vetor1.Length;i++){
			vetor1[i]=random.Next(50);
		}
		
		Console.WriteLine("Elementos do Vetor 1");
		foreach(int n in vetor1){
			Console.WriteLine(n);
		}
		
	}
}
