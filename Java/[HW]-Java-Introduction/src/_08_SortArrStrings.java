import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class _08_SortArrStrings {
	
	public static void main(String[] args){
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("n = ");
		int n = input.nextInt();
		
		ArrayList<String> strings = new ArrayList<>(); 
		
		for (int i = 0; i <= n; i++) {
			strings.add(input.nextLine());
		}
		
		Arrays.toString(strings.toArray());
		Collections.sort(strings);
		
		for (String line : strings) {
			System.out.println(line);
		}
	}
}