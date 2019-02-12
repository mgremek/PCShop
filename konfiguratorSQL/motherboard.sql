CREATE TABLE Motherboard
( 
	Id int PRIMARY KEY IDENTITY(1,1),
	Price float NOT NULL,
	Manufacturer varchar(50) NOT NULL,
	Model varchar(50) NOT NULL,
	Chipset varchar(50) NOT NULL,
	Socket varchar(50) NOT NULL,
	FormFactor varchar(50) NOT NULL	
);