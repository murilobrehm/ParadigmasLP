using System;
class Test
{
	public static void Main()
	{
		int  op=0;
		float num1=0;
		float num2=0;
		float resp=0;

		do
		{
			Console.WriteLine("\nEscolha uma opcao de calculo: ");  
			Console.WriteLine("\n1 - Multiplicacao \n2 - Soma\n3 - Divisao\n4 - Subtracao \n5 - Sair\n");
			do
			{ 
				op = int.Parse(Console.ReadLine());
				if ((op < 1) || (op>5))
				{
					Console.WriteLine("\nOpcao invalida!!");
				}
			}while ((op < 1) || (op>5));
			
			if (op != 5)
			{
				Console.WriteLine("\nDigite um numero: ");
				num1 = float.Parse(Console.ReadLine());     
				Console.WriteLine("\nDigite outro numero: ");
				num2 = float.Parse(Console.ReadLine()); 
			}          
		
			switch (op)
			{
				case 1: 
					resp = multiplica(num1, num2);
					break;
				case 2: 
					resp = soma(num1, num2); 
					break;      
				case 3:
					resp = divisaoDeNumerosNumericosMuitoLokosssss(num1, num2);
					break;
				case 4:
					resp = subtracao(num1, num2);
					break;
			}
		
			if (op==5)
			Console.WriteLine("\nPrograma encerrado.....");
			else   
			Console.WriteLine("\nResultado da operacao escolhida: " + resp);
		
		}while (op !=5);
	}
	
	static float multiplica(float x, float y)
	{
		return x*y;
	}
	
	static float soma(float num1, float num2)
	{
		return num1+num2;
	}
	
	static float divisaoDeNumerosNumericosMuitoLokosssss(float num1, float num2)
	{
		return num1/num2;
	}
	
	static float subtracao(float num1, float num2)
	{
		return num1-num2;
	}
}