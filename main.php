<?php
$list = [];
for($i = 0; $i < 100; ++$i){
	array_push($list, $i);
}
foreach($list as $i){
	echo $i."\n";
}
?>