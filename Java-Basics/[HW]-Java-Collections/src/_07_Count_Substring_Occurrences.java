// Problem 7. Count Substring Occurrences

// Write a program to find how many times given string appears in given text as substring. 
// The text is given at the first input line. The search string is given at the second 
// input line. The output is an integer number. Please ignore the character casing. 

import java.util.Scanner;

public class _07_Count_Substring_Occurrences {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)){
			
			String text = input.nextLine().toLowerCase();
			String specialWord = input.nextLine().toLowerCase();
			
			int count = 0;
			
			for (int i = 0; i <= text.length() - specialWord.length(); i++) {
                if (text.substring(i, i + specialWord.length()).equals(specialWord))
                	count++;
			}
       
			System.out.println(count);
		}
	}

}
