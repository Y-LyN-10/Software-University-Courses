import java.util.Scanner;

public class _01_RectangleArea {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)){
		
			int a = input.nextInt();
			int b = input.nextInt();
			
			input.nextLine();
			
			int area = a * b;
		
			System.out.println(area);
		}	
	}
}
