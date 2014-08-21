<!--Problem 4. HTML Tags Counter
    Write a PHP script HTMLTagsCounter.php which generates an HTML form 
    like in the example below. It should contain a label, an input text 
    field and a submit button. The user enters HTML tag in the input 
    field. If the tag is valid, the script should print “Valid HTML tag!”, and if it is invalid – “Invalid HTML Tag!”. On the second line, there should be a score counter. For every valid tag entered, the score should increase by 1.
    Hint: You may use sessions. Use an array to store all valid HTML5 tags. -->

<?php session_start();?>

<!DOCTYPE html>
<html>
<head>
    <title>HTML Tags Counter</title>
    <style type="text/css">
        .info {
            font-size: 20px;
            font-weight: bold;
        }
    </style>
</head>
<body>
<form method="post">
    <label for="tag">Enter HTML tags:</label><br/><br/>
    <input type="text" name="tag" id="tag"/>
    <input type="submit" name="submit"><br/><br/>

<?php
    
// ==================================================================
//
// All HTML Tags Counter
//
// ------------------------------------------------------------------

$tags = array("a", "abbr", "address", "area", "article", "aside", "audio", "b", "base", "bdi", "bdo", "blockquote", "body", "br", "button", "canvas", "caption",
        "cite", "code", "col", "colgroup", "command", "datalist", "dd", "del", "details", "dfn", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure",
        "footer", "form", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins", "kbd", "keygen", "label",
        "legend", "li", "link", "map", "mark", "menu", "meta", "meter", "nav", "noscript", "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress",
        "q", "rp", "rt", "ruby", "s", "samp", "script", "section", "select", "small", "source", "span", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td",
        "textarea", "tfoot", "th", "thead", "time", "title", "tr", "track", "u", "ul", "var", "video", "wbr");

if (!isset($_SESSION["score"]) || 
    !isset($_SESSION["remaining-tags"])) {

        $_SESSION["score"] = 0;
        $_SESSION["remaining-tags"] = $tags;
}

if ($_POST && isset($_POST["submit"])) {
    $tag = mb_strtolower(trim($_POST["tag"]));

    if (array_search($tag, $tags) === false) {
        echo "<div class=\"info\">Invalid HTML tag!</div>";
    } else {
        echo "<div class=\"info\">Valid HTML tag!</div>";
        if (array_search($tag, $_SESSION["remaining-tags"]) !== false) {
            $_SESSION["score"]++;
            $key = array_search($tag, $tags);
            unset($_SESSION["remaining-tags"][$key]);
        }
    }
}
echo "<div class=\"info\">Score: " . $_SESSION["score"] . "</div>";
if ($_SESSION["score"] == count($tags)) {
    echo "<div class=\"info\">Congratulations, HTML Ninja! You won!</div>";
}

// ========================================================================
//
// End - And yeah, I know it's a big big mess. I don't like PHP
//
// ------------------------------------------------------------------------

?>
</form>
</body>
</html>