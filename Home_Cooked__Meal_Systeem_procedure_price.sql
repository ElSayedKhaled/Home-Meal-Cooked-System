create procedure name_price
@Name varchar(50),
@@Price money output 
as
select @@Price = price
from items
where name = @Name