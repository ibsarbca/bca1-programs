import java.io.*;
import java.util.*;

public class FileToUpper {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner scn = new Scanner(System.in);
        PrintWriter pout = new PrintWriter("file.txt");

        String line = scn.nextLine();

        line = line.toUpperCase();

        System.out.println(line);

        pout.println(line);

        pout.close();
    }
}