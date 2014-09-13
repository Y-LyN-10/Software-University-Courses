<!-- Problem 3. Calculate Interest
	Write a PHP script CalculateInterest.php which generates an 
	HTML page that contains:
	- An input text field to hold the amount of money
	- Radio buttons to choose the currency
	- An input text field to enter the compound annual interest amount
	- A dropdown menu to choose the period of time. 
	- A submit button. When the information is submitted, the script 
	should print out the amount of money you will have after the selected 
	period, rounded to 2 decimal places. Semantic HTML is required. 
	Styling is not required. 

	After the 6th month we have 1061.520150601 USD in our account. We round 
	the result and add the symbol "$" for USD. The output is $ 1061.52. -->

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8"/>
    <title>Calculate Interest</title>
</head>
<body>
<form method="post">
    <label for="amount">Enter Amount</label>
    <input type="text" name="amount" id="amount"/><br/>
    <input type="radio" name="currency" value="USD" id="usd"/>
    <label for="usd">USD</label>
    <input type="radio" name="currency" value="EUR" id="eur"/>
    <label for="eur">EUR</label>
    <input type="radio" name="currency" value="BGN" id="bgn"/>
    <label for="bgn">BGN</label>
    <br/>
    <label for="interest">Compount Interest Amount</label>
    <input name="interest" id="interest"/><br/>
    <select name="period-months">
        <option value="6">6 Months</option>
        <option value="12">1 Year</option>
        <option value="24">2 Years</option>
        <option value="60">5 Years</option>
    </select>
    <input type="submit" name="submit" value="Calculate">

<?php 

// ==================================================================
//
// Solution in PHP
//
// ------------------------------------------------------------------

if ($_POST && isset($_POST["submit"])) {
	//TODO: add checks for empty input and extract validation in external function.
    if (isset($_POST["amount"]) && 
    	isset($_POST["currency"]) && 
    	isset($_POST["interest"]) && 
    	isset($_POST["period-months"])) {

        $amount = $_POST["amount"];
        $currency = $_POST["currency"];
        $interest = $_POST["interest"];
        $period_in_months = $_POST["period-months"];

        if (is_numeric($amount) && 
        	is_numeric($interest) && 
        	is_numeric($period_in_months)) {

            if ($interest > 0 && $interest <= 100) {

                $number_of_years = $period_in_months / 12;
                $end_value = $amount * pow(1 + ($interest / 100) / 12, 12 * $number_of_years);
                
                echo format_currency($end_value, $currency);
            } else {
                echo "Invalid interest rate. It should be a number between 0 and 100.";
            }
        } else {
            echo "The data you entered is invalid.";
        }
    } else {
        echo "You have not filled in all required fields.";
    }
}

function format_currency($amount, $currency)
{
    $rounded_amount = round($amount, 2);
    switch ($currency) {
        case "USD":
            return "$" . $rounded_amount;
        case "EUR":
            return "€" . $rounded_amount;
        case "BGN":
            return $rounded_amount . " лв.";
        default:	
            return $rounded_amount;
    }
} 

// ==================================================================
//
// End of Solution
//
// ------------------------------------------------------------------

?>

</form>
</body>
</html>
