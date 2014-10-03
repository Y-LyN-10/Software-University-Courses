import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;

public class To4ka {
	private int xiks, igrek;
	private final int WidH = 20;
	private final int HeigT = 20;
	
	public To4ka(To4ka p){
		this(p.xiks, p.igrek);
	}
	
	public To4ka(int x, int y){
		this.xiks = x;
		this.igrek = y;
	}	
		
	public int daiXiksa() {
		return xiks;
	}
	public void namestiXiksa(int x) {
		this.xiks = x;
	}
	public int daiIgreka() {
		return igrek;
	}
	public void namestIgreka(int y) {
		this.igrek = y;
	}
	
	public void risuvaiJivotnooo(Graphics g, Color cvqt) {
		g.setColor(Color.BLACK);
		g.fillRect(xiks, igrek, WidH, HeigT);
		g.setColor(cvqt);
		g.fillRect(xiks+1, igrek+1, WidH-2, HeigT-2);		
	}
	
	public String toString() {
		return "[x=" + xiks + ",y=" + igrek + "]";
	}
	
	public boolean equals(Object obektjj) {
        if (obektjj instanceof To4ka) {
            To4ka to4ka = (To4ka)obektjj;
            return (xiks == to4ka.xiks) && (igrek == to4ka.igrek);
        }
        return false;
    }
}
