select * from emp where to_char(join_date, 'MM') = '06';

select * from emp where city != 'Delhi' or city != 'Pune';

select avg(salary) from emp;

select * from emp where dept_no = 30 and salary < (select avg(salary) from emp);

-- Pl/SQL
declare
    dno  emp.dept_no%type;
    emp_count int;
begin
    dno  := '&dno ';
    
    select count(*) into emp_count from emp where dept_no = dno ;
    dbms_output.put_line(emp_count);
end;

-- Cursor
declare
    cursor emp_cur is (select * from emp);
    i int := 0;
begin
    for c in emp_cur loop
        if mod(i, 2) = 0 then
            update emp set salary = salary + salary * (20 / 100) where emp_id = c.emp_id;
        else
            update emp set salary = salary + salary * (10 / 100) where emp_id = c.emp_id;
        end if;
        i := i + 1;
    end loop;
end;
