declare
  eid integer;
  ename varchar(30);
  esal integer;
  dno integer;
  cursor c is select id, name, salary, dept_no from employees;
begin
  open c;
  loop
    fetch c into eid, ename, esal, dno;
      exit when c%notfound;
      dbms_output.put_line(eid || ' ' || ename || ' ' || esal || ' ' || dno);
  end loop;
end;
