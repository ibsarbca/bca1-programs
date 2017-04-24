declare
  str varchar(30);
  i integer := 0;
  ch char;
  vcount integer := 0;
begin
  str := '&str';
  i := 1;
  while i < length(str) + 1 loop
    if i > 0 then
      ch := substr(str, i, 1);
    else
      ch := substr(str, 0);
    end if;
    -- this is done because i = 0 and i = 1 both return the first character
    dbms_output.put_line(ch);
    if ch = 'a' then
      vcount := vcount + 1;
      
    elsif ch = 'e' then
      vcount := vcount + 1;
      
    elsif ch = 'i' then
      vcount := vcount + 1;
      
    elsif ch = 'o' then
      vcount := vcount + 1;
      
    elsif ch = 'u' then
      vcount := vcount + 1;
    end if;
    i := i + 1;
  end loop;
  dbms_output.put_line(vcount);
end;

