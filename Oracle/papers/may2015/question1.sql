select * from emp where salary > 10000;

select distinct(job) from emp;

select max(salary) from emp;

select name, job, salary from emp where name like 'R%'

select name, city, job, dname from emp, dept where dname = 'Sales';

declare
  cursor ecur is (select * from emp where salary < 10000);
begin
  for c in ecur loop
    update emp set salary = c.salary + 1000;
  end loop;
end;

-- See common for factorial and reverse