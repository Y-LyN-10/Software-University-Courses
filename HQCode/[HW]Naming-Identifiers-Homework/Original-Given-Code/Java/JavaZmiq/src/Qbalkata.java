import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;


public class Qbalkata {
	public static Random on4eBon4eGenerator;
	private To4ka qbalkaObekt;
	private Color cvetaNaZmiat1;
	
	public Qbalkata(EbasiZmiqta s) {
		qbalkaObekt = createQbalkata(s);
		cvetaNaZmiat1 = Color.RED;		
	}
	
	private To4ka createQbalkata(EbasiZmiqta s) {
		on4eBon4eGenerator = new Random();
		int x = on4eBon4eGenerator.nextInt(30) * 20; 
		int y = on4eBon4eGenerator.nextInt(30) * 20;
		for (To4ka snakePoint : s.zmiiskoTqlo) {
			if (x == snakePoint.daiXiksa() || y == snakePoint.daiIgreka()) {
				return createQbalkata(s);				
			}
		}
		return new To4ka(x, y);
	}
	
	public void drawQbalkata(Graphics g){
		qbalkaObekt.risuvaiJivotnooo(g, cvetaNaZmiat1);
	}	
	
	public To4ka daiTo4ka(){
		return qbalkaObekt;
	}
}
