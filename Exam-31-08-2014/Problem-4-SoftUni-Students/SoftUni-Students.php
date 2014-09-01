<?php

// just test
$students_string = htmlspecialchars($_GET['students']);
$column = $_GET['column'];
$order = $_GET['order'];

$students_data = preg_split ('/$\R?^/m', $students_string, 0, PREG_SPLIT_NO_EMPTY);
$students_table = [];

$table_result = "<table><thead><tr><th>Id</th><th>Username</th><th>Email</th><th>Type</th><th>Result</th></tr></thead>";
$id = -1;

foreach ($students_data as $student_data) {
	$current_student = preg_split('/[\,]+/', $student_data, -1, PREG_SPLIT_NO_EMPTY);
	$id += 1;
	$name = trim($current_student[0]);
	$email = trim($current_student[1]);
	$type = trim($current_student[2]);
	$result = trim($current_student[3]);

	$students_table[$id][$name][$result] = [$email, $type];

}

if ($order == 'descending') {
	krsort($students_table);
} else {
	ksort($students_table);
}

// print_r($students_table);

foreach ($students_table as $id => $name) {
	$table_result .= "<tr><td>".$id."</td>";
	foreach ($name as $name => $results) {
		$table_result .= "<td>".$name."</td>";
		foreach ($results as $points => $others) {
			$table_result .= "<td>".$others[0]."</td><td>".$others[1]."</td><td>".$points."</td></tr>";
		}
	}
}

$table_result .= "</table>";
echo $table_result;

// Not sorted - result: 0/100 points
?>