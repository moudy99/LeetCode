/* Write your T-SQL query statement below */


select EUN.unique_id  ,E.name
from Employees E left join EmployeeUNI EUN
on EUN.id = E.id 

