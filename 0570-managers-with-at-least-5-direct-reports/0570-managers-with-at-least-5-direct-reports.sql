/* Write your T-SQL query statement below */

select e.name 
from employee e
where e.id in (
select mang.id
            from Employee E , Employee mang
            where E.managerId  = mang.id
            group by mang.id
            having count(mang.id)  >4 
)