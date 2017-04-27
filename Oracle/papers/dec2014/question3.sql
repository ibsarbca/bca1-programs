select * from emp where join_date < (select join_date from emp where name = 'BLAKE');

select * from emp where salary < (select avg(salary) from emp where dept_no = 40);

select count(*) from emp where gender = 'F' and dept_no = (select dept_no from dept where dname = 'RESEARCH');

select name from emp where salary > 10000 and city = 'Bangalore';

-- PL\SQL
-- Even/Odd and String equals are excluded for being too simple.