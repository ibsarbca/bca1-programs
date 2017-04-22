package pk1;

public class AccessControl {
    public int var1;
    private int var2;
    protected int var3;
    int var4;

    public AccessControl(int v1, int v2, int v3, int v4) {
        this.var1 = v1;
        this.var2 = v2;
        this.var3 = v3;
        this.var4 = v4;

        System.out.println(var1);
        System.out.println(var2);
        System.out.println(var3);
        System.out.println(var4);
    }
}