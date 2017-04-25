import java.awt.*;
import java.awt.event.*;

public class RectangleArea extends Frame implements MouseListener {
    int topX, topY, lenX, lenY;
    int mouseX = 0, mouseY = 0;

    Label l;

    public void mouseClicked(MouseEvent e) {

        int x = e.getX();
        int y = e.getY();


        // Within the rectangle.
        if ((x >= topX && x <= (topX + lenX)) && (y >= topY && y <= (topY + lenY))) {
            topX = 0;
            topY = 0;
            lenX = 0;
            lenY = 0;

            l.setText(x + ", " + y);
        }
        else {
            topX = 50;
            topY = 50;
            lenX = 50;
            lenY = 50;
            l.setText(l.getText() + " not in square");
        }
        repaint();
    }

    public void mousePressed(MouseEvent e) {

        int x = e.getX();
        int y = e.getY();


        l.setText(x + ", " + y);
    }

    public void mouseReleased(MouseEvent e) {

    }

    public void mouseEntered(MouseEvent e) {

    }

    public void mouseExited(MouseEvent e) {

    }

    public void paint(Graphics g) {

        g.drawRect(topX, topY, lenX, lenY);
        g.drawString(topX + ", " + topY + ", " + lenX + ", " + lenY, mouseX, mouseY);
    }

    public void init() {
        topX = 50;
        topY = 50;
        lenX = 50;
        lenY = 50;

        l = new Label();
    }

    public RectangleArea() {
        init();
        this.add(l);
        this.addMouseListener(this);
    }

    public static void main(String[] args) {
        RectangleArea ra = new RectangleArea();
        ra.setTitle("Rectangle");
        ra.setSize(300, 300);
        ra.setVisible(true);
        ra.setLayout(new FlowLayout());

    }
}