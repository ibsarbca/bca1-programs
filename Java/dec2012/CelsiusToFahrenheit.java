import java.awt.*;
import java.awt.event.*;
import java.applet.*;

public class CelsiusToFahrenheit extends Frame implements ActionListener {

    TextField celsius;
    Button b;
    Label l;

    public CelsiusToFahrenheit() {
        init();
    }

    public void init() {
        b = new Button("Convert!");
        b.addActionListener(this);

        celsius = new TextField(12);

        this.add(celsius);
        this.add(b);        

        l = new Label("");

        // this function sets a proper size so it doesn't take up
        // the entire space when using FlowLayout
        l.setPreferredSize(new Dimension(100, 100));
        this.add(l);
    }

    public void actionPerformed(ActionEvent ev) {
        String celsius_val = celsius.getText();
        
        int celsius_int = 0;

        try {
            celsius_int = Integer.parseInt(celsius_val);
        }

        catch(NumberFormatException nfe) {
            celsius_int = 0;
        }

        int fahrenheit_int = celsius_int * (9 / 5) + 32;
        l.setText(fahrenheit_int + " F");
    }

    public static void main(String[] args) {
        CelsiusToFahrenheit frame = new CelsiusToFahrenheit();
        frame.setTitle("Convert temperature");
        frame.setSize(500, 200);
        frame.setLayout(new FlowLayout());

        frame.l.setLocation(frame.l.getX(), frame.l.getY() + 20);
        frame.setVisible(true);
    }
}