import java.awt.*;
import java.awt.event.*;
import javax.swing.*;


/*
<applet code="SwingFontComboBox" height=300 width=300></applet>
*/

public class SwingFontComboBox extends JApplet {
    JComboBox<String> fontNameCB;
    JComboBox<Integer> fontSizeCB;

    JLabel label;

    String msg = "WELCOME TO JAVA!";

    Font font;


    String[] fontNames = { "TimesRoman", "Serif", "SansSerif" };
    Integer[] fontSizes = { 12, 14, 16, 18 };

    public void init() {
        try {
            SwingUtilities.invokeAndWait(
                new Runnable() {
                    public void run() {
                        makeGUI();
                    }
                }
            );
        }

        catch(Exception ex) {
            System.out.println("Can't create because of " + ex);
        }
    }

    private void makeGUI() {
        setLayout(new FlowLayout());

        // Instantiate comboboxes
        fontNameCB = new JComboBox<String>(fontNames);
        fontSizeCB = new JComboBox<Integer>(fontSizes);

        add(fontNameCB);
        add(fontSizeCB);

        label = new JLabel("WELCOME TO JAVA!");
        label.setLocation(150, 150);

        add(label);

        // Handle Selections
        fontNameCB.addActionListener(new ComboBoxHandler());
        fontSizeCB.addActionListener(new ComboBoxHandler());
    }

    class ComboBoxHandler implements ActionListener {
        public void actionPerformed(ActionEvent ae) {
            String name = (String)fontNameCB.getSelectedItem();
            Integer size = (Integer)fontSizeCB.getSelectedItem();

            font = new Font(name, Font.PLAIN, size);
            label.setFont(font);
        }
    }

}