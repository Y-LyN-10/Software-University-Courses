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

<form action="" method="post">
    Enter cars, separated by comma:
    <br>
    <input type="text" name="cars"/>
    <input type="submit" value="Show Result"/>
</form>

<?php
if (isset($_POST["cars"]) && !empty($_POST["cars"])) :
    $cars_list = $_POST["cars"];
    $cars = preg_split('/[ ,]+/', $cars_list); // Perl style regular expressions
    // Other variant - explode(",", $cars_list);
    // see regexr.com
    // preg_match_all("\\W*/", $car_list, $cars);
    ?>

    <table>
        <tr>
            <th>Car</th>
            <th>Color</th>
            <th>Count</th>
        </tr>

        <?php
        $colors = ["red", "yellow", "green", "blue", "orange", "black", "silver", "white", "purple"];

        foreach ($cars as $car_name) :
            $count = rand(1, 10);
            $rand_color = array_rand($colors);
            ?>
            <tr>
                <th><?= $car_name ?></th>
                <th><?= $colors[$rand_color] ?></th>
                <th><?= $count ?></th>
            </tr>

        <?php endforeach; ?>

    </table>
<?php endif; ?>
</body>
</html>