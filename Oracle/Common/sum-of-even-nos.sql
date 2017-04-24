Declare
    NUM1 number:=0;
    sum_even number := 0;
begin
    loop
        NUM1 := NUM1+2;
        sum_even := sum_even + NUM1;
        exit when NUM1=100;
    end loop;
    dbms_output.put_line('SUM OF EVEN NOS: ');
    dbms_output.put_line (sum_even);
end;
