
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
use RAPPHIM_QL
insert into TBBooking(receipt_id,seat_booking_name,schedule_date,movie_name,room_name,schedule_start,booking_price) 
select TBReceipt.receipt_id, TBSeatBooking.seat_booking_name, schedule_date, TBMovie.movie_name, TBRoom.room_name, schedule_start,78000
from TBReceipt, (TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id inner join TBSeatBooking on TBRoom.room_id = TBSeatBooking.room_id inner join tbmovie on TBMovie.movie_id = TBSchedule.movie_id)
where TBSchedule.schedule_id = 1002 and TBSeatBooking.seat_booking_id = 1166 and TBReceipt.receipt_id = 1022

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
--drop table TBBooking,TBPayment,TBReceipt,TBSeatBooking,TBSchedule,TBSeat,TBMovie,TBRoom


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

create table TBSeatBooking(-- co room trong cai schedule
	seat_booking_id int identity(1000,1) primary key,
	room_id int not null, ----- 
	schedule_id int not null,
	seat_booking_name char(10) not null,
	seat_status bit default 0 not null,
	constraint fk_seat_id_schedule foreign key (schedule_id) references TBSchedule(schedule_id)
	on delete cascade on update cascade,
)

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
CREATE TABLE TBPayment(
	payment_id INT IDENTITY(1000,1) PRIMARY KEY,
	receipt_id int NOT NULL,
	fullname char(40) NOT NULL,
	number_of_ticket int not null,
	payment_price int NOT NULL,
	date_payment date not null,
	constraint fk_receipt_id FOREIGN KEY (receipt_id) REFERENCES TBReceipt(receipt_id)
)
use RAPPHIM_QL
INSERT INTO TBSeatBooking (schedule_id,room_id,seat_booking_name) 
SELECT TBSchedule.schedule_id, tbroom.room_id, TBSeat.seat_name 
FROM TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id inner join TBSeat on TBSeat.room_id =TBRoom.room_id
WHERE TBSchedule.schedule_id = 1008

use RAPPHIM_QL
update TBCustomer set customer_accumulated_reward_points += 10 where customer_id = 1000
SELECT TBPayment.payment_id, TBPayment.receipt_id, TBPayment.fullname, TBPayment.number_of_ticket, TBPayment.payment_price, TBPayment.date_payment, TBReceipt.customer_name, TBReceipt.cancellation_charges, 
TBBooking.booking_id, TBBooking.seat_booking_name, TBBooking.schedule_date, TBBooking.movie_name, TBBooking.room_name, TBBooking.schedule_start, TBBooking.booking_price FROM  TBBooking INNER JOIN TBReceipt ON TBBooking.receipt_id = TBReceipt.receipt_id INNER JOIN 
TBPayment ON TBReceipt.receipt_id = TBPayment.receipt_id WHERE TBReceipt.receipt_id = 1046 and TBBooking.booking_status = 0
select fullname , count(fullname) as "amount", sum(booking_price) as "total" from TBBooking inner join TBReceipt 
on TBBooking.receipt_id = TBReceipt.receipt_id where MONTH(TBReceipt.date_booking) = '6' and YEAR(TBReceipt.date_booking) = '2021' and booking_status = 1
group by fullname
order by total DESC 

