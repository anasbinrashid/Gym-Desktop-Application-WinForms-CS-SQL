create database dbproject
use dbproject

-- TABLES

create table member
(
	memberid numeric (4) not null,
	username nvarchar (55),
	password nvarchar (55),
	email nvarchar (55),
	age numeric (10),
	gender nvarchar (55),
	phonenumber nvarchar (50),
	height numeric (20),
	weight numeric (20),
	membershipcategory nvarchar(55),

	primary key(memberid)
)

select *
from member

create table trainer
(
	trainerid numeric (4) not null,
	username nvarchar (55),
	password nvarchar (55),
	email nvarchar (55),
	age numeric (10),
	gender nvarchar (55),
	phonenumber nvarchar (50),
	experience numeric (20),
	speciality nvarchar (55),
	rating numeric (10),

	primary key(trainerid)
)

select *
from trainer

create table owner
(
	ownerid numeric (4) not null,
	username nvarchar (55),
	password nvarchar (55),
	email nvarchar (55),
	age numeric (10),
	gender nvarchar (55),
	phonenumber nvarchar (50)

	primary key(ownerid)
)

select *
from owner

create table admin
(
	adminid numeric (4) not null,
	username nvarchar (55),
	password nvarchar (55),
	email nvarchar (55),
	age numeric (10),
	gender nvarchar (55),
	phonenumber nvarchar (50),

	primary key(adminid)
)

select *
from admin

create table gym
(
	gymid numeric (4) not null,
	name nvarchar (55),
	location nvarchar (55),
	membershipfee numeric (20),
	capacity numeric (38),
	openingtime nvarchar (50),
	closingtime nvarchar (50),
	adminid numeric (4),
	ownerid numeric (4),

	primary key (gymid),
	foreign key (adminid) references admin (adminid),
	foreign key (ownerid) references owner (ownerid)
)

select *
from gym

create table dietplan
(
	dietplanid numeric (4) not null,
	objective nvarchar (255),
	nutrition nvarchar (55),
	diettype nvarchar (55),
	trainerid numeric (4),
	memberid numeric (4),
	createdby nvarchar (255)

	primary key (dietplanid),
	foreign key (trainerid) references trainer (trainerid),
	foreign key (memberid) references member (memberid)
)

select * 
from dietplan

create table workoutplan
(
	workoutplanid numeric (4) not null,
	workoutgoal nvarchar (200),
	experiencelevel nvarchar (55),
	trainerid numeric (4),
	memberid numeric (4),
	createdby nvarchar (255)

	primary key (workoutplanid),
	foreign key (trainerid) references trainer (trainerid),
	foreign key (memberid) references member (memberid)
)

select *
from workoutplan

create table trainingsession
(
	sessionid numeric (10),
	sessiondate date,
	sessiongoal nvarchar (255),
	startingtime datetime,
	endingtime datetime,
	trainerid numeric (4),
	memberid numeric (4),

	primary key (sessionid),
	foreign key (trainerid) references trainer (trainerid),
	foreign key (memberid) references member (memberid)
)

select *
from trainingsession

create table owneroperationonmember
(
	ownerid numeric (4),
	memberid numeric (4)
	
	foreign key (ownerid) references owner (ownerid),
	foreign key (memberid) references member (memberid)
)

create table owneroperationontrainer
(
	ownerid numeric (4),
	trainerid numeric (4)
	
	foreign key (ownerid) references owner (ownerid),
	foreign key (trainerid) references trainer (trainerid)
)

create table membergoestogym
(
	gymid numeric (4),
	memberid numeric (4),
	joiningdate date
	
	foreign key (gymid) references gym (gymid),
	foreign key (memberid) references member (memberid)
)

create table trainerworksingym
(
	gymid numeric (4),
	trainerid numeric (4),
	joiningdate date
	
	foreign key (gymid) references gym (gymid),
	foreign key (trainerid) references trainer (trainerid)
)

create table gymhastrainerrating
(
	gymid numeric (4),
	trainerid numeric (4),
	rating numeric (4)
	
	foreign key (gymid) references gym (gymid),
	foreign key (trainerid) references trainer (trainerid)
)

