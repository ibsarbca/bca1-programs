import java.awt.*;
import java.awt.event.*;

public class CheckboxColorChange extends Frame implements ItemListener {

    CheckboxGroup radioButtons = new CheckboxGroup();
    Checkbox redCB, blueCB, greenCB;
    String color = "";

    public CheckboxColorChange() {
        init();
    }

    public void init() {
        redCB = new Checkbox("red", radioButtons, false);
        greenCB = new Checkbox("green", radioButtons, false);
        blueCB = new Checkbox("blue", radioButtons, false);

        this.add(redCB);
        this.add(blueCB);
        this.add(greenCB);

        redCB.addItemListener(this);
        greenCB.addItemListener(this);
        blueCB.addItemListener(this);
    }

    public void itemStateChanged(ItemEvent e) {
        color = (String)e.getItem();
        repaint();
    }

    public void paint(Graphics g) {
        if (color.equals("red")) {
            setBackground(Color.red);
        }

        if (color.equals("green")) {
            setBackground(Color.green);
        }

        if (color.equals("blue")) {
            setBackground(Color.blue);
        }
    }

    public static void main(String[] args) {
        CheckboxColorChange frame = new CheckboxColorChange();
        frame.setLayout(new FlowLayout());
        frame.setSize(500, 500);
        frame.setVisible(true);
        frame.setTitle("Checkbox on select background change");
    }
}