use RAPPHIM_QL
select seat_type_price_percent from TBSeatType where seat_type_color = -16711936
select room_type_price_percent from tbroomtype inner join tbroom on tbroom.room_type_id = TBRoomType.room_type_id inner join TBSchedule on tbroom.room_id = TBSchedule.room_id where TBSchedule.schedule_id = 1000
select movie_price from TBMovie inner join TBSchedule on TBMovie.movie_id = TBSchedule.movie_id where TBSchedule.schedule_id = 1000
INSERT INTO TBSeatBooking (schedule_id,room_id,seat_booking_name) SELECT TBSchedule.schedule_id, tbroom.room_id, TBSeat.seat_name FROM TBSchedule,TBRoom, TBSeat 
WHERE TBSchedule.schedule_id = 1003
select DISTINCT seat_type_color from TBSeatBooking inner join TBRoom on TBSeatBooking.room_id = TBRoom.room_id inner join TBSeat on TBRoom.room_id = TBSeat.room_id inner join TBSeatType on TBSeat.seat_type_id = TBSeatType.seat_type_id
where seat_name ='A1' and schedule_id = 1000
select DISTINCT seat_type_color from TBSeatType inner join tbseat on TBSeatType.seat_type_id  = TBSeat.seat_type_id inner join TBRoom on TBRoom.room_id = TBSeat.room_id inner join TBSeatBooking on TBSeatBooking.room_id = TBRoom.room_id
where seat_booking_name ='A1' and schedule_id = 1000
use RAPPHIM_QL
select * from tbroom
INSERT INTO TBSeatBooking (room_id,schedule_id) SELECT TBSchedule.schedule_id, tbroom.room_id FROM TBSchedule,TBRoom WHERE TBSchedule.schedule_id = 1000
use RAPPHIM_QL
insert into TBReceipt (customer_name,fullname,number_of_tickets,total_price,date_booking) values()
use RAPPHIM_QL
alter table TBReceipt
drop column receipt_status
use RAPPHIM_QL
INSERT INTO TBSeatBooking (room_id,schedule_id) SELECT TBSchedule.schedule_id, tbroom.room_id FROM TBSchedule,TBRoom WHERE TBSchedule.schedule_id =" + schedule_id
select DISTINCT seat_type_color from TBSeatBooking where seat_booking_name = '" + seat_name + "' and schedule_id = " + Schedule_id
select distinct * from tbroom inner join TBSchedule on TBRoom.room_id = TBSchedule.room_id and schedule_id =1000

use RAPPHIM_QL
select payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment, count (TBBooking.booking_status) as \"amount\" from TBReceipt, TBPayment, TBBooking where TBPayment.receipt_id = " + Receipt_Id + " and TBBooking.receipt_id = TBPayment.receipt_id and TBBooking.booking_status = 0
update tbseatbooking set seat_status = 'False' where seat_booking_id in 
(select seat_booking_id from TBSeatBooking inner join TBSchedule on TBSchedule.schedule_id = TBSeatBooking.schedule_id inner join TBRoom on TBRoom.room_id = TBSchedule.room_id inner join TBMovie on tbmovie.movie_id = TBSchedule.movie_id 
where schedule_date = '2022-06-15' and schedule_start = '10:48' and TBMovie.movie_name = 'Seventeen power of love: The movie' and TBRoom.room_name = 'R1' and seat_status = 1 and  TBSeatBooking.seat_booking_name = 'A1')

select booking_id from TBBooking where booking_status = 0 and receipt_id = 
select booking_id,TBReceipt.fullname,TBReceipt.customer_name,TBReceipt.date_booking,movie_name,seat_booking_name,schedule_date,schedule_start,room_name,booking_price 
from TBBooking, TBReceipt where  TBBooking.receipt_id = TBReceipt.receipt_id and TBReceipt.receipt_id = 1001
insert into TBBooking(receipt_id,seat_booking_name,schedule_date,movie_name,room_name,schedule_start,booking_price)
select TBReceipt.receipt_id,TBSeatBooking.seat_booking_name,schedule_date,TBMovie.movie_name,TBRoom.room_name,schedule_start, 1000 
from TBReceipt,(TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id inner join TBSeatBooking on TBRoom.room_id = TBSeatBooking.room_id inner join tbmovie on TBMovie.movie_id = TBSchedule.movie_id)
where TBSchedule.schedule_id = 1001 and TBSeatBooking.seat_booking_id = 1123 and TBReceipt.receipt_id = 1000 
GO

use RAPPHIM_QL
select payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment,count (TBBooking.booking_status) as "amount"  from TBReceipt, TBPayment,tbbooking
where TBPayment.receipt_id = 1001 and TBReceipt.receipt_id = TBPayment.receipt_id and tbbooking.receipt_id = TBReceipt.receipt_id and booking_status = 0
group by payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment
use RAPPHIM_QL
select payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment, count (TBBooking.booking_status) as "amount" from TBReceipt, TBPayment, TBBooking where TBPayment.receipt_id = 1000 and TBBooking.receipt_id = TBPayment.receipt_id and TBBooking.booking_status = 0

