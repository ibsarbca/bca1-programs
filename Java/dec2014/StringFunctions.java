
public class StringFunctions {
    public static void main(String[] args) {
        String val = "PGDCA Pune University Examinations";

        System.out.println(val.indexOf('P', val.indexOf('P') + 1));

        System.out.println(val.indexOf('E', val.lastIndexOf('E')));

        System.out.println(val.indexOf(val.charAt(12)));

        System.out.println("     Hello World   ".trim());

        String s1 = new String("Have a nice day.");

        String s2 = new String("PGDCA students");

        System.out.println(s1 + s2);

        System.out.println(new String(s1 + s2).toUpperCase());

        System.out.println((new StringBuffer("World").reverse()));
    }
}