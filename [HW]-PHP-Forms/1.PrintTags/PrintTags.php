<!DOCTYPE html>
<html>
<head>
    <title>Print Tags</title>
</head>
<body>
<form method="post">
    <label for="tags">Enter tags:</label><br/>
    <input type="text" name="tags" id="tags"/>
    <input type="submit" name="submit"><br/><br/>
    <?=print_tags();?>
</form>
</body>
</html>

<?php
//TODO: Write a regex to remove all empty entries and non-alphanumeric symnols.
function print_tags(){
    if ($_POST && isset($_POST["submit"])) {
        $tags = explode(", ", $_POST["tags"]);
        echo "<div id=\"result\">";
        foreach ($tags as $key => $value) {
            echo $key . " : " . $value . "<br />";
        }
        echo "</div>";
    }
}
?>