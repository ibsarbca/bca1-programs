import java.io.*;

public class SwapFiles {
    public static void main(String[] args) throws IOException {
        BufferedReader in = new BufferedReader(new FileReader("input.txt"));

        PrintWriter out = new PrintWriter("output.txt");

        int c;

        StringBuffer tmpString = new StringBuffer();

        while((c = in.read()) != -1) {
            tmpString.append((char)c);
        }

        in.close();
        out.close();
    }
}