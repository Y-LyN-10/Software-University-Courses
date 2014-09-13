<!--Problem 6. HTML Table
    Write a PHP script InformationTable.php which generates an HTML table by given
    information about a person (name, phone number, age, address). Styling the table
    is optional. Semantic HTML is required. -->

<!DOCTYPE html>
<html>
<head>
    <title>Table</title>
    <style type="text/css">
        table {
            border-collapse: collapse;
        }

        table tr td {
            border: 1px solid black;
            padding: 5px;
        }

        td:first-child {
            background-color: orange;
            font-weight: bold;
            width: 110px;
        }

        td:last-child {
            text-align: right;
            width: 100px;
        }
    </style>
</head>
<body>
<?php display_table($names[0], $phone_numbers[0], $ages[0], $addresses[0]) ?> <br/>
<?php display_table($names[1], $phone_numbers[1], $ages[1], $addresses[1]) ?>
</body>
</html>

<?php
$names = array("Lucy", "George", "Fred");
$phone_numbers = array("0123-456-789", "0897-777-777", "0038-2-485-945");
$ages = array(27, 35, 49);
$addresses = array("Sofia", "Pravec", "London");

function display_table($name, $phone_number, $age, $address)
{
    echo "<table><tbody>";
    add_row("Name", $name);
    add_row("Phone number", $phone_number);
    add_row("Age", $age);
    add_row("Address", $address);
    echo "</tbody></table>";
}

function add_row($key, $value)
{
    echo "<tr><td>" . $key . "</td><td>" . $value . "</td></tr>";
}

?>
