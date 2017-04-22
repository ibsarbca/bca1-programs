import java.awt.*;
import java.applet.*;
import java.awt.event.*;

/*<Applet code=MouseStatus height=300 width=300></applet>*/

public class MouseStatus extends Applet implements MouseMotionListener {
    int mouseX = 0;
    int mouseY = 0;

    public void init() {
        this.addMouseMotionListener(this);
    }

    public void mouseMoved(MouseEvent e) {
        mouseX = e.getX();
        mouseY = e.getY();
        repaint();
    }

    public void mouseDragged(MouseEvent e) {
        repaint();
    }

    public void paint(Graphics g) {
        showStatus(mouseX + ", " + mouseY);
    }
}