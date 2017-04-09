declare
  i int;
  n int;
  s int := 0;
  d int;
begin
  n := 153;
  --i := length(to_char(n));
  i := 1;
  while n != 0 loop
    d := mod(n, 10);
    s := s + d;
    n := floor(n / 10);
  end loop;
  dbms_output.put_line(s);
end;