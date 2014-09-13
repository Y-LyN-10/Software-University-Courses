<!--Problem 1. Personal Info
    Write a PHP script PersonalInfo.php. Declare a few variables. The first variable should hold your
    first name, the second should hold your last name, the third - your age, and the last one should
    hold your full name (use concatenation). The result should be printed.  -->

<?php
//I've choose the underscore convention for writing php code.
$first_name = "Lucy";
$last_name = "Johansen";
$age = 27;
$full_name = $first_name . " " . $last_name;

echo "My name is $full_name and I am $age years old.";

?>