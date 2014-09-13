// Problem 5. Count All Words

// Write a program to count the number of words in given sentence. 
// Use any non-letter character as word separator.

import java.util.Scanner;

public class _05_Count_All_Words {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)){
			
			String text = input.nextLine();
			String[] words = text.split("\\W+");

			System.out.println(words.length);
			
// 			// Test to see words with no non-letter characters in them.			
//			for (String string : words) {
//				System.out.println(string);
//			}
		}
	}
}
