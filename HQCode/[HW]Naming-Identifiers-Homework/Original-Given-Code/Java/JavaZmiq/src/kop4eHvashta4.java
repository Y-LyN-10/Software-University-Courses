import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class kop4eHvashta4 implements KeyListener{
	
	public kop4eHvashta4(Igr1t1 game){
		game.addKeyListener(this);
	}
	
	public void keyPressed(KeyEvent e) {
		int KoDaNaKop4eto = e.getKeyCode();
		
		if (KoDaNaKop4eto == KeyEvent.VK_W || KoDaNaKop4eto == KeyEvent.VK_UP) {
			if(Igr1t1.moitaZmia.getVelY() != 20){
				Igr1t1.moitaZmia.setVelX(0);
				Igr1t1.moitaZmia.setVelY(-20);
			}
		}
		if (KoDaNaKop4eto == KeyEvent.VK_S || KoDaNaKop4eto == KeyEvent.VK_DOWN) {
			if(Igr1t1.moitaZmia.getVelY() != -20){
				Igr1t1.moitaZmia.setVelX(0);
				Igr1t1.moitaZmia.setVelY(20);
			}
		}
		if (KoDaNaKop4eto == KeyEvent.VK_D || KoDaNaKop4eto == KeyEvent.VK_RIGHT) {
			if(Igr1t1.moitaZmia.getVelX() != -20){
			Igr1t1.moitaZmia.setVelX(20);
			Igr1t1.moitaZmia.setVelY(0);
			}
		}
		if (KoDaNaKop4eto == KeyEvent.VK_A || KoDaNaKop4eto == KeyEvent.VK_LEFT) {
			if(Igr1t1.moitaZmia.getVelX() != 20){
				Igr1t1.moitaZmia.setVelX(-20);
				Igr1t1.moitaZmia.setVelY(0);
			}
		}
		//Other controls
		if (KoDaNaKop4eto == KeyEvent.VK_ESCAPE) {
			System.exit(0);
		}
	}
	
	public void keyReleased(KeyEvent e) {
	}
	
	public void keyTyped(KeyEvent e) {
		
	}

}
