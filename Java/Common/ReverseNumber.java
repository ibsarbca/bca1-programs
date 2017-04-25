import java.util.*;

public class ReverseNumber {

    public int foo() {
        Scanner scn = new Scanner(System.in);

        System.out.println("Enter number");

        int num = scn.nextInt();
        int rev = 0;
        while (num != 0) {
            rev = rev * 10;
            rev = rev + (num % 10);
            num = num / 10;
        }

        return rev;
    }

    public static void main(String[] args) {
        ReverseNumber rn = new ReverseNumber();
        System.out.println(rn.foo());
    }
}