select *
from gymhastrainerrating

create table feedback
(
	feedbackid numeric (4),
	rating numeric (10),
	review nvarchar (255),
	trainerid numeric (4),
	memberid numeric (4)

	primary key (feedbackid),
	foreign key (memberid) references member (memberid),
	foreign key (trainerid) references trainer (trainerid)
)

select *
from feedback

create table meal
(
	mealid numeric (4),
	mealname nvarchar (255),
	totalcalories numeric (10),
	potentialallergens nvarchar (255),
	fiber numeric (4),
	fats numeric (4),
	carbohydrates numeric (4),
	protein numeric (4),
	portionsize nvarchar (255),
	mealtime nvarchar (255),
	dietplanid numeric (4)

	primary key (mealid),
	foreign key (dietplanid) references dietplan (dietplanid)
)

select * from meal

create table workoutday
(
	dayid numeric (4),
	dayname nvarchar (55),
	targetedmuscle nvarchar (155),
	workoutplanid numeric (4)

	primary key (dayid),
	foreign key (workoutplanid) references workoutplan (workoutplanid)
)

select *
from workoutday

create table exercise
(
	exerciseid numeric (4),
	reps numeric (4),
	sets numeric (4),
	restintervals numeric (4)

	primary key (exerciseid)
)

select *
from exercise

create table daysexercise
(
	dayid numeric (4),
	exerciseid numeric (4)

	foreign key (exerciseid) references exercise (exerciseid),
	foreign key (dayid) references workoutday (dayid)
)

select *
from daysexercise

create table machine
(
	machineid numeric (4),
	machinename nvarchar (155),
	manufacturingcompany nvarchar (155),
	targetedmuscle nvarchar (155),
	exerciseid numeric (4)

	primary key (machineid),
	foreign key (exerciseid) references exercise (exerciseid)
)

select *
from machine

create table adminapprovesgym
(
	adminid numeric (4),
	name nvarchar (55),
	location nvarchar (55),
	membershipfee numeric (20),
	capacity numeric (38),
	openingtime nvarchar (50),
	closingtime nvarchar (50),
	ownerid numeric (4),

	foreign key (adminid) references admin (adminid),
	foreign key (ownerid) references owner (ownerid)
)

select *
from adminapprovesgym

create table ownerapprovestrainer
(
	username nvarchar (55),
	password nvarchar (55),
	email nvarchar (55),
	age numeric (10),
	gender nvarchar (55),
	phonenumber nvarchar (50),
	experience numeric (20),
	speciality nvarchar (55),
	rating numeric (10),
	ownerid numeric (4)

	foreign key (ownerid) references owner (ownerid)
)

select *
from ownerapprovestrainer

create table audittrail
(
	auditid numeric (4),
	actionon varchar (50),
	id numeric (4),
	timestamp datetime,
	details varchar (255)

	primary key (auditid)
)

select *
from audittrail

-- SEQUENCES

create sequence gymid
as bigint
start with 23
increment by 1
cache 100

create sequence ownerid
as bigint
start with 24
increment by 1
cache 100

create sequence trainerid
as bigint
start with 27
increment by 1
cache 100

create sequence memberid
as bigint
start with 52
increment by 1
cache 100

create sequence auditid
as bigint
start with 7
increment by 1
cache 100

create sequence sessionid
as bigint
start with 54
increment by 1
cache 100

create sequence feedbackid
as bigint
start with 27
increment by 1
cache 100

create sequence dietplanid
as bigint
start with 43
increment by 1
cache 100

create sequence workoutplanid
as bigint
start with 43
increment by 1
cache 100

create sequence mealid
as bigint
start with 43
increment by 1
cache 100

create sequence workoutdayid
as bigint
start with 72
increment by 1
cache 100

create sequence exerciseid
as bigint
start with 44
increment by 1
cache 100

-- TRIGGERS 

create trigger triggeraftergymadded
on gym
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Gym', inserted.gymid, getdate(), 'New Gym Created'
	from inserted
