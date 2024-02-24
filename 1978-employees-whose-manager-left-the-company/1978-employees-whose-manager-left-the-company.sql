/* Write your T-SQL query statement below */


select employee_id 
from Employees E 
where salary <30000 and manager_id  not in (
select employee_id 
from Employees E 
)
order by employee_id