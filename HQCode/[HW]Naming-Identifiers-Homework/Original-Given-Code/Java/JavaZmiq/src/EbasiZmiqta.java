import java.awt.Color;
import java.awt.Graphics;
import java.util.LinkedList;

public class EbasiZmiqta{
	LinkedList<To4ka> zmiiskoTqlo = new LinkedList<To4ka>();
	private Color cvetaNaZmiqta;
	private int velocityX, velocityY;
	
	public EbasiZmiqta() {
		cvetaNaZmiqta = Color.GREEN;
		zmiiskoTqlo.add(new To4ka(300, 100)); 
		zmiiskoTqlo.add(new To4ka(280, 100)); 
		zmiiskoTqlo.add(new To4ka(260, 100)); 
		zmiiskoTqlo.add(new To4ka(240, 100)); 
		zmiiskoTqlo.add(new To4ka(220, 100)); 
		zmiiskoTqlo.add(new To4ka(200, 100)); 
		zmiiskoTqlo.add(new To4ka(180, 100));
		zmiiskoTqlo.add(new To4ka(160, 100));
		zmiiskoTqlo.add(new To4ka(140, 100));
		zmiiskoTqlo.add(new To4ka(120, 100));

		velocityX = 20;
		velocityY = 0;
	}
	
	public void narisuvaiZmiata(Graphics g) {		
		for (To4ka point : this.zmiiskoTqlo) {
			point.risuvaiJivotnooo(g, cvetaNaZmiqta);
		}
	}
	
	public void tick() {
		To4ka nOVApoZiciqTo4ka = new To4ka((zmiiskoTqlo.get(0).daiXiksa() + velocityX), (zmiiskoTqlo.get(0).daiIgreka() + velocityY));
		
		if (nOVApoZiciqTo4ka.daiXiksa() > Igr1t1.WIDTH - 20) {
		 	Igr1t1.gameRunning = false;
		} else if (nOVApoZiciqTo4ka.daiXiksa() < 0) {
			Igr1t1.gameRunning = false;
		} else if (nOVApoZiciqTo4ka.daiIgreka() < 0) {
			Igr1t1.gameRunning = false;
		} else if (nOVApoZiciqTo4ka.daiIgreka() > Igr1t1.height - 20) {
			Igr1t1.gameRunning = false;
		} else if (Igr1t1.apalkata.daiTo4ka().equals(nOVApoZiciqTo4ka)) {
			zmiiskoTqlo.add(Igr1t1.apalkata.daiTo4ka());
			Igr1t1.apalkata = new Qbalkata(this);
			Igr1t1.to4ki += 50;
		} else if (zmiiskoTqlo.contains(nOVApoZiciqTo4ka)) {
			Igr1t1.gameRunning = false;
			System.out.println("You ate yourself");
		}	
		
		for (int i = zmiiskoTqlo.size()-1; i > 0; i--) {
			zmiiskoTqlo.set(i, new To4ka(zmiiskoTqlo.get(i-1)));
		}	
		zmiiskoTqlo.set(0, nOVApoZiciqTo4ka);
	}

	public int getVelX() {
		return velocityX;
	}

	public void setVelX(int velX) {
		this.velocityX = velX;
	}

	public int getVelY() {
		return velocityY;
	}

	public void setVelY(int velY) {
		this.velocityY = velY;
	}
}
