import java.awt.*;

public class NameColors extends Frame {

    String name = "DhavaL";
    Label [] nameLabels = new Label[5]; 

    public NameColors() {
        init();
    }

    public void init() {
        for(int i = 0; i < 5; i++) {
            nameLabels[i] = new Label(name);

            this.add(nameLabels[i]);
        }


        Font font = new Font("TimesRoman", Font.PLAIN, 24);
        nameLabels[0].setFont(font);
        nameLabels[0].setForeground(Color.red);

        font = new Font("Courier", Font.PLAIN, 24);
        nameLabels[1].setFont(font);
        nameLabels[1].setForeground(Color.black);

        font = new Font("Serif", Font.PLAIN, 24);
        nameLabels[2].setFont(font);
        nameLabels[2].setForeground(Color.blue);

        font = new Font("SansSerif", Font.PLAIN, 24);
        nameLabels[3].setFont(font);
        nameLabels[3].setForeground(Color.green);

        font = new Font("Monospace", Font.PLAIN, 24);
        nameLabels[4].setFont(font);
        nameLabels[4].setForeground(Color.white);
    }

    public static void main(String[] args) {
        NameColors frame = new NameColors();

        frame.setSize(300, 300);
        frame.setVisible(true);
        frame.setLayout(new FlowLayout());
    }
}