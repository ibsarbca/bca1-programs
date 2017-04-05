declare
  str varchar(30);
  rev varchar(30);
  c char;
  i integer;
begin
  str := 'aaaa';
  i := length(str);
  while i > 0 loop
    c := substr(str, i, 1);
    rev := rev || c;
    i := i - 1;
  end loop;
  if rev = str
    then dbms_output.put_line('palindrome');
  end if;
  dbms_output.put_line(rev);
end;
    