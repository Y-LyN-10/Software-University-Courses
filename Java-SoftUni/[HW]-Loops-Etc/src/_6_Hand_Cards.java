import java.util.Random;
import java.util.Scanner;

// Problem 6. Random Hands of 5 Cards
// Write a program to generate n random hands of 5 different cards form a standard suit of 52 cards.

public class _6_Hand_Cards {

	public static void main(String[] args) {

		try (Scanner sc = new Scanner(System.in)) {

			System.out.println("Enter the count of hands");
			int hands = sc.nextInt();
			
			String[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
			char[] patterns = { '♣', '♦', '♥', '♠' };
			
			boolean[] isCardUsed = new boolean[52];

			int card;
			int pattern;
			
			for (int i = 0; i < hands; i++) {
				for (int j = 0; j < 5; j++) {
					
					Random r = new Random();
					
					do {
						card = r.nextInt(12);
						pattern = r.nextInt(4);
						
						if (!isCardUsed[card * 4 + pattern]) {
							
							System.out.print(cards[card] + patterns[pattern] + " ");
							isCardUsed[card * 4 + pattern] = true;
							
							break;
						}
					} while (isCardUsed[card * 4 + pattern]);
				}
				System.out.println();
			}
		}
	}
}