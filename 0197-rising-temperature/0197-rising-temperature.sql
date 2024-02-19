/* Write your T-SQL query statement below */

select W.id 
from Weather W 
where W.temperature > (
select max(temperature) 
    from Weather 
    where recordDate= dateadd(day,-1,W.recordDate )
)



