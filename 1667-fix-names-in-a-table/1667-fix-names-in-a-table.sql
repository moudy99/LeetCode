/* Write your T-SQL query statement below */
select user_id ,Upper(substring(name,1,1))+Lower(substring(name,2,Len(name))) as 'name'
from Users
order by user_id