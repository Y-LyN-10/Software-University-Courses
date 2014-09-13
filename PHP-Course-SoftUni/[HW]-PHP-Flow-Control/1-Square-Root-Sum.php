<!--Problem 1. Square Root Sum
    Write a PHP script SquareRootSum.php that displays a table in your browser
    with 2 columns. The first column should contain a number (from 0 to 100) and
    the second column should contain the square root of that number, rounded to
    the second digit after the decimal point. The last row of the table should
    contain the sum of all values in the Square column. Styling the page is optional.  -->

<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="style.css"/>
</head>
<body>
<table>
    <tr><th>Number</th><th>Square Root</th></tr>
    <?php
    $sum = 0;
    for ($i = 0; $i <= 100; $i+=2) :
        $sqrt = sqrt($i);
        $sum += $sqrt;
        $sqrtRounded = round($sqrt, 2);
    ?>
        <tr>
            <td><?= $i ?></td>
            <td><?=$sqrtRounded ?></td>
        </tr>
    <?php endfor; ?>
    <tr>
        <td><strong>Total:</strong></td>
        <td><?=round($sum,2) ?></td>
    </tr>
</table>
</body>
</html>