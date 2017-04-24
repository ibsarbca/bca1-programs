import java.awt.event.*;
import java.awt.*;
import java.applet.*;
import javax.swing.*;

/*
<applet code="CornerLine" width=300 height=300></applet>
*/

/**
@brief This class extends a JPanel that implements the mouse events, that update
the panel when a mouse action is performed. This panel is then fit into the JApplet.
*/
class MyPanel extends JPanel implements MouseListener, MouseMotionListener {
    int x1, y1, x2, y2;

    MyPanel() {
        // Set a border
        setBorder(BorderFactory.createLineBorder(Color.BLACK, 1));    
    }
    public void mouseClicked(MouseEvent e) {
        
    }

    public void mouseEntered(MouseEvent e) {

    }

    public void mouseExited(MouseEvent e) {

    }

    public void mousePressed(MouseEvent e) {
        x1 = e.getX();
        y1 = e.getY();
    }

    public void mouseReleased(MouseEvent e) {

    }

    public void mouseDragged(MouseEvent e) {
        x2 = e.getX();
        y2 = e.getY();
        repaint();
    }

    public void mouseMoved(MouseEvent e) {

    }

    @Override
    protected void paintComponent(Graphics g) {
        // Always call the superclass method first.
        super.paintComponent(g);

        int height = getHeight();
        int width = getWidth();

        // Get border insets
        // ins = getInsets();

        g.drawLine(x1, y1, x2, y2);
        
    }
}


/**
@brief Represents the applet that will house the Panel where we will draw lines.
*/
public class CornerLine extends JApplet {
    MyPanel panel;


    public void init() {
        panel = new MyPanel();

        panel.addMouseListener(panel);
        panel.addMouseMotionListener(panel);

        this.add(panel);
    }
}