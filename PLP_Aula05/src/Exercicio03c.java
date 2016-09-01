import java.util.Scanner;

/**
 * Created by Elisaldo on 31/08/2016.
 */
public class Exercicio03c {
    public static int lePositivo (int num)
    {
        Scanner tc = new Scanner(System.in);
        do
        {
            System.out.println("Digite um valor maior que 0:");
            num = tc.nextInt();
            if (num <= 0)
                System.out.println("Somente valores maiores que 0!");

        }while (num <= 0);

        return num;
    }

    public static int somatorio (int num)
    {
        int result=0;
        num = lePositivo(num);
        for (int i=0; i<=num; i++)
        {
            result = result + i;
        }
        System.out.println("Somatorio do numero: ");
        return result;
    }

    public static void main(String[] args)
    {
        int result=0;
        for (int i=0; i<5; i++)
        {
            System.out.println(somatorio(result));
        }
    }
}
