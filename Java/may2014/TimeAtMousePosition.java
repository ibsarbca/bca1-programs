import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.util.*;
import java.text.*;

/*<applet code=TimeAtMousePosition height=300 width=300></applet>*/

public class TimeAtMousePosition extends Applet implements MouseListener {
    int mouseX = 0;
    int mouseY = 0;

    public void init() {
        this.addMouseListener(this);
    }

    public void mousePressed(MouseEvent e) {

    }

    public void mouseReleased(MouseEvent e) {

    }

    public void mouseEntered(MouseEvent e) {

    }

    public void mouseExited(MouseEvent e) {

    }

    public void mouseClicked(MouseEvent e) {
        mouseX = e.getX();
        mouseY = e.getY();
        repaint();
    }

    public void paint(Graphics g) {
        Font font = new Font("TimesRoman", Font.BOLD, 13);
        this.setFont(font);
        // java 8
        // LocalTime currentTime = LocalTime.now();
        DateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy HH:mm:ss");
        Date date = new Date();
        g.drawString(dateFormat.format(date), mouseX, mouseY);
    }    
}