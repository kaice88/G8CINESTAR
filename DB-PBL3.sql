
CREATE DATABASE RAPPHIM_QL
GO
USE RAPPHIM_QL
GO

CREATE TABLE TBStaff (
	id_number int IDENTITY(1000,1) PRIMARY KEY,
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
	seat_type_id int IDENTITY(1000,1) PRIMARY KEY,
	seat_type char(10) NOT NULL,
	seat_type_price_percent int not null,
	seat_type_color int not null)
GO

create table TBRoomType(
	room_type_id int IDENTITY(1000,1) PRIMARY KEY,
	room_type char(40) NOT NULL,
	room_type_price_percent int not null
)
go
CREATE TABLE TBMovieGenres (
	movie_genres_id int IDENTITY(1000,1) PRIMARY KEY,
	movie_genres char(40) NOT NULL)
GO
CREATE TABLE TBCustomer (
	customer_id int IDENTITY(1000,1) PRIMARY KEY,
	customer_name char(40) NOT NULL,
	customer_birthday Date NOT NULL,
	customer_address char(100) NOT NULL,
	customer_phone_number char(20) NOT NULL,
	customer_accumulated_reward_points int default 0 
	)
GO
------------------------------------------------------------
--cos foreign key

use RAPPHIM_QL
drop table TBBooking,TBReceipt

use RAPPHIM_QL
CREATE table TBRoom(
	room_id int IDENTITY(1000,1) PRIMARY KEY,
	room_name char(40) NOT NULL,

	room_type_id int NULL FOREIGN KEY REFERENCES TBRoomType(room_type_id)
	ON DELETE set null ON UPDATE CASCADE,
	room_type_name char(40) NOT NULL,

	room_number_of_seat int default 0 not null,
	room_number_of_row int default 0 not null,
)
go
use RAPPHIM_QL
CREATE TABLE TBMovie (
	movie_id int IDENTITY(1000,1) PRIMARY KEY,
	movie_name char(40) NOT NULL,
	movie_genres_id int NULL,
	movie_description char(1000) NOT NULL,
	movie_length int NOT NULL,
	movie_release Date NOT NULL,
	movie_image image,
	movie_price int not null,
	constraint fk_id_movie_type FOREIGN KEY (movie_genres_id) REFERENCES TBMovieGenres(movie_genres_id)
	on delete set null on update cascade
	)
GO
use RAPPHIM_QL
create table TBSeat(-- khong copy vi khong anh huong chi het
	seat_id int identity(1000,1) primary key,
	seat_type_id int null, 
	room_id int not null,
	seat_name char(10) not null,
	constraint fk_id_seat_type foreign key (seat_type_id) references TBSeatType(seat_type_id)
	on delete set null on update cascade,
	constraint fk_seat_id_room foreign key (room_id) references TBRoom(room_id)
	on delete cascade on update cascade
)
GO
use RAPPHIM_QL
CREATE TABLE TBSchedule (
	schedule_id int IDENTITY(1000,1) PRIMARY KEY,
	schedule_date date NOT NULL,

	movie_id int NULL,
	movie_name char(40) not null,
	room_id int NULL,
	room_name char(40) not null,

	schedule_start time NOT NULL,
	schedule_end time NOT NULL,
	constraint fk_id_movie FOREIGN KEY (movie_id ) REFERENCES TBMovie(movie_id)
	on delete set null on update cascade,
	constraint fk_schedule_id_room FOREIGN KEY (room_id) REFERENCES TBRoom(room_id)
	on delete set null on update cascade)
GO

use RAPPHIM_QL
create table TBSeatBooking(-- co room trong cai schedule
	seat_booking_id int identity(1000,1) primary key,
	room_id int not null, ----- 
	schedule_id int not null,
	seat_booking_name char(10) not null,
	seat_status bit default 0 not null,
	constraint fk_seat_id_schedule foreign key (schedule_id) references TBSchedule(schedule_id)
	on delete cascade on update cascade,
)

use RAPPHIM_QL
CREATE TABLE TBReceipt ( -- hoa don
	receipt_id int IDENTITY(1000,1) PRIMARY KEY,
	customer_name char(40) NOT NULL,
	fullname char(40) NOT NULL,
	number_of_tickets int NOT NULL,
	total_price int NOT NULL,
	date_booking date not null,
	cancellation_charges int default 0 not null
	)

use RAPPHIM_QL
update TBSeatBooking set seat_status = 0 

use RAPPHIM_QL
CREATE TABLE TBBooking ( -- ve
	booking_id INT IDENTITY(1000,1) PRIMARY KEY,
	receipt_id int not null,-- ve ko the xoa nen van de not null, ten nv, ten kh co trong bang receipt roi ne cu reference qua
	seat_booking_name char(10) not null,
	schedule_date date NOT NULL,
	movie_name char(40) not null,
	room_name char(10) not null,
	schedule_start time NOT NULL,

	booking_status bit default 1 not null,-- huy hay chua
	booking_price int NOT NULL,
	constraint fk_id_receipt FOREIGN KEY (receipt_id) REFERENCES TBReceipt(receipt_id)
)	

use RAPPHIM_QL
CREATE TABLE TBPayment(
	payment_id INT IDENTITY(1000,1) PRIMARY KEY,
	receipt_id int NOT NULL,
	fullname char(40) NOT NULL,
	number_of_ticket int not null,
	payment_price int NOT NULL,
	date_payment date not null,
	constraint fk_receipt_id FOREIGN KEY (receipt_id) REFERENCES TBReceipt(receipt_id)
)


INSERT INTO TBMovieGenres(movie_genres)VALUES('Documentary')
INSERT INTO TBMovieGenres(movie_genres)VALUES('Cartoon')

use RAPPHIM_QL
INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Seventeen power of love: The movie',1000,'Do not miss Seventeen Power of Love: The Movie with powerful performances and share words from the past to the present, as well as future plans that 13 boys want to send to Carat will first be secreted Reveal in intensive interviews!', '115', '2022-04-20',60000)
INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Space Dogs: Return to Earth',1001,'Do not miss Seventeen Power of Love: The Movie with powerful performances and share words from the past to the present, as well as future plans that 13 boys want to send to Carat will first be secreted Reveal in intensive interviews!', '80', '2022-04-22',50000)
INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Chickenhare',1002,'The film follows adventures of Chickenhare, the young hero was born half a half-chicken rabbit, adopted by King Peter - a famous forest rabbit explorer.', '120', '2022-04-29',70000)




where TBReceipt.receipt_id = 1003
SELECT  TBBooking.movie_name, TBBooking.room_name, TBBooking.seat_booking_name, TBBooking.schedule_date, TBBooking.schedule_start, TBBooking.booking_price, TBReceipt.receipt_id, TBReceipt.fullname, TBReceipt.customer_name, TBReceipt.number_of_tickets, TBReceipt.total_price, TBReceipt.date_booking, TBBooking.booking_id, TBBooking.booking_status " +
                "FROM  TBBooking INNER JOIN  TBReceipt ON TBBooking.receipt_id = TBReceipt.receipt_id where TBReceipt.receipt_id = 1003