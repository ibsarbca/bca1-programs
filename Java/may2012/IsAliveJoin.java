public class IsAliveJoin implements Runnable {
    public void run() {
        for(int i = 0; i < 100; i++) {
            System.out.print(i + " ");
        }
    }

    public static void main(String[] args) throws InterruptedException {
        Thread t1 = new Thread(new IsAliveJoin());
        t1.start();

        for(char a = 'a'; a <= 'z'; a++) {

            if (t1.isAlive()) {
                t1.join();

                // Wait for the int loop to finish first.
                // Meaning the characters a-z will only be printed
                // after the count to 100
            }

            else {
                System.out.print(a + " ");
            }
        }

    }
}