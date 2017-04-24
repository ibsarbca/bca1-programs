import java.awt.*;
import java.awt.event.*;

public class TextFieldFindReplace extends Frame implements ActionListener {
    TextField t1, t2, t3;
    Button b;
    Label l1, l2, l3;

    public TextFieldFindReplace() {
        init();

        this.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });
    }

    public void init() {
        l1 = new Label("String");
        l2 = new Label("Find");
        l3 = new Label("Replace");

        t1 = new TextField(20);
        t2 = new TextField(20);
        t3 = new TextField(20);

        this.add(l1);
        this.add(t1);

        this.add(l2);
        this.add(t2);

        this.add(l3);
        this.add(t3);

        b = new Button("Replace");
        this.add(b);
        b.addActionListener(this);
    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == b) {
            t1.setText(t1.getText().replaceAll(t2.getText(), t3.getText()));
        }
    }

    public static void main(String[] args) {
        TextFieldFindReplace f = new TextFieldFindReplace();

        f.setSize(500, 200);
        f.setTitle("Repalce Word");
        f.setVisible(true);
        f.setLayout(new GridLayout(4, 2));
    }
}