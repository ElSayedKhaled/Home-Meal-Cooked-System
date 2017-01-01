declare @cost money 
exec name_price @Name='Pasta' ,
@@Price = @cost
select 'The Cost Is = '+CAST(@cost as varchar(20))  