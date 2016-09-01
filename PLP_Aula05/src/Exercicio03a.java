import java.util.Scanner;

/**
 * Created by Elisaldo on 31/08/2016.
 */
public class Exercicio03a {
    public static int absoluto (int n)
    {
        if (n>=0)
            return n;
        else
            return n * -1;
    }

    public static void main(String[] args) {
        int n=0;
        Scanner tc = new Scanner(System.in);
        for (int i=0; i<10; i++)
        {
            System.out.println("Insira o numero " + i);
            n = tc.nextInt();
            System.out.println("Seu valor absoluto é: ");
            System.out.println(absoluto(n));
        }
    }
}
