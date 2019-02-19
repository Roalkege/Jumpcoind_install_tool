sudo apt-get install php -y
sudo apt-get install cron -y

cat >/root/jumpcoin_check.php << EOF
<?php

	exec("./jumpcoind getblockcount", $output, $return_var);
	$test = json_encode($output);
	echo($test);
	if($test == '[]'){
		echo "WALLET NOT RUNNING";
		exec("./jumpcoind");
}
	else{
		echo "WALLET RUNNING!";
}
?>
EOF

crontab -l | { cat; echo "*/5 * * * * php /root/jumpcoin_check.php"; } | crontab -
