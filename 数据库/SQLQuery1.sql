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
	id  INT IDENTITY(1,1) NOT NULL PRIMARY KEY, --��ţ�������
	username VARCHAR(20) NOT NULL,--�û���
	pwd VARCHAR(50) NOT NULL,--����
	role CHAR(20)NOT NULL,--��ɫ
	name VARCHAR(20),
	phone varchar(50),	
	deleteflag CHAR(10) NOT NULL--ɾ����־��Ĭ��ֵ0
)
CREATE TABLE bus_Message
(
	number INT NOT NULL PRIMARY KEY,
	line VARCHAR(MAX),
	deleteflag INT
)


