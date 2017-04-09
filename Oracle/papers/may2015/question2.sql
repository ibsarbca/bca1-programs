select * from emp where job = 'Analyst';

select salary from emp where dept_no = 10;

select * from emp where commission is null;

select name, job from emp where name like '____';

select * from emp where city = 'Delhi' or city = 'Mumbai';

declare
  cursor cemp is (select name, salary from emp where dept_no = 20);
begin
  for c in cemp loop
    dbms_output.put_line(c.name || ' ' || c.salary);
  end loop;
end;

-- For sum and palindrome see Common