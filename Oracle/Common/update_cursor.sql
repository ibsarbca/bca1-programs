declare
  cursor c_emp is select id, salary from employees;
  eid employees.id%type;
  esal employees.id%type;
begin
  open c_emp;
  loop
    fetch c_emp into eid, esal;
      exit when c_emp%notfound;
      if esal < 10000
        then
          update employees set salary = salary + 1000 where id = eid;
          commit;
      end if;       
  end loop;
end;
