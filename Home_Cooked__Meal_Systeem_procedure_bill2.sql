create procedure bill
@@Price money output, 
@@no_items int output
as
select items.price  , ORDEER.no_items
from items inner join ORDEER 
on ORDEER.name = items.name