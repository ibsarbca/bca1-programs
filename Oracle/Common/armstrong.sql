declare
  n integer;
  i integer;
  d integer;
  s integer := 0;
  og integer;
begin
  n := 153;
  og := n;
  while n != 0 loop
    d := mod(n, 10);
    s := s + (d * d * d);
    n := floor(n / 10);
  end loop;
  if s = og then
    dbms_output.put_line('armstrong');
  end if;
  dbms_output.put_line(s);
end;