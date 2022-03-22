create database quanlyrapchieuphim;
use quanlyrapchieuphim;
create table account(
id_number int,
fullname char(30) not null,
username char(30) not null,
pwd char (30) not null,
phone_number char(20) not null,
email char(40) not null,
admin_role int,
primary key (id_number)
);
