using System; //precisa colocar isso pra compilar no cmd
class test
{
	static string mensagem;
	public static void Main()
	{
		int numero1 = 0;
		int numero2 = 0;
		int total = 0;
		
		total = somar(100, 200);
		
		//mensagem = "A soma de " + numero1 + " mais " + numero2 + " é igual a " + total;
		
		Console.WriteLine(mensagem);
		Console.ReadLine();
	}
	
	static int somar(int numero1, int numero2)
	{
		return numero1 + numero2;
	}
	//help prompt dos
	/*
		dir - lista o conteúdo da pasta
		cd.. - volta um nível acima da pasta
		cd\ - vai para a raiz do root c:\
		mkdir - cria uma nova pasta dentro do diretório (mkdir nomeDaPasta)
		cd nomeDaPasta - acessa a pasta
		cls - limpa o prompt de comando
		
		********************************
		Compilar um programa C#
		ex.
		c:\plp\aula03\csc.exe nomeDoArquivo.cs
		*/
}