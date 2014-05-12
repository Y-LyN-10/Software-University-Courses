import javax.sql.rowset.Joinable;

import java.util.Arrays;

public class CardDeck {

	public static void main(String[] args) {
		
		String[] cardValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] cardSuits = { "♥", "♦", "♣", "♠" }; //2♥ 2♦ 2♣ 2♠
        String space = " ";

        System.out.println(cardValues.toString());
        
        for (int i = 0; i < cardSuits.length; i++) {
        	System.out.println(" ");
            for (int j = 0; j < cardValues.length; j++) {
            	System.out.print(joinStrings(cardSuits[i], space, cardValues[j]));	
			}
		}
	}
	
	public static String joinStrings(String suit, String space, String value){
		
		String line = value + suit + space;
		return line;
	}
}
