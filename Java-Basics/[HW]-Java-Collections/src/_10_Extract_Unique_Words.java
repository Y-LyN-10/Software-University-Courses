// Problem 10. Extract All Unique Words

// At the first line at the console you are given a piece of text. 
// Extract all words from it and print them in alphabetical order. 
// Consider each non-letter character as word separator. Take the 
// repeating words only once. Ignore the character casing. 
// Print the result words in a single line, separated by spaces. 

import java.util.Scanner;
import java.util.SortedSet;
import java.util.TreeSet;

public class _10_Extract_Unique_Words {

	public static void main(String[] args) {
	
		try (Scanner input = new Scanner(System.in)){
						
			String text = input.nextLine();
			String[] words = text.split("\\W+"); 
			
			SortedSet<String> uniqueWords = new TreeSet<>();
			for (String word : words) uniqueWords.add(word);

			uniqueWords.stream().sorted().forEach(x-> System.out.println(x));
		}
	}
}
