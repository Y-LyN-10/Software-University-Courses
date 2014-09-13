import java.util.Scanner;

public class OddEvenSequence {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)) {

			String inputLine = input.nextLine().trim();
			String[] parts = inputLine.split("\\D+");

			int n = parts.length;
			int[] numbers = new int[n];

			for (int i = 1; i < n - 1; i++) {

				numbers[i] = Integer.parseInt(parts[i]);
				// System.out.println(numbers[i]); - test
			}

			System.out.println(CountSequence(numbers));
			
//			//test - print all numbers in the array
//			for (int i = 1; i < n; i++) {
//				System.out.println(numbers[i]);
//			}
		}
	}	
	
	private static int CountSequence(int[] numbers) {

		int counter = 1;
		int maxCount = 0;
		int n = numbers.length;
		
		String lastKeyWord = "";

		for (int i = 1; i < n - 1; i++) {

			String firstNumKey = checkNum(numbers[i], lastKeyWord);
			lastKeyWord = firstNumKey;
			String secondNumKey = checkNum(numbers[i + 1], lastKeyWord);
			lastKeyWord = secondNumKey;

			if (!(firstNumKey.equals(secondNumKey))) {
				counter++;
			} else {
				if (counter > maxCount) {
					maxCount = counter;
				}
				counter = 1;
			}
		}
		
		if (counter > maxCount) {
			maxCount = counter;
		}
		
		return maxCount;
	}

	public static String checkNum(int number, String lastKeyWord) {

		if (number == 0) {
			if (lastKeyWord.equals("magic")) {
				return "joker";
			} else {
				return "magic";
			}
		} else if (number % 2 == 0) {
			return "even";
		} else {
			return "odd";
		}
	}
}

// Input test 1
// (3) (22) (-18) (55) (44) (3) (21) 
// Output: 4

// Input test 2
// (1)(2)(3)(4)(5)(6)(7)(8)(9)(10) //10