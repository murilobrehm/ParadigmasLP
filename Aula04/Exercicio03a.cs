#include <stdio.h>
#include <conio.h>

/*Escreva um programa em C que leia 10 valores inteiros e imprima para
cada um o seu correspondente valor absoluto. Para obter o valor absoluto
do número utilize a função Absoluto especificada abaixo:
Nome: Absoluto
Descrição: Retorna o valor absoluto do número fornecido. 
Entrada: int n
Saída: (int) O respectivo valor absoluto de n.
Obs:
-O valor absoluto de 10 é 10.
-O valor absoluto de -10 é 10. */

int Absoluto (int n)
{
	if (n>=0)
		return n;
	else
		return n * -1;
}

main()
{
	int n=0, resp=0;
	for (int i=0; i<10; i++)
	{
		scanf ("%i", &n);
		resp = Absoluto (n);
		printf ("%i", resp);
	}
}