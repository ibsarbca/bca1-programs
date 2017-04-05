declare
  function isPrime(n in integer)
  return integer
  as
    i integer;
    begin
      i := n - 1;
      while i > 2 loop
        if mod(n, i) = 0 then
          return 1;
          exit;
        end if;
        i := i - 1;
      end loop;
      return 0;
    end;
begin
  dbms_output.put_line('' || isprime(1));
  for i in 1..500 loop
    if isPrime(i) = 0 then
      dbms_output.put_line(i);
    end if;
  end loop;
end;