end

create trigger triggeraftermemberadded
on member
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Member', inserted.memberid, getdate(), 'New Member Joined'
	from inserted
end

create trigger triggeraftertraineradded
on trainer
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Trainer', inserted.trainerid, getdate(), 'New Trainer Joined'
	from inserted
end

create trigger triggerafterowneradded
on owner
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Owner', inserted.ownerid, getdate(), 'New Owner Joined'
	from inserted
end

create trigger triggerafterworkoutplanadded
on workoutplan
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Workout Plan', inserted.workoutplanid, getdate(), 'New Workout Plan Created'
	from inserted
end

create trigger triggerafterdietplanadded
on dietplan
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Diet Plan', inserted.dietplanid, getdate(), 'New Diet Plan Created'
	from inserted
end

create trigger triggeraftertrainingsessionadded
on trainingsession
after insert
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Training Session', inserted.sessionid, getdate(), 'New Training Session Scheduled'
	from inserted
end

create trigger triggeraftergymdelete
on gym
after delete
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Gym', deleted.gymid, getdate(), 'Gym Revoked'
	from deleted
end

create trigger triggeraftermemberdelete
on member
after delete
as begin
	insert into audittrail
	select next value for dbo.auditid, 'Member', deleted.memberid, getdate(), 'Member Removed'
	from deleted
end

create trigger triggeraftertrainerdelete
on trainer
after delete
as begin
	insert into audittrail
	select next value for dbo.auditid,  'Trainer', deleted.trainerid, getdate(), 'Trainer Removed'
	from deleted
end

create trigger triggeraftertrainingsessdelete
on trainingsession
after delete
as begin
	insert into audittrail
	select next value for dbo.auditid,  'Training Session', deleted.sessionid, getdate(), 'Training Session Cancelled'
	from deleted
end

-- REPORTS QUERIES

create view report4 as select count( member.memberid ) as count, machine.machinename, workoutday.dayname from member inner join workoutplan on member.memberid=workoutplan.memberid inner join workoutday on workoutplan.workoutplanid=workoutday.workoutplanid inner join daysexercise on workoutday.dayid=daysexercise.dayid inner join exercise on daysexercise.exerciseid=exercise.exerciseid inner join machine on exercise.exerciseid= machine.exerciseid group by machine.machinename, workoutday.dayname

select report4.count, report4.machinename, report4.dayname from report4

select dietplan.diettype, meal.totalcalories, meal.mealtime from meal inner join dietplan on meal.dietplanid= dietplan.dietplanid

select meal.mealname, meal.carbohydrates, meal.mealtime from meal inner join dietplan on meal.dietplanid= dietplan.dietplanid where meal.carbohydrates<300

select workoutplan.workoutgoal, machine.machinename from workoutplan inner join workoutday on workoutplan.workoutplanid=workoutday.workoutplanid inner join daysexercise on workoutday.dayid=daysexercise.dayid inner join exercise on daysexercise.exerciseid=exercise.exerciseid inner join  machine on exercise.exerciseid=machine.exerciseid where machine.machinename  not like 'Leg Raise Machine'

select distinct(machine.machinename) from machine

select meal.mealname, meal.potentialallergens from meal inner join dietplan on meal.dietplanid= dietplan.dietplanid where meal.potentialallergens not like 'Peanuts'

select member.username, membergoestogym.joiningdate from member inner join membergoestogym on member.memberid=membergoestogym.memberid inner join gym on membergoestogym.gymid=gym.gymid where membergoestogym.joiningdate not like('2023-01-12') 

create view gyms_totalmembers as select count(member.username) as total_members, gym.name from member inner join membergoestogym on membergoestogym.memberid=member.memberID inner join gym on membergoestogym.gymid=gym.gymID group by gym.name 

select top(3) gym.capacity,gym.name,gym.location from gym

select * from gym where gym.membershipfee<15000

select member.username, member.memberid from member inner join dietplan on member.memberid=dietplan.dietplanid inner join trainer on dietplan.trainerid=trainer.trainerid

