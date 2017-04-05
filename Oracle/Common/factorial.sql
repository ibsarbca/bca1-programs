declare
  n number := 5;
  fsum number := 1;
  temp number := 1;
begin
    temp := &n;
    while temp > 0 loop
      fsum := temp * fsum;
      temp := temp - 1;
    end loop;
    dbms_output.put_line('FACTORIAL: ' || fsum);
end;
        
