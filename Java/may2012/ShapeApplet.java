import java.awt.*;
import java.applet.*;

/*
<applet code=ShapeApplet height=600 width=600>
</applet>
*/

public class ShapeApplet extends Applet {

    public void paint(Graphics g) {
        g.drawLine(50, 50, 100, 50);
        g.drawArc(25, 25, 120, 120, 45, 270);
        g.drawRect(50, 150, 100, 100);
        g.drawOval(50, 200, 90, 90);
        g.drawPolygon(30, 30, 30);
    }
}