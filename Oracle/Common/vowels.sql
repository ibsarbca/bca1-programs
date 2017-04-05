declare
  str varchar(30);
  i integer := 0;
  ch char;
  vcount integer := 0;
begin
  str := '&str';
  i := 0;
  while i < length(str) loop
    ch := substr(str, i, 1);
    if ch = 'a' then
      vcount := vcount + 1;
    elsif ch = 'e' then
      vcount := vcount + 1;
    elsif ch = 'i' then
      vcount := vcount + 1;
    elsif ch = 'o' then
      vcount := vcount + 1;
    elsif ch = 'o' then
      vcount := vcount + 1;
    end if;
    i := i + 1;
  end loop;
  dbms_output.put_line(vcount);
end;