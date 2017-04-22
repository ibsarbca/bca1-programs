import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.util.*;

/*<applet code="SimpleCalculator" height=300 width=500></applet>*/

public class SimpleCalculator extends Applet implements ActionListener {
    ArrayList<Button> operatorButtonList = new ArrayList<Button>();
    TextField n1, n2, result;
    Panel inputs, output, buttons;
    Integer op1, op2;


    public void init() {
        operatorButtonList.add(new Button("+"));
        operatorButtonList.add(new Button("-"));
        operatorButtonList.add(new Button("/"));
        operatorButtonList.add(new Button("*"));

        n1 = new TextField(50);
        n2 = new TextField(50);
        result = new TextField(50);


        inputs = new Panel();
        output = new Panel();
        buttons = new Panel();

        for(Button b: operatorButtonList) {
            b.setPreferredSize(new Dimension(100, 50));
            b.addActionListener(new ActionListener() {
                public void actionPerformed(ActionEvent ae) {
                    try {
                        op1 = Integer.parseInt(n1.getText());
                        op2 = Integer.parseInt(n2.getText());

                        Button b = (Button)ae.getSource();

                        if ("+".equals(b.getLabel())) {
                            result.setText(new Integer(op1 + op2).toString());
                        }

                        if ("-".equals(b.getLabel())) {
                            result.setText(new Integer(op1 - op2).toString());
                        }

                        if ("/".equals(b.getLabel())) {
                            result.setText(new Integer(op1 / op2).toString());
                        }

                        if ("*".equals(b.getLabel())) {
                            result.setText(new Integer(op1 * op2).toString());
                        }

                    }

                    catch(NumberFormatException nfe) {
                        n1.setText("");
                        n2.setText("");
                    }
                }
            });
            buttons.add(b);
        }

        output.add(result);

        inputs.add(n1);
        inputs.add(n2);

        this.add(inputs);
        this.add(buttons);
        this.add(output);

        this.setLayout(new GridLayout(3, 1));
    }

    public void actionPerformed(ActionEvent ae) {
        Button b = (Button)ae.getSource();
    }
}