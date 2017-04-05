declare
  str varchar(30);
  s char;
  n number;
  rev varchar(30);
begin
  str := 'dhaval';
  n := LENGTH(str);
  while n > 0 loop
    s := SUBSTR(str, n, 1);
    rev := rev || s;
    n := n - 1;
  end loop;
  dbms_output.put_line(rev);
end;

