<?php

	exec("./jumpcoind getblockcount", $output, $return_var);
	$test = json_encode($output);
	echo($test);
	if($test == '[]'){
		echo "ATTENTION";
		exec("./jumpcoind");
}
	else{
		echo "WALLET RUNNING!";
}
?>
