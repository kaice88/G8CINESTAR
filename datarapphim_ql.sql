CREATE DATABASE RAPPHIM_QL
GO

CREATE TABLE TBStaff (
	id_number int IDENTITY PRIMARY KEY,
	fullname char(30) NOT NULL,
	username char(30) NOT NULL,
	pwd char(30) NOT NULL,
	phone_number char(20) NOT NULL,
	email char(40) NOT NULL,
	role bit default 1 not null,
	changepwd bit default 1 not null
)
GO
CREATE TABLE TBSeatType (
	seat_type_id int IDENTITY PRIMARY KEY,
	seat_type char(10) NOT NULL,
	seat_price int NOT NULL)
GO


create table TBRoomType(
	room_type_id int IDENTITY PRIMARY KEY,
	room_type char(40) NOT NULL,
	room_type_surcharge int not null
)
go
CREATE table TBRoom(
	room_id int IDENTITY PRIMARY KEY,
	room_name char(40) NOT NULL,
	room_type_id int NOT NULL FOREIGN KEY REFERENCES TBRoomType(room_type_id)
)
go

CREATE TABLE TBStaff (
	id_number int IDENTITY PRIMARY KEY,
	fullname char(30) NOT NULL,
	username char(30) NOT NULL,
	pwd char(30) NOT NULL,
	phone_number char(20) NOT NULL,
	email char(40) NOT NULL,
	role bit default 1 not null)
GO
create table TBSeat(
	seat_id int identity primary key,
	seat_type_id int not null, 
	room_id int not null,
	seat_row char(1) not null,
	seat_number char(2) not null,
	seat_stattus int not null,
	constraint fk_id_seat_type foreign key (seat_type_id) references TBSeatType(seat_type_id),
	constraint fk_seat_id_room foreign key (room_id) references TBRoom(room_id),
)
GO
CREATE TABLE TBMovie (
	movie_id int IDENTITY PRIMARY KEY,
	movie_name char(40) NOT NULL,
	movie_genres char(30) NOT NULL,
	movie_description char(200) NOT NULL,
	movie_length int NOT NULL,
	movie_release Date NOT NULL)
GO





