// Problem 9. Combine Lists of Letters

// Write a program that reads two lists of letters l1 and l2 and combines them: 
// appends all letters c from l2 to the end of l1, but only when c does not 
// appear in l1. Print the obtained combined list. All lists are given as sequence 
// of letters separated by a single space, each at a separate line. Use 
// ArrayList<Character> of chars to keep the input and output lists. 

import java.util.ArrayList;
import java.util.Scanner;

public class _09_Combine_List_Letters {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)){
			
			char[] firstLine = input.nextLine().replaceAll(" ", "").toCharArray();
            char[] secondLine = input.nextLine().replaceAll(" ", "").toCharArray();
			
          	ArrayList<Character> l1 = new ArrayList<>();
          	for (Character character : firstLine) l1.add(character);
          	
          	ArrayList<Character> l2 = new ArrayList<>();
          	for (Character character : secondLine) l2.add(character);

          	ArrayList<Character> finalList = new ArrayList<>();
          	for (Character character : firstLine) finalList.add(character);
          	
            for (Character character : l2) {
				if (!(l1.contains(character))) {
					finalList.add(character);
				}
			}
            
            for (Character character : finalList) {
				System.out.print(character + " ");
			}
		}
	}
}
