 select name from emp where salary = (select max(salary) from emp);


select * from emp where join_date = to_date('2007-06-10', 'YYYY-MM-DD');

