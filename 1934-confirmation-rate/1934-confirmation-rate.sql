/* Write your T-SQL query statement below */


SELECT A.user_id, ROUND((SELECT COUNT(C.user_id) FROM Confirmations C WHERE C.action = 'confirmed' AND  C.user_id = A.user_id)*1.0/COUNT(A.user_id),2) AS confirmation_rate
FROM Signups A
LEFT JOIN Confirmations B
ON A.user_id = B.user_id
GROUP BY A.user_id ORDER BY confirmation_rate