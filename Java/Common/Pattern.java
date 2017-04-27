public class Pattern {
    public static void main(String[] args) {
        for(int i = 5; i > 0; i--) {
            for(int j = i; j > 0; j--) {
                if(i % 2 == 0)
                    System.out.print("0");
                else

                    System.out.print("1");
            }
            System.out.println();
        }
    }
}