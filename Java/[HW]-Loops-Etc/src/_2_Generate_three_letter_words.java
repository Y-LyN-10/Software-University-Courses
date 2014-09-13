// Problem 2. Generate 3-Letter Words

// Write a program to generate and print all 3-letter words consisting of given set of 
// characters. For example if we have the characters 'a' and 'b', all possible words will 
// be "aaa", "aab", "aba", "abb", "baa", "bab", "bba" and "bbb". The input characters are 
// given as string at the first line of the input. Input characters are unique (there are 
// no repeating characters). Examples: Input: ab | Output: aaa aab aba abb baa bab bba bbb

import java.util.Scanner;

public class _2_Generate_three_letter_words {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)) {
			
			char[] charArr = input.next().toCharArray();
			
			for (char first : charArr) {
				for (char second : charArr) {
					for (char third : charArr) {
						System.out.printf("%c%c%c ", first, second, third);
					}
				}
			}
		}
	}
}
