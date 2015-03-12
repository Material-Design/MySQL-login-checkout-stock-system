<?php
mysql_connect("HOST","USER","PASSWORD");
 #change DB to your database name
mysql_select_db("DB");
 #change TABLE to your table name
$sql_query="SELECT * FROM TABLE";
$result_set=mysql_query($sql_query);
$data = file_get_contents('http://YOUR-URL//view.php' . $_SERVER["REQUEST_URI"]); 
if(isset($_GET['delete_id']))
{			 		#change TABLE to your table name
	$sql_query="DELETE FROM TABLE WHERE id=".$_GET['delete_id'];
	mysql_query($sql_query);
}
?>
<head>
<a href ="http://YOUR-URL//index.php"><h3>Add users</h3></a>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="text/javascript">
function delete_id(id)
{
	if(confirm('Are you sure?'))
	{
		window.location.href='view.php?delete_id='+id;
    header('Refresh: 3;url=http://YOUR-URL/view.php');
	}
}
</script>
</head>
<body>
<div id="header">
	<div id="content">
    </div>
</div>
<div id="body">
	<div id="content">
    <table align="left">
    <tr>
    <th>Username</th>
    <th>Password</th>
    </tr>
    <?php
	if(mysql_num_rows($result_set)>0)
	{
		while($row=mysql_fetch_row($result_set))
		{
			?>
            <tr>
            <td><?php echo $row[1]; ?></td>
            <td><?php echo $row[2]; ?></td>
            <!--<td align="left"><a href="view.php?delete_id=<?php echo $row[0]; ?>"><img src="b_drop.png" alt="Delete" /></a></td>-->
            <td align="center"><a href="javascript:delete_id(<?php echo $row[0]; ?>)"><img src="b_drop.png" alt="Delete" /></a></td>
            </tr>
            <?php
		}
	}
	else
	{
		?>
        <tr>
        <th colspan="4">No data found !!!</th>
        </tr>
        <?php
	}
	?>
    </table>
    </div>
</div>
</body>
</html>