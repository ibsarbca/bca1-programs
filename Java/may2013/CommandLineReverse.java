import java.util.*;

public class CommandLineReverse {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        String s = "";

        while(scn.hasNext()) {
            s += scn.next();
        }

        System.out.println(new StringBuffer(s).reverse());
    }
}  