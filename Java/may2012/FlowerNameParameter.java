import java.awt.*;
import java.applet.*;

/*<applet code=FlowerNameParameter height=300 width=300 flowerName="Daisy">
</applet>*/

public class FlowerNameParameter extends Applet {
    String flowerName;
    Label flowerNameLabel;

    public void init() {
        flowerName = getParameter("flowerName");

        flowerNameLabel = new Label(flowerName + " is a beautiful flower");

        Font font = new Font("TimesRoman", Font.PLAIN, 40);

        flowerNameLabel.setFont(font);

        this.add(flowerNameLabel);
    }
}