<!--Problem 3. Dump Variable
    Write a PHP script DumpVariable.php that declares a variable.
    If the variable is numeric, print it by the built-in function var_dump().
    If the variable is not numeric, print its type at the input.  -->

<?php
$variables = ["hello", 15, 1.234, array(1, 2, 3), (object)[2, 34]];

foreach ($variables as $key => $value) {
    if (is_numeric($value)) {
        var_dump($value);
    } else {
        echo gettype($value) . "\n";
    };
}
?>