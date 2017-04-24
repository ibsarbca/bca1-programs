declare
  n int := 0;
  s int := 0;
begin
  while n <= 100 loop
    if mod(n, 2) != 0 then
      s := s + n;
    end if;
    n := n + 1;
  end loop;
  dbms_output.put_line(s);
end;