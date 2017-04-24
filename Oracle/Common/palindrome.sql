declare
  str varchar(30);
  rev varchar(30);
  c char;
  i integer;
begin
  str := 'aaaa';
  i := length(str);
  while i > 0 loop
    if i > 0 then
      ch := substr(str, i, 1);
    else
      ch := substr(str, 0);
    end if;
    -- this is done because i = 0 and i = 1 both return the first character
    c := substr(str, i, 1);
    rev := rev || c;
    i := i - 1;
  end loop;
  if rev = str
    then dbms_output.put_line('palindrome');
  end if;
  dbms_output.put_line(rev);
end;
    