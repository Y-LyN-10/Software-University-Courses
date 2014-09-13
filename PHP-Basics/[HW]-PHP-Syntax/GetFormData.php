<!--Problem 7. Form Data
    Write a PHP script GetFormData.php which retrieves the input data from an HTML form,
    and displays it as string. The input fields should hold name, age and gender (radio buttons).
    The returned string should be a message containing the information submitted by the form.
    100% accuracy is NOT required. Semantic HTML is required.  -->

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <title>Form Data</title>
</head>
<body>
<form action="#" method="POST">
    <input type="text" name="name" id="name" placeholder="Name"/><br/>
    <input type="text" name="age" id="age" placeholder="Age"/><br/>
    <input type="radio" name="sex" value="male">Male<br/>
    <input type="radio" name="sex" value="female">Female<br/>
    <input type="submit" value="Изпращане"/><br />
    <?php
        if ($_POST && isset($_POST["name"]) && isset($_POST["age"]) && isset($_POST["gender"])) {
            echo "My name is " . $_POST["name"] . ". I am " . $_POST["age"] . " years old. I am " . $_POST["gender"] . ".";
        }
    ?>
</form>
</body>
</html>