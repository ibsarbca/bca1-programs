select * from emp where commission is null;

select distinct(city) from emp;

select min(salary) from emp;

select * from emp where to_char(join_date, 'MM') = '04';

select name, city, job, dname from emp join dept on emp.dept_no = dept.dept_no where dname='EDP';

declare
  cursor cemp is (select * from emp where dept_no = 30);
begin
  for c in cemp loop
    dbms_output.put_line(c.name || ' ' || ' ' || c.salary ||' ' || c.job);
  end loop;
end;

-- For armstrong and count vowels, see Common