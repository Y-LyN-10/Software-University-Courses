<!--Problem 3.	Show Annual Expenses
	Write a PHP script AnnualExpenses.php that receives n years from an input HTML
	form and creates a table (like the one shown below) with random expenses by months
	and the corresponding years (n years back). For example, if N is 10, create a table
	that shows the expenses for each month for the last 10 years. Add a "Total" column
	at the end, showing the total expenses for the same year. The random expenses in the
	table should be in the range [0…999]. Styling the page is optional. -->

<?php
function getMonthName($number) {
	return date("F", strtotime(date("d-$number-Y")));
}
?>

<!DOCTYPE html>
<html>
<head>
	<title>Show Annual Expences</title>
</head>
<body>
	<form method="post">
<label for="costs">Enter number of years:</label>
<input type="text" name="costs" id="costs"/>
<input type="submit" value="Show costs"/>
</form>
<p></p>

<?php
if (isset($_POST["costs"]) && !empty($_POST["costs"])):
	$years = $_POST["costs"];
	$currentYear = date("Y");
?>

<table border="1"><thead><tr><th>Year</th>

<?php
for ($month = 1; $month <= 12; $month++) {
	echo "<th>" . getMonthName($month) . "</th>";
}
?>

<th>Total:</th></tr></thead><tbody>

<?php
for ($year = $currentYear; $year > $currentYear - $years; $year--) {
	echo "<tr><td>$year</td>";
	$total = 0;

	for ($month = 1; $month <= 12; $month++) {
		$currentCost = rand(0, 999);
		echo "<td>" . $currentCost . "</td>";
		$total += $currentCost;
	}

	echo "<td>$total</td></tr>";
}
?>

</tbody>
</table>
<?php endif; ?>
</body>
</html>