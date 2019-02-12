CREATE TABLE RAM
(
	Id int PRIMARY KEY IDENTITY(1,1),
	Price float NOT NULL,
	Manufacturer varchar(50) NOT NULL,
	Model varchar(50) NOT NULL,
	Capacity int NOT NULL,
	Frequency int NOT NULL,
	MemoryType varchar(50) NOT NULL
);
