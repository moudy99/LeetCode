/* Write your T-SQL query statement below */




	select S.student_id , S.student_name ,sb.subject_name ,count(E.student_id) as attended_exams 
	from Students S
	cross join Subjects sb
	left join Examinations E 
	on E.student_id = S.student_id and E.subject_name = sb.subject_name
	group by 
	S.student_id , S.student_name ,sb.subject_name
	order by S.student_id 
