import java.io.*;

public class CommandLineRaisedTo {
    public static void main(String[] args) {
        Double a = 0.0, b = 0.0;

        InputStreamReader in = new InputStreamReader(System.in);

        BufferedReader br = new BufferedReader(in);

        System.out.println("Enter number and the index: ");

        try {
            a = Double.parseDouble(br.readLine());
            b = Double.parseDouble(br.readLine());
        }

        catch(NumberFormatException e) {
            System.out.println("Error, expected real number. Exiting");
            System.exit(1);
        }

        catch(IOException e) {
            System.out.println(e.getMessage());
            System.exit(1);
        }

        System.out.println(Math.pow(a, b));
    }
}