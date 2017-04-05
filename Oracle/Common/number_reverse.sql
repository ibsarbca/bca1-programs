declare
  n integer;
  d integer;
  s integer := 0;
  i integer;
begin
  n := &n;
  i := length(to_char(n)) - 1;
  while n != 0 loop
    d := mod(n, 10);
    s := s + (d * power(10, i));
    n := floor(n / 10);
    i := i - 1;
  end loop;
  dbms_output.put_line(s);
end;
  