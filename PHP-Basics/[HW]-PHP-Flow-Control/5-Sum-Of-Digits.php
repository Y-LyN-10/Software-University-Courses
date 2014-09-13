<!--Problem 5. Sum of Digits
	Write a PHP script SumOfDigits.php which receives a comma-separated list
	of integers from an input form and creates a two-column table. The first
	column should contain each of the values from the input. The second column
	should contain the sum of the digits of each value. If the value is not an
	integer number, print "I cannot sum that". Styling the page is optional. -->

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Sum Of Digits</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
	<form method="post">
		<label for="numbers">Input string:</label>
		<input type="text" name="numbers" id="numbers" required="true"/>
		<input type="submit" value="Sum"/>
	</form>
	<table>
		<?php
		$input_data = htmlentities($_POST["numbers"]);
		if (isset($input_data) && !empty($input_data)) {
			$numbers = preg_split('/[ ,]/', $input_data, 0, PREG_SPLIT_NO_EMPTY);
			foreach ($numbers as $number) {
				echo "<tr><td>$number</td><td>";
				if (ctype_digit($number)) {
					echo array_sum(str_split($number));
				} else {
					echo "<strong>Unsummable</strong> error"; // xD
				}
				echo "</td></tr>";
			}
		}
		?>
	</table>
</body>
</html>