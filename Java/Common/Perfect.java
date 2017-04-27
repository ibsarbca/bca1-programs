// int num = 6;

// int[] digits = new int[];

// for(int i = num - 1; i >= 1; i--) {
// 	if(num % i == 0)
// 		digits.aadd(i);
// }

// int sum = 0;
// for(int i = 0; i < digits.length; i++) {
// 	sum += digits[i];
// }

// if sum == num {
// 	perfect number
// }

import java.util.*;

public class Perfect {
    public static void main(String[] args) {
        int num = 8128;

        int sum = 0;

        // 5 - 4 - 3 ..
        for(int i = num - 1; i > 0; i--) {
            if(num % i == 0) {
                System.out.print(i + " ");
                sum += i;
            }
        }
        System.out.println();
        System.out.println(sum);

        if (sum == num) {
            System.out.println("Perfect Number");
        }
    }	
}
