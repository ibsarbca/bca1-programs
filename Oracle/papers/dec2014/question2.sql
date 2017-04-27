create table factory (
    factory_id int primary key,
    factory_name varchar(30) not null,
    location varchar(30)
);

create table customer (
    custid int primary key,
    customer_name varchar(30),
    birth_date date,
    city varchar(30),
    mobile_no varchar(11),
    salary int,
    factory_name varchar(30) 
);


alter table factory
add constraint u_fn unique (factory_name);

alter table customer
add constraint fk_fact_name foreign key (factory_name) references factory(factory_name);

alter table customer
add join_date date;

select customer_name from customer where salary = (select max(salary) from customer);

select to_char(join_date, 'MM') from customer where customer_name = 'MARK';

select mobile_no from customer where mobile_no like '88%';

select * from customer join factory on customer.factory_name = factory.factory_name where customer.city = factory.location;

-- Prime No: Common

-- Cursor
declare
    cursor c_cur is (select * from customer where customer_name = 'JACK');
begin
    for c in c_cur loop
        dbms_output.put_line(c.customer_name || ' ' || c.mobile_no|| ' ' || c.city);
    end loop;
end;

