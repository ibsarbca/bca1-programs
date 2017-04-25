class EmailException extends Exception {
    String message;

    public String toString() {
        return message;
    }

    public EmailException(String msg) {
        this.message = msg;
    }

}

public class CustomException {
y    public CustomException(String em) throws EmailException {
        if (!em.contains("@")) {
            throw new EmailException("ERROR: EMail must contain @");
        }
    }

    public static void main(String[] args) {
        try {
            CustomException a = new CustomException("2@");    
        }

        catch (EmailException ex) {
            System.out.println(ex);
        }   
    }
}
