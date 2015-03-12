<?php
$con = mysql_connect("HOST","USER","PASSWORD");
if (!$con)
  {
  die('Could not connect: ' . mysql_error());
  }
 #change DB to your database name
mysql_select_db("DB", $con);
 #change TABLE to your table name
$sql="INSERT INTO TABLE (user, pass)
VALUES
('$_POST[user]','$_POST[pass]')";
if (!mysql_query($sql,$con))
  {
  die('Error: ' . mysql_error());
  }
echo "Username and password added to database";
mysql_close($con)
?>
<a href ="http://YOUR-URL/index.php"><h3>Add users</h3></a>
<meta http-equiv="refresh" content="3; url=http://YOUR-URL/index.php>
</body>
</html>