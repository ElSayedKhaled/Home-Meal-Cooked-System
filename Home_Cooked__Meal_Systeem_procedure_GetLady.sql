create Procedure GetLadies
@Area varchar(50)
as
SElECT Nicknam , phone_number 
from ladies
where area = @ARea

