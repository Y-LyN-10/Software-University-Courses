import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _12_Card_Frequences {

	public static void main(String[] args) {

		try (Scanner scanner = new Scanner(System.in)) {

			String[] cards = scanner.nextLine().split("[ ♥♣♦♠]+");
			Map<String, Integer> cardsMap = new LinkedHashMap<String, Integer>();
			
			for (String card : cards) {
				Integer count = cardsMap.get(card);
				if (count == null) {
					count = 0;
				}
				cardsMap.put(card, count + 1);
			}
			
			for (Map.Entry<String, Integer> entry : cardsMap.entrySet()) {
				double precentage = (double) entry.getValue() * 100 / cards.length;
				System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
			}
		}
	}

}
