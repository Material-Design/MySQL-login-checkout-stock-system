# MySQL-login-checkout-stock-system
Checkout system with MySQL login and stock management
Licensed under GNU GENERAL PUBLIC LICENSE

Tut:

1: Edit specified values inside project to get a successful MySQL connection / login

2: Upload and edit all specified files and values in /PHP/ (to edit your DB and view users)

3: Create the correct type of DB:
```sql
CREATE TABLE `auth` (
  `id` int(16) NOT NULL AUTO_INCREMENT,
  `user` varchar(4000) DEFAULT NULL,
  `pass` varchar(4000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
```
4: After compiling your project move all files from /Required text files/ to your executables directory 