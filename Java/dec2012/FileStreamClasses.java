import java.io.*;

public class FileStreamClasses {
    public static void main(String[] args) {
        try {
            FileInputStream in = new FileInputStream("input.txt");
            BufferedInputStream bufIn = new BufferedInputStream(in);

            FileOutputStream out = new FileOutputStream("output.txt");

            byte [] bytes = new byte[10000];

            in.read(bytes);

            out.write(bytes);

            in.close();
            out.close();
        }

        catch (Exception ex) {
            ex.printStackTrace();
        }
    }
}