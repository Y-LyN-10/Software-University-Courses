// Problem 6. Count Specified Word

// Write a program to find how many times a word appears in given text. 
// The text is given at the first input line. The target word is given at 
// the second input line. The output is an integer number. Please ignore the 
// character casing. Consider that any non-letter character is a word separator. 

import java.util.ArrayList;
import java.util.Scanner;

public class _06_Count_Specified_Word {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)){
			
			String text = input.nextLine();
			String specialWord = input.nextLine();
			
			String[] words = text.split("\\W+");
			
			ArrayList<String> listedWords= new ArrayList<>();
			for (String word : words) listedWords.add(word);
			
			System.out.println(listedWords.stream()
					.filter(x -> x.equalsIgnoreCase(specialWord)).count());
		}
	}
}
