<!--Problem 4. Non-Repeating Digits
    Write a PHP script NonRepeatingDigits.php that declares an integer variable N,
    and then finds all 3-digit numbers that are less or equal than N (<= N) and
    consist of unique digits. Print "no" if no such numbers exist. -->

<?php
function find_non_repeating_digits($max)
{
    $numbers = array();

    for ($i = 102; $i <= min($max, 987); $i++) {
        $current_number = strval($i);
        if ($current_number[0] != $current_number[1] &&
            $current_number[1] != $current_number[2] &&
            $current_number[0] != $current_number[2]) {
            $numbers[]=$i;
        }
    }

    return ($numbers ? implode(", ", $numbers) : "no") . "\n";
}

echo find_non_repeating_digits(1234);
echo find_non_repeating_digits(145);
echo find_non_repeating_digits(15);
echo find_non_repeating_digits(247);