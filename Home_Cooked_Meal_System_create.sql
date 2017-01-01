create table ladies (
Nicknam nvarchar(50), area nvarchar (50) ,phone_number nvarchar (50));

create table items (
picture image , timee time , name nvarchar(50) ,typee nvarchar(50), ingredients nvarchar (50), price money ,order_id int ,nickname nvarchar(50));

create table ORDEER (
Order_ID int ,orderdate datetime ,bill money ,no_items int ,customer_id int );

create table customer (
Customer_ID int ,name nvarchar (50) ,phone_number nvarchar (50) ,addrees nvarchar (50) );