select schedule_id from ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id) 
where TBSchedule.movie_id = '" + id + "' and TBRoomType.room_type = '" + room_type +"' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' and schedule_start = '" + time_start + "'
select schedule_start from TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id
where movie_id = 1000 and TBRoomType.room_type = '3D' and schedule_date = '2022-06-15' and schedule_start >= '13:00' order by schedule_start
select schedule_start from TBSchedule where movie_id = " + id + " and room_type = '" + room_type + 
                    "' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' and schedule_start >= '" +
                (DateTime.Now.AddMinutes(-30)).ToString("HH: mm") +"' order by schedule_start
select distinct room_type from (TBRoomType inner join TBRoom on TBRoom.room_type_id = TBRoomType.room_type_id) inner join TBSchedule on TBSchedule.room_id = TBRoom.room_id
where TBSchedule.movie_id = 1000 and TBSchedule.schedule_date = '2022-06-15'
select distinct room_type from TBSchedule where TBSchedule.movie_id=  " + id + " and TBSchedule.schedule_date = '" + date + "' order by room_type
select TBSchedule.schedule_id from  TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id " +
where TBRoom.room_id = "+room_id+ " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))"
SELECT room_type_id, room_type_price_percent FROM TBRoomType WHERE room_type ='2D'
Insert into TBRoom(room_name,room_type_id,room_type_name) values('" + room.room_name + "'," + room.room_type_id + ",'" + room.room_type_name + "')
select TBSchedule.schedule_id from  ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBRoomType on tbroom.room_type_id = TBRoomType.room_type_id)
where tbroom.room_type_id = " + room_type_id + " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))
select distinct schedule_id from ((TBSchedule  inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBRoomType on TBRoomType.room_type_id = TBRoom.room_type_id)
where TBSchedule.movie_id = '" + id + "' and TBRoomType.room_type = '" + room_type +"' and schedule_date = '" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "' and schedule_start = '" + time_start + "'
select count (schedule_id) as "amount" 
from TBSchedule where room_id = '" + schedule.room_id + "' and schedule_date = '" + schedule.schedule_date +'
and (('" + schedule.schedule_start + "' between schedule_start and schedule_end) or ('" + schedule.schedule_end + "' between schedule_start and schedule_end)
or (schedule_start between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "') or (schedule_end between '" + schedule.schedule_start + "' and '" + schedule.schedule_end + "'))
                            + " and schedule_id != " + schedule.schedule_id
select TBSchedule.schedule_id from  ((TBSchedule inner join TBRoom on TBRoom.room_id = TBSchedule.room_id) inner join TBSeat on tbseat.room_id = TBRoom.room_id) inner join TBSeatType on TBSeatType.seat_type_id = TBSeat.seat_type_id
where TBSeatType.seat_type_id = " + seat_type_id + " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))
select TBSchedule.schedule_id from TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id
where TBRoom.room_id = "+room_id+ " and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))
select TBSchedule.schedule_id from TBSchedule where movie_id = 1000
and(schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))
UPDATE TBSeatBooking  SET seat_type = t.seat_type,seat_type_price_percent = t.seat_type_price_percent,seat_type_color = t.seat_type_color
FROM TBSeatType t WHERE TBSeatBooking.seat_type_id = t.seat_type_id and TBSeatBooking.seat_type_id = 1000 and TBSeatBooking.
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres,TBMovie.movie_length,TBMovie.movie_release,movie_image AS [movie_image] from TBMovie left join TBMovieGenres 
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
where TBMovie.movie_release <= '2022-06-01' and TBMovie.movie_id in
(select distinct movie_id from TBSchedule where (schedule_date > '2022-06-01'  or(schedule_date = '2022-06-01' and schedule_end < '15:15')) and tbschedule.movie_id is not null) 

