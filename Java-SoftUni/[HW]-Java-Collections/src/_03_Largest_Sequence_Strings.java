// Problem 3. Largest Sequence of Equal Strings

// Write a program that enters an array of strings and finds in it the largest sequence of
// equal elements. If several sequences have the same longest length, print the leftmost 
// of them. The input strings are given as a single line, separated by a space. 

import java.util.Scanner;

public class _03_Largest_Sequence_Strings {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)){
			
			String sequence = input.nextLine();
			String[] words = sequence.split(" ");
			
			FindMaxEqualSequence(words);
		}
	}
	
	public static void FindMaxEqualSequence(String[] words){
		
		int counter = 1;
		int maxCount = 0;
		
		String wordInSequence = "";
		
		for (int i = 0; i < words.length-1; i++){
			
			if (words[i].equals(words[i+1])){
				counter++;	
			} 
			else{
				if (counter > maxCount) {
					maxCount = counter;
					wordInSequence = words[i];
				}
				counter = 1;
			}
		}
		
		PrintLongestSequence(maxCount, wordInSequence);
	}
	
	public static void PrintLongestSequence(int count, String word){
		
		for (int j = 0; j < count; j++) {
			System.out.print(word + " ");
		}
	}
}
