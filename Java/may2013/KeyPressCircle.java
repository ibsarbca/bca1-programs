import java.awt.*;
import java.awt.event.*;
import java.applet.*;

/*<applet code=KeyPressCircle height=500 width=500>
</applet>*/

public class KeyPressCircle extends Applet implements KeyListener {
    
    int x = 0;
    int y = 0;
    int rad = 100;

    public KeyPressCircle() {
        
        this.addKeyListener(this);
    }

    public void init() {
        Dimension dim = this.getSize();
        x = dim.height / 2;
        y = dim.width / 2;
    }

    public void keyPressed(KeyEvent ev) {
        
    }

    public void keyReleased(KeyEvent ev) {

    }

    public void keyTyped(KeyEvent ev) {
        //System.out.println(ev.getKeyChar());
        System.out.println(ev.getKeyChar());

        if (ev.getKeyChar() == 'S' || ev.getKeyChar() == 'D')
            rad += 10;

        if (ev.getKeyChar() == 'B' || ev.getKeyChar() == 'L')
            rad -= 10;
        repaint();
    }

    public void paint(Graphics g) {
        g.drawOval(x - rad / 2, y - rad /2 , rad, rad);  // to make it dead center
    }
}