select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_image from (TBMovie inner join TBSchedule on TBSchedule.movie_id = TBMovie.movie_id) left join TBMovieGenres 
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
where TBMovie.movie_release <= '2022-06-01' and (schedule_date > '2022-06-01'  or(schedule_date = '2022-06-01' and schedule_end < '15:15'))
select TBSchedule.schedule_id from TBSchedule where movie_id = 1002
and (schedule_date > '" + DateTime.Now.ToString("yyyy-MM-dd") + "'  or(schedule_date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' and schedule_start < '" + DateTime.Now.ToString("HH:mm") + "'))

select seat_type_id from TBSeat where seat_type_id is NULL and room_id = 1005
select count (seat_type_id) as "amount" from TBSeat where seat_type_id is NULL and room_id = 1005

select distinct room_id from (TBSchedule inner join TBSeatBooking on TBSeatBooking.schedule_id = TBSchedule.schedule_id) where room_id = 1000 and (schedule_date > '"+DateTime.Now.ToString("yyyy-MM-dd")+"' or (schedule_date = '"+DateTime.Now.ToString("yyyy-MM-dd")+ "' and schedule_start < '"+ DateTime.Now.ToString("HH:mm")+ "')) and TBSeatBooking.seat_status = 1
update TBSeat set seat_type_id = 1032 where room_id = 1004 and seat_type_id is NULL
UPDATE TBSchedule  SET room_type = t.room_type_name,room_name = t.room_name,room_type_price_percent = t.room_type_price_percent,
room_number_of_seat = t.room_number_of_seat, room_number_of_row = t.room_number_of_row FROM TBRoom t WHERE TBSchedule.room_id = t.room_id and TBSchedule.schedule_id = 1000
select isnull(TBSeatType.seat_type_color,'-8355712') as seat_type_color from TBSeat left join TBSeatType on TBSeatType.seat_type_id = TBSeat.seat_type_id
where TBSeat.room_id = 1004 and TBSeat.seat_name = 'A1'
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres,'') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
--drop table TBBooking,TBPayment,TBReceipt,TBSeatBooking,TBSchedule,TBSeat,TBMovie,TBRoom
UPDATE TBSchedule  SET room_type = t.room_type_name,room_name = t.room_name,room_type_price_percent = t.room_type_price_percent,
room_number_of_seat = t.room_number_of_seat,room_number_of_row = t.room_number_of_row FROM TBRoom t WHERE TBSchedule.room_id = t.room_id and t.room_id = 1003
use RAPPHIM_QL
UPDATE TBSchedule  SET movie_name = t.movie_name,movie_price = t.movie_price FROM TBMovie t WHERE TBSchedule.movie_id = t.movie_id and TBSchedule.schedule_id = 1000
UPDATE TBSchedule  SET room_type = t.room_type_name,room_name = t.room_name,room_type_price_percent = t.room_type_price_percent,
room_number_of_seat = t.room_number_of_seat, room_number_of_row = t.room_number_of_row FROM TBRoom t WHERE TBSchedule.room_id = t.room_id and TBSchedule.schedule_id = 1000
use RAPPHIM_QL
select schedule_id,movie_name,room_name,schedule_date,schedule_start,schedule_end from TBSchedule
INSERT INTO TBSeatBooking (seat_type_id,seat_type,seat_type_price_percent,seat_type_color, schedule_id,seat_booking_name) 
SELECT TBSeatType.seat_type_id,TBSeatType.seat_type,TBSeatType.seat_type_price_percent,TBSeatType.seat_type_color, TBSchedule.schedule_id, TBSeat.seat_name 
FROM TBSeat,TBSchedule,TBSeatType WHERE TBSchedule.schedule_id = 1000 and TBSeat.seat_type_id = TBSeatType.seat_type_id and TBSchedule.room_id = TBSeat.room_id

Insert into TBSchedule(schedule_date,movie_id,movie_name,movie_price,room_id,room_type,room_name,room_type_price_percent,room_number_of_seat,room_number_of_row,schedule_start,schedule_end)
values('2022-06-10','1001','Space Dogs: Return to Earth',50000,1003,'3D','R1','10',30,6,'7:00','9:00')
select seat_booking_id from ((TBSeatBooking inner join TBSchedule on TBSchedule.schedule_id = TBSeatBooking.schedule_id)
inner join TBMovie on TBMovie.movie_id = TBSchedule.movie_id) 
where  seat_status = 1 and ( TBSchedule.schedule_date > '2022-05-30'  or (TBSchedule.schedule_date = '2022-05-30' and TBSchedule.schedule_end > '5:00')) and  TBMovie.movie_id = 1001 
INSERT INTO TBSeatBooking (seat_type_id,seat_type,seat_type_price_percent,seat_type_color, schedule_id,seat_booking_name) 
SELECT TBSeatType.seat_type_id,TBSeatType.seat_type,TBSeatType.seat_type_price_percent,TBSeatType.seat_type_color, TBSchedule.schedule_id, TBSeat.seat_name 
FROM TBSeat,TBSchedule,TBSeatType WHERE TBSchedule.schedule_id = 1000 and TBSeat.seat_type_id = TBSeatType.seat_type_id and TBSchedule.room_id = TBSeat.room_id
SELECT MAX(schedule_id) FROM TBSchedule
use RAPPHIM_QL
select TBSchedule.schedule_id from ((TBSchedule inner join TBSeatBooking on TBSchedule.schedule_id = TBSeatBooking.schedule_id)
inner join TBRoom on TBSchedule.room_id = TBRoom.room_id)
where TBSeatBooking.seat_status = 0 and  TBRoom.room_id = 1003 and (schedule_date > '2022-05-30'  or (schedule_date = '2022-05-30' and schedule_start < '5:00'))-- chua chieu chua book
select TBSchedule.schedule_id from TBSchedule inner join TBSeatBooking on TBSchedule.schedule_id = TBSeatBooking.schedule_id 
where TBSeatBooking.seat_status = 1 and  movie_id = 1001 and (schedule_date > '2022-05-30'  or (schedule_date = '2022-05-30' and schedule_start < '5:00'))-- chua chieu da book
select payment_id,TBPayment.fullname,TBReceipt.customer_name,payment_price,date_payment, count (TBBooking.booking_status) as "amount"
from TBReceipt,TBPayment,TBBooking where TBPayment.receipt_id = 1000 and TBBooking.receipt_id = TBPayment.receipt_id and TBBooking.booking_status = 0
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, 'NULL') as movie_genres, TBMovie.movie_description, TBMovie.movie_length, TBMovie.movie_release, TBMovie.movie_price, TBMovie.movie_image from TBMovie left join TBMovieGenres 
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovieGenres.movie_genres is NULL
UPDATE TBSchedule set movie_name = (select movie_name from TBMovie where TBMovie.movie_id = 1000), movie_price = (select movie_price from TBMovie where TBMovie.movie_id = 1000)
where TBSchedule.movie_id = 1000
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres,'') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres,'') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres 
on  TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
where movie_name like '%Space%' or TBMovieGenres.movie_genres like '%Space%' 
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, '') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovie.movie_id = 1003
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres, '') as movie_genres,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_image from TBMovie left join TBMovieGenres
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id where TBMovie.movie_release <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "'
SELECT movie_genres_id FROM TBMovieGenres WHERE movie_genres = ''
select * from tbseatbooking
where seat_status = 1
--where seat_booking_id = 1729 or seat_booking_id = 1730


