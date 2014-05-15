import javax.swing.JOptionPane;

public class _06_SumTwoNumbers_Graphic {

	public static void main(String[] args) {
		
		String a = JOptionPane.showInputDialog("Enter first number");
		String b = JOptionPane.showInputDialog("Enter second number");

		int firstNum = Integer.parseInt(a);
		int secondNum = Integer.parseInt(b);
		int sum = firstNum + secondNum;
		
		JOptionPane.showMessageDialog(null, "The sum is: " + sum, "Problem 6. Sum two numbers", JOptionPane.PLAIN_MESSAGE);
	}
}