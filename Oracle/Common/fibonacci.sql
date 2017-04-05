declare
  f1 integer;
  f2 integer;
  f3 integer;
  n integer;
begin
  f1 := 0;
  f2 := 1;
  f3 := 0;
  n := 0;
  while n <= 10 loop
    f1 := f2;
    f2 := f3;
    f3 := f1 + f2;
    dbms_output.put_line(f3);
    n := n + 1;
  end loop;
end;