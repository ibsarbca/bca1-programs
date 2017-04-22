public class MaxCommandLine {
    public static void main(String[] args) {
        int x, y;

        try {
            x = Integer.parseInt(args[0]);
            y = Integer.parseInt(args[1]);
        }
        catch (NumberFormatException nfe) {
            x = 0;
            y = 0;
        }

        if (x > y)
            System.out.println("" + x);
        else
            System.out.println("" + y);
    }
}