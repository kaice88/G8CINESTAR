CREATE DATABASE RAPPHIM_QL
GO

USE RAPPHIM_QL
GO

CREATE TABLE account (
	id_number int PRIMARY KEY,
	fullname char(30) NOT NULL,
	username char(30) NOT NULL,
	pwd char(30) NOT NULL,
	phone_number char(20) NOT NULL,
	email char(40) NOT NULL,
	admin_role int DEFAULT (0))
GO