USE RAPPHIM_QL
UPDATE TBMovie set movie_genres_id = 1000 where movie_id = 1003
GO
select TBPayment.payment_id,TBPayment.date_payment,TBStaff.fullname,TBCustomer.customer_name,TBPayment.price
from(((TBPayment inner join TBStaff on TBPayment.id_number = TBStaff.id_number)
inner join TBReceipt on TBPayment.receipt_id = TBReceipt.receipt_id)
inner join TBCustomer on TBCustomer.customer_id = TBReceipt.customer_id)
where TBPayment.receipt_id = 1005 

INSERT INTO TBMovieGenres(movie_genres)VALUES('Documentary')
INSERT INTO TBMovieGenres(movie_genres)VALUES('Cartoon')

INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Seventeen power of love: The movie',1000,'Do not miss Seventeen Power of Love: The Movie with powerful performances and share words from the past to the present, as well as future plans that 13 boys want to send to Carat will first be secreted Reveal in intensive interviews!', '115', '2022-04-20',60000)
INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Space Dogs: Return to Earth',1014,'Do not miss Seventeen Power of Love: The Movie with powerful performances and share words from the past to the present, as well as future plans that 13 boys want to send to Carat will first be secreted Reveal in intensive interviews!', '80', '2022-04-22',50000)
INSERT INTO TBMovie(movie_name, movie_genres_id, movie_description, movie_length, movie_release,movie_price) VALUES ('Chickenhare',1014,'The film follows adventures of Chickenhare, the young hero was born half a half-chicken rabbit, adopted by King Peter - a famous forest rabbit explorer.', '120', '2022-04-29',70000)


