import java.applet.*;
import java.awt.*;
import java.awt.event.*;

/*<applet code=ListExample height=300 width=300></applet>*/

public class ListExample extends Applet {
    List left, right;
    Button lbtn, rbtn;

    public void init() {
        left = new List();
        right = new List(); 
        lbtn = new Button("<<");
        rbtn = new Button(">>");

        left.add("List");
        left.add("Label");
        left.add("Button");

        this.add(left);
        this.add(right);
        this.add(lbtn);
        this.add(rbtn);

        // this function sets a proper size so it doesn't take up
        // the entire space when using FlowLayout
        lbtn.setPreferredSize(new Dimension(100, 50));
        rbtn.setPreferredSize(new Dimension(100, 50));


        // Different action listeners since the buttons are technically
        // doing different things.
        lbtn.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ae) {
                String item = right.getSelectedItem();
                if (item != null) {
                    right.remove(item);
                    left.add(item);   
                }
            }
        });

        rbtn.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ae) {
                String item = left.getSelectedItem();
                System.out.println(item);
                if (item != null) {
                    left.remove(item);
                    right.add(item);
                }
            }
        });

    }

}