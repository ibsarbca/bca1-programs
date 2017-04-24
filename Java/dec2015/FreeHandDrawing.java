import java.awt.*;
import java.applet.*;
import java.awt.event.*;

/*
<applet code="FreeHandDrawing" width=360 height=900>
</applet>
*/

public class FreeHandDrawing extends Applet {
    public int mouseX = 0;
    public int mouseY = 0;
    public int moveX = 0;
    public int moveY = 0;

    Choice shapeChoice;

    public void init() {
        shapeChoice = new Choice();
        shapeChoice.add("line");
        shapeChoice.add("arc");

        shapeChoice.addItemListener(new ItemListener() {
            public void itemStateChanged(ItemEvent e) {
                mouseX = 0;
                mouseY = 0;
                moveX = 0;
                moveY = 0;
                repaint();
            }
        });

        this.add(shapeChoice);

        this.addMouseListener(new MouseAdapter() {
            public void mousePressed(MouseEvent me) {
                mouseX = me.getX();
                mouseY = me.getY();
            }

            public void mouseReleased(MouseEvent me) {
                repaint();
            }
        });

        this.addMouseMotionListener(new MouseAdapter() {
            public void mouseDragged(MouseEvent me) {
                moveX = me.getX();
                moveY = me.getY();
                repaint();
            }
        });
    }

    public void paint(Graphics g) {
        if("line".equals(shapeChoice.getSelectedItem())) {
            g.drawLine(mouseX, mouseY, moveX, moveY);
        } else if ("arc".equals(shapeChoice.getSelectedItem())) {
            g.drawArc(mouseX, mouseY, moveX - mouseX, moveY - mouseY, 24, 180);
        }

        showStatus("msX: " + mouseX + ", msY: " + mouseY + ", mvX: " + moveX + ", mvY:" + mouseY);
    }
}