USE RAPPHIM_QL
GO
INSERT INTO TBCustomer(customer_name, customer_birthday,customer_address, customer_phone_number) 
VALUES ('Nguyen Thi Kim Chi','08/08/2001','Hoa Tien, Hoa Vang, Da Nang','0935675483')
INSERT INTO TBCustomer(customer_name, customer_birthday,customer_address, customer_phone_number) 
VALUES ('Pham Thi Quynh Linh','3/11/2001','Hoa Khanh, Lien Chieu, Da Nang','0935675485')
SELECT* FROM TBCustomer where customer_id != 1000
select distinct room_id from TBSchedule where room_id =1090
select * from TBPayment
select TBMovie.movie_name,TBSchedule.schedule_date,TBSchedule.schedule_start, TBSeatBooking.seat_booking_name,TBRoom.room_name
from(((TBSeatBooking inner join TBSchedule on TBSeatBooking.schedule_id = TBSchedule.schedule_id)
inner join TBRoom on TBSchedule.room_id = TBRoom.room_id)
inner join TBMovie on TBMovie.movie_id = TBSchedule.movie_id)
where TBSeatBooking.seat_booking_id = 1000
alter table TBBOOKING
drop column booking_status
select TBBooking.booking_id,TBStaff.fullname,TBCustomer.customer_name,TBMovie.movie_name,TBSeatBooking.seat_booking_name,CONVERT(VARCHAR(10),TBSchedule.schedule_date,120) as schedule_date,TBSchedule.schedule_start,TBRoom.room_name,TBBooking.price
from((((((TBBooking inner join TBStaff ON TBStaff.id_number = TBBooking.id_number) INNER JOIN TBCustomer ON TBBooking.customer_id = TBCustomer.customer_id) 
INNER JOIN TBSchedule ON TBBooking.schedule_id = TBSchedule.schedule_id) INNER JOIN TBSeatBooking ON TBBooking.seat_booking_id = TBSeatBooking.seat_booking_id) 
INNER JOIN TBMovie ON TBSchedule.movie_id = TBMovie.movie_id) inner join TBRoom ON TBSeatBooking.room_id = TBRoom.room_id) where  TBBooking.booking_id = 1038
SELECT CONVERT(VARCHAR(10),schedule_date,111) from TBSchedule 
update TBSeatBooking set seat_status = 0 where seat_booking_id in (select seat_booking_id from TBBooking where booking_id = 1028 )
update TBReceipt
set total_price = total_price + 5
alter table TBReceipt
drop column status 
select * from TBReceipt
update TBSeatBooking
set seat_status = 0
select TBBooking.booking_id,TBStaff.fullname,TBCustomer.customer_name,TBMovie.movie_name,TBSeatBooking.seat_booking_name,TBSchedule.schedule_date,TBSchedule.schedule_start,TBRoom.room_name,TBBooking.price
from((((((TBBooking inner join TBStaff ON TBStaff.id_number = TBBooking.id_number) INNER JOIN TBCustomer ON TBBooking.customer_id = TBCustomer.customer_id)
INNER JOIN TBSchedule ON TBBooking.schedule_id = TBSchedule.schedule_id) INNER JOIN TBSeatBooking ON TBBooking.seat_booking_id = TBSeatBooking.seat_booking_id)
INNER JOIN TBMovie ON TBSchedule.movie_id = TBMovie.movie_id) inner join TBRoom ON TBSeatBooking.room_id = TBRoom.room_id) where  TBBooking.receipt_id = 1007
select * from TBBooking
select TBReceipt.receipt_id, TBStaff.fullname,TBCustomer.customer_name,TBReceipt.date_booking,TBReceipt.total_price,TBReceipt.number_of_tickets 
from((TBReceipt inner join TBStaff on TBReceipt.id_number = TBStaff.id_number) inner join TBCustomer on TBCustomer.customer_id = TBReceipt.customer_id) 
where TBStaff.fullname like '%195%' or TBCustomer.customer_name like '%195%'  or TBReceipt.total_price = '195' or TBReceipt.number_of_tickets = '195' 
or TBReceipt.date_booking = '2022-05-13';
select TBReceipt.receipt_id, TBStaff.fullname,TBCustomer.customer_name,TBReceipt.date_booking,TBReceipt.total_price,TBReceipt.number_of_tickets 
from((TBReceipt inner join TBStaff on TBReceipt.id_number = TBStaff.id_number) inner join TBCustomer on TBCustomer.customer_id = TBReceipt.customer_id)

select TBReceipt.receipt_id, TBStaff.fullname,TBCustomer.customer_name,TBReceipt.date_booking,TBReceipt.total_price,TBReceipt.number_of_tickets
from ((TBReceipt inner join TBStaff on TBReceipt.id_number = TBStaff.id_number) inner join TBCustomer on TBCustomer.customer_id = TBReceipt.customer_id) 
where  TBReceipt.receipt_id = 1007
insert into TBReceipt(id_number,number_of_tickets,total_price,date_booking) values(1000,3,195,'2002-05-14')
--insert into TBReceipt(id_number,customer_id,number_of_tickets,total_price,date_booking) values(1000,"+customer_id + "," +number_of_ticket + "," + total_price + ",'" + date_booking + "')
select TBSchedule.schedule_id from((TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id) 
inner join TBRoomType ON TBRoom.room_type_id = TBRoomType.room_type_id) 
where TBSchedule.movie_id = 1000 and TBRoomType.room_type = '2D' and TBSchedule.schedule_date = '2022-05-16' and TBSchedule.schedule_start = '19:48'
select DISTINCT TBSeatType.seat_type_color from TBSeatType, TBSeatBooking where( select TBSeatBooking.seat_type_id from TBSeatBooking where seat_booking_name =
                'A1' and schedule_id = 1043) = TBSeatType.seat_type_id 
select DISTINCT TBSeatType.seat_type_color from TBSeatType, TBSeatBooking where( select TBSeatBooking.seat_type_id from TBSeatBooking where seat_booking_name =
'A1' and schedule_id = 1043) = TBSeatType.seat_type_id 
UPDATE TBSchedule
SET schedule_date = '2022-05-17'
WHERE schedule_date = '2022-05-09';

select TBSchedule.schedule_start from((TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id)
inner join TBRoomType ON TBRoom.room_type_id = TBRoomType.room_type_id) 
where TBSchedule.movie_id = 1000 and TBRoomType.room_type = '2D'and  TBSchedule.schedule_date = '2022-05-07' order by TBSchedule.schedule_start
select TBSchedule.schedule_start,TBSchedule.schedule_end from((TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id) 
inner join TBRoomType ON TBRoom.room_type_id = TBRoomType.room_type_id) 
where TBSchedule.movie_id = 1000 and TBRoomType.room_type = '2D' and ((TBSchedule.schedule_date = '2022-05-07' and TBSchedule.schedule_start >= '22:22') or TBSchedule.schedule_date > '2022-05-07') order by TBSchedule.schedule_start
select TBSchedule.schedule_start from((TBSchedule inner join TBRoom on TBSchedule.room_id = TBRoom.room_id) 
inner join TBRoomType ON TBRoom.room_type_id = TBRoomType.room_type_id) 
where TBSchedule.movie_id = 1000 and TBRoomType.room_type = '2D' and ((TBSchedule.schedule_date = '2022-05-07'  and TBSchedule.schedule_start >= '22:30') or(TBSchedule.schedule_date > '2022-05-07')) order by TBSchedule.schedule_start
select distinct TBRoomType.room_type from((TBRoomType inner join TBRoom on TBRoomType.room_type_id = TBRoom.room_type_id) 
inner join TBSchedule ON TBSchedule.room_id = TBRoom.room_id) where TBSchedule.movie_id= '1000' and TBSchedule.schedule_date = '2022-05-07' order by TBRoomType.room_type;
select distinct schedule_date from TBSchedule where movie_id = '1000' and schedule_date <= '2022-05-07' order by schedule_date
select TBMovie.movie_id, TBMovie.movie_name, TBMovieGenres.movie_genres,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_image from TBMovie, TBMovieGenres
where TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id and TBMovie.movie_id in (select distinct movie_id from TBSchedule 
where schedule_date <= '2022-05-07')
select TBMovie.movie_id, TBMovie.movie_name, TBMovieGenres.movie_genres,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_image from TBMovie, TBMovieGenres
where TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id and TBMovie.movie_id not in (select movie_id from TBSchedule)
select TBMovie.movie_id, TBMovie.movie_name, TBMovieGenres.movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image
from TBMovie, TBMovieGenres where TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id and TBMovie.movie_id in (select distinct movie_id from TBSchedule where schedule_date <= '2022-05-07')
select TBRoom.room_name,TBSchedule.schedule_date,TBSchedule.schedule_start,TBSchedule.schedule_end
from TBSchedule, TBRoom where TBRoom.room_id = 1001 and TBRoom.room_id = TBSchedule.room_id and TBSchedule.schedule_date = '2022-12-03'
and (('19:00:00' between TBSchedule.schedule_start and TBSchedule.schedule_end) or ('21:00:00' between TBSchedule.schedule_start and TBSchedule.schedule_end)
or (TBSchedule.schedule_start between '19:00:00' and '21:00:00') or (TBSchedule.schedule_end between '19:00:00' and '21:00:00'))
use RAPPHIM_QL
select TBBooking.booking_id,TBStaff.fullname,TBCustomer.customer_name,TBMovie.movie_name,TBSeatBooking.seat_booking_name,TBSchedule.schedule_date,TBSchedule.schedule_start,TBRoom.room_name,TBBooking.price
from ((((((TBBooking inner join TBStaff ON TBStaff.id_number = TBBooking.id_number) INNER JOIN TBCustomer ON TBBooking.customer_id = TBCustomer.customer_id)
INNER JOIN TBSchedule ON TBBooking.schedule_id=TBSchedule.schedule_id) INNER JOIN TBSeatBooking ON TBBooking.seat_booking_id = TBSeatBooking.seat_booking_id)
INNER JOIN TBMovie ON TBSchedule.movie_id = TBMovie.movie_id) inner join TBRoom ON TBSeatBooking.room_id = TBRoom.room_id)
where  TBBooking.booking_id = 1000
--UPDATE TBSchedule set movie_name = (select movie_name from TBMovie where TBMovie.movie_id = "+movie_id+ "), movie_price = (select movie_price from TBMovie where TBMovie.movie_id = " + movie_id + ") where TBSchedule.movie_id = " + movie_id
SELECT room_type_id, room_type_price_percent FROM TBRoomType WHERE room_type = '3D'
select room_id, room_name,isnull(TBRoomType.room_type,'NULL') as room_type from TBRoom left join TBRoomType
on TBRoom.room_type_id = TBRoomType.room_type_id
select TBMovie.movie_id, TBMovie.movie_name, isnull(TBMovieGenres.movie_genres,'NULL') as movie_genres,TBMovie.movie_description,TBMovie.movie_length,TBMovie.movie_release,TBMovie.movie_price,TBMovie.movie_image from TBMovie left join TBMovieGenres
on TBMovie.movie_genres_id = TBMovieGenres.movie_genres_id
SELECT movie_genres FROM TBMovieGenres order by movie_genres
alter table TBMovie
drop column movie_genres_name

UPDATE TBRoom set room_name = 'R1', room_type_id = 1001, room_type_name = (select room_type from TBRoomType where room_type_id = 1001),
room_type_price_percent  = (select room_type_price_percent from TBRoomType where room_type_id = 1001) where room_id = 1003

