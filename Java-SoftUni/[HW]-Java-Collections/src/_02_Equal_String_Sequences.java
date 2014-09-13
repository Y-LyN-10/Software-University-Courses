// Problem 2. Sequences of Equal Strings

// Write a program that enters an array of strings and finds in it all sequences of 
// equal elements. The input strings are given as a single line, separated by a space. 

import java.util.Scanner;

public class _02_Equal_String_Sequences {
	
	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)){
			
			String sequence = input.nextLine();
			String[] words = sequence.split(" ");
			
			for (int i = 0; i < words.length-1; i++) {
				
				//First, check if the next word is last at the
				//array to avoid out of range exception.
				if(i+1 == words.length) System.out.println(words[i]);
				
				//else, check equals and print on a single line non-equal elements
				else if (words[i].equals(words[i+1])) System.out.print(words[i]+ " ");
				else System.out.println(words[i]);
			}
		}
	}
}
