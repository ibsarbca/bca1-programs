import java.io.*;

public class AppendFile {
    public static void main(String [] args) {
        
        byte[] inputBytes = new byte[10000];

        try {
            RandomAccessFile fileIn = new RandomAccessFile("input.txt", "r");
            fileIn.read(inputBytes);
            fileIn.close();

            RandomAccessFile fileOut = new RandomAccessFile("output.txt", "rw");
            fileOut.seek(fileOut.length()); // seek to end
            fileOut.write(inputBytes);
            fileOut.close();
        }

        catch(Exception ex) {
            ex.printStackTrace();
        }
    }
}