<!--Problem 1. Print Tags
    Write a PHP script PrintTags.php which generates an HTML input 
    text field and a submit button. In the text field the user must 
    enter different tags, separated by a comma and a space (", "). 
    When the information is submitted, the script should split the tags, 
    put them in an array and print out the array. Semantic HTML is required. Styling is not required. -->

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Print Tags</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
    <?php
    if ($_POST && isset($_POST["submit"])) {
        $tags_string = $_POST["tags"];
        $tags = preg_split('/[ ,]+/', $tags_string);
        echo "<div id=\"result\">";
        foreach ($tags as $key => $value) {
            echo $key . " : " . $value . "<br />";
        }

        echo "</div>";
    }
    ?>
</form>
</body>
</html>
