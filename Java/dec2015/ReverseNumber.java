import java.util.*;

public class ReverseNumber {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        Integer n = scn.nextInt();

        String nstr = n.toString();
        nstr = new StringBuffer(nstr).reverse().toString();
        System.out.println(nstr);
    }
}