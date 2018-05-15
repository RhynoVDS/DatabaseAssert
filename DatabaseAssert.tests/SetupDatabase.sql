use master

IF EXISTS(select * from sys.databases where name='test') 
	drop database test

create database test

/*use test

create table test(
Column1 INT
)
*/
