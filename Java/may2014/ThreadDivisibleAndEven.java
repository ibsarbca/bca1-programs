 
class Divisible implements Runnable {
    public void run() {
        for(int i = 0; i < 20; i++) {
            System.out.println(i * 7);
        }
    } 
}

class Even implements Runnable {
    public void run() {
        for(int i = 0; i < 40; i++) {
            if(i % 2 == 0) {
                System.out.println(i);
            }
        }
    }
}

public class ThreadDivisibleAndEven {
    public static void main(String[] args) {
        Thread t1 = new Thread(new Divisible());
        Thread t2 = new Thread(new Even());

        t1.start();
        t2.start();
    }
}