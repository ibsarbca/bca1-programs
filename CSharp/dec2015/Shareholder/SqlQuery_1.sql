create table shareholder
(
holder_id int identity(1, 1) primary key,
hname varchar(100),
address varchar(100),
no_of_shares int,
share_serial_no_start int,
share_serial_no_end int,
cost int
);
