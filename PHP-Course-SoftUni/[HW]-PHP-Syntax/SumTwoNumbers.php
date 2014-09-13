<!--Problem 2. Sum Two Numbers
    Write a PHP script SumTwoNumbers.php that decleares two variables, firstNumber and secondNumber.
    They should hold integer or floating-point numbers (hard-coded values). Print their sum in the
    output in the format shown in the examples below. The numbers should be rounded to the second
    number after the decimal point. Find in Internet how to round a given number in PHP. -->

<?php
function sum_numbers($first_number, $second_number)
{
    return $first_number . " + " . $second_number . " = " . ($first_number + $second_number) . "\n";
}

echo sum_numbers(2, 5);
echo sum_numbers(1.567808, 0.356);
echo sum_numbers(1234.5678, 333);

?>