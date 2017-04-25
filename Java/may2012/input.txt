import java.io.*;

// I believe this is a quine, i.e. a program that prints it's source code
// as the output
public class ReadFile {
    public static void main(String[] args) throws IOException {
        BufferedReader in = new BufferedReader(new FileReader("ReadFile.java"));

        StringBuffer output = new StringBuffer();

        int c;

        while((c = in.read()) != -1) {
            output.append((char)c);
        }

        System.out.println(output.toString());
    }
}