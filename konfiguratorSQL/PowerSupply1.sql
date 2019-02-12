CREATE TABLE PowerSupply
(
	Id int PRIMARY KEY IDENTITY(1,1),
	Price float NOT NULL,
	Manufacturer varchar(50) NOT NULL,
	Model varchar(50) NOT NULL,
	"Power" int NOT NULL,
	Efficiency int NOT NULL,
	"Standard" varchar(50) NOT NULL
);
