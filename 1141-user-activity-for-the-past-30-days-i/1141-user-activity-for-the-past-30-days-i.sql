/* Write your T-SQL query statement below */

select activity_date as day ,count(distinct user_id) as active_users
from Activity
WHERE activity_date <='2019-07-27' AND activity_date > DATEADD(day, -30, '2019-07-27')
group by activity_date