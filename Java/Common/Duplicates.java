public class Duplicates {
    public static void main(String[] args) {
        String arguments = "";
        for(String c: args) {
            if (!arguments.contains(c)) {
                arguments += c + " ";
            }
        }

        System.out.println(arguments);
    }
}