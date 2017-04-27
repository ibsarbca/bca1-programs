select name from emp where salary = (select max(salary) from emp);


select * from emp where join_date = to_date('2007-06-10', 'YYYY-MM-DD');

select name, salary from emp where job = 'Clerk' and commission is not null;

select * from emp where name like 'Pr%';

select * from emp where salary < 5000;

-- Odd nos, see Common folder
-- Vowel count, see Common folder

-- Cursor
declare
    cursor cur is (select * from emp where commission is null);
begin
    for c in cur loop
        dbms_output.put_line(c.name);
    end loop;
end;