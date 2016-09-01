import java.util.Scanner;

/**
 * Created by Elisaldo on 31/08/2016.
 */
public class Exercicio03b {
    public static int maiorNumero (int n1, int n2)
    {
        if (n1>n2)
            return n1;
        else if (n1<n2)
            return n2;
        else
            return -1;
    }

    public static void main(String[] args) {
        int n1=0, n2=0;
        Scanner tc = new Scanner(System.in);
        for (int i=0; i<5; i++)
        {
            System.out.println("Digite o primeiro valor: ");
            n1 = tc.nextInt();
            System.out.println("Digite o segundo valor: ");
            n2 = tc.nextInt();
            System.out.println(maiorNumero(n1, n2));
            if (maiorNumero(n1, n2) == -1)
            {
                System.out.println("Eles são iguais.");
            }
        }
    }
}
