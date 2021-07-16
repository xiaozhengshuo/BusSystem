CREATE DATABASE [BusMis] ON PRIMARY
(
	NAME='BusMis',
	FILENAME='D:\SQl server\BusMis.mdf',
	SIZE=10,
	MAXSIZE=unlimited,
	FILEGROWTH=5%
)
use BusMis

CREATE TABLE bus_User
(
	id  INT IDENTITY(1,1) NOT NULL PRIMARY KEY, --序号（主键）
	username VARCHAR(20) NOT NULL,--用户名
	pwd VARCHAR(50) NOT NULL,--密码
	role CHAR(20)NOT NULL,--角色
	name VARCHAR(20),
	phone varchar(50),	
	deleteflag CHAR(10) NOT NULL--删除标志，默认值0
)
CREATE TABLE bus_Message
(
	number INT NOT NULL PRIMARY KEY,
	line VARCHAR(MAX),
	deleteflag INT
)


