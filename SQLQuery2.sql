select Top (1000) [Id],[FirstName],[Enterpreneurship],[Employment],[University],[Building],[Developing],[Resilence],[Volunteering],[College],[Career],[CareerOptions],[CV] from Mentees where Mentees.Employment = 1

select FirstName from Mentees Where (CV = 1 OR Enterpreneurship = 1 OR Employment = 1 OR University = 1 OR Building = 1 OR Developing = 1 OR Resilence = 1 OR Volunteering = 1 OR College = 1 OR Career = 1 OR CareerOptions = 1 ) 

select FirstName from Mentees where CV = 1
select * from Mentees

select Mentees FirstName Where CV = 1

SELECT Mentees.FirstName, Mentees.CV , Mentees.Employment,Mentors.FirstName, Mentors.CV_Writting 
FROM Mentees, Mentors Where Mentees.CV = 1 AND Mentors.CV_Writting = 1

SELECT  Mentees.FirstName,
        Mentees.LastName
FROM Mentees
JOIN Mentors
ON Mentees.id = Mentors.Id;

select Top (1000) [FirstName],[LastName],[Email],[Country],[Education],[Enterpreneurship],[Employement],[Developing_Resilence],[Volunteering] From Mentors where Mentors.Employement = 1

--select FirstName 
--from Mentees 
--WHERE CV = 1 AND Select FirstName From Mentors Where CV = 1

----SELECT FROM Mentees WHERE Enterpreneurship = 1 AND Select  = 2008;]

--SELECT *
--FROM Mentees
--WHERE (CV = 1 AND Enterpreneurship = 1)
--OR (Refenrec = 2);

