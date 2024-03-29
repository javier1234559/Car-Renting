﻿-- Script Reset Database 
USE master;
GO
IF EXISTS(SELECT * FROM sys.databases WHERE name = 'QLThueXe')
	BEGIN
		ALTER DATABASE QLThueXe SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
		DROP DATABASE QLThueXe;
	END
CREATE DATABASE QLThueXe;
GO
USE QLThueXe;
GO

create table Users(
	IdUser int primary key IDENTITY(1,1),
	Name varchar(255),
	Phone varchar(11) ,
	Address VARCHAR(255),
	TotalRevenue int,
	CONSTRAINT valid_phone CHECK (Phone LIKE '0%' AND ISNUMERIC(Phone) = 1),
);


Create table Account (
	AccID int primary key IDENTITY(1,1),
	Email nvarchar(320), 
	Password nvarchar(100),
	IdUser int 
	Foreign KEY (IdUser) REFERENCES Users(IdUser),
	CONSTRAINT valid_email CHECK (Email LIKE '%@%.%'),
);


create table Cars(
	CarId int primary key IDENTITY(1,1),
	CarName nvarchar(255),
	CategoryName nvarchar(255),
	Brand nvarchar(255),
	Seats INT,
	PricePerDay int,
	NumberPlate nvarchar(10),
	Description nvarchar(500),
	ImageCar nvarchar(500)
);

Create table Clients(
	ClientId int primary key IDENTITY(1,1),
	Name nvarchar(255),
	Phone varchar(11) ,
	CCCD VARCHAR(30),
	Email nvarchar(320),
	License nvarchar(320),
	CONSTRAINT valid_email1 CHECK (Email LIKE '%@%.%'),
);

Create table Rents(
	RentId int primary key IDENTITY(1,1),
	CarId int ,
	ClientId int,
	DateStart datetime,
	DateEnd datetime,
	DateDelayQuantity int DEFAULT 0,
	State nvarchar(50) NOT NULL DEFAULT 'Available',
	DescriptionRent nvarchar(500) DEFAULT '',
	Deposit INT NOT NULL,
	CanceleReason nvarchar(500) DEFAULT '' ,
	Foreign KEY (CarId) REFERENCES Cars(CarId),
	Foreign KEY (ClientId) REFERENCES Clients(ClientId),
);

CREATE TABLE Discount (
	   Id INT PRIMARY KEY IDENTITY,
	   Code VARCHAR(50) UNIQUE,
	   DiscountPercent DECIMAL(18,2),
	   StartDate DATETIME,
	   EndDate DATETIME,
	   Quantity INT,
	   CreatedDate DATETIME,
	   CreatedBy NVARCHAR(50)
	);


Create table Bills(
	BillId int primary key IDENTITY(1,1),
	RentId int ,
	IdUser int,
	TotalCost DECIMAL(18,3),
	CreateDate datetime,
	CompensationName nvarchar(30) DEFAULT '',
	Compensation int DEFAULT 0,
	CompensationDescript nvarchar(300) DEFAULT '',
	DiscountCode NVARCHAR(20) DEFAULT '',
	Foreign KEY (RentId) REFERENCES Rents(RentId),
	Foreign KEY (IdUser) REFERENCES Users(IdUser),
);

Create table Rating(
	RatingId int primary key IDENTITY(1,1),
	RentId int,
	CarId int ,
	ClientId int,
	RatingValue int ,
	FeedBack NVARCHAR(200) DEFAULT '',
	Foreign KEY (RentId) REFERENCES Rents(RentId),
	Foreign KEY (ClientId) REFERENCES Clients(ClientId),
	Foreign KEY (CarId) REFERENCES Cars(CarId),
);

INSERT INTO Users (Name, Phone, Address, TotalRevenue)
VALUES ('John Doe', '0123456789', '123 Main St', 500),
       ('Jane Smith', '0987654321', '456 Second St', 1000),
       ('Bob Johnson', '0765432198', '789 Third St', 750),
	   ('Nhan vat chinh', '0123456789', '789 Third St', 750);


INSERT INTO Account (Email, Password, IdUser) VALUES
  ('john@example.com', 'password123', 1),
  ( 'jane@example.com', 'password456', 2),
  ('doe@example.com', 'password789', 3),
  ('1@gmail.com','1',4);

INSERT INTO Cars (CarName, CategoryName, Brand, Seats, PricePerDay, NumberPlate, Description, ImageCar)
VALUES ('Toyota Camry', 'Sedan', 'Toyota', 5, 50, 'ABC123', 'A reliable and comfortable sedan', N'ToyotaYaris.png'),
       ('Honda Civic', 'Sedan', 'Honda', 5, 45, 'DEF456', 'A sporty and efficient sedan',  N'HondaCivic.png'),
       ('Toyota Camry', 'Truck', 'Toyota', 3, 75, 'GHI789', 'A rugged and powerful pickup truck', N'ToyotaCamry.png'),
       ('Ford Fusion', 'Truck', 'Ford', 3, 75, 'JKL012', 'A rugged and powerful pickup truck', N'FordFusion.png'),
       ('Chevrolet Impala', 'Truck', 'Chevrolet', 3, 75, 'MNO345', 'A rugged and powerful pickup truck', N'ChevroletImpala.png');

INSERT INTO Clients (Name, Phone, CCCD, Email, License)
VALUES ('Tom Smith', '0123456789', '1234567890', 'tom.smith@example.com', '1234567890'),
		('MR Bean', '09098989967', '0909787867', 'tom.bean@example.com', '0909898978'),
       ('Mary Johnson', '0987654321', '0987654321', 'mary.johnson@example.com', '0987654321'),
	    ('MR Johnson', '1212343454', '0987654821', 'johnson.johnson@example.com', '0987650001'),
       ('Jim Brown', '0765432198', '7654321987', 'jim.brown@example.com', '7654321987');


INSERT INTO Rents (CarId, ClientId, DateStart, DateEnd,DescriptionRent ,DateDelayQuantity, State, Deposit, CanceleReason)
VALUES (1, 1, '2023-05-01 18:45:10', '2023-05-9 23:48:00', 'Mo ta hoa don ',0, 'Renting',  100, ''),
       (2, 2, '2023-05-11 09:30:00', '2023-05-13 09:31:00','Mo ta hoa don ' ,10, 'Pending',  150, ''),
       (2, 3, '2023-05-15 09:00:00', '2023-05-20 17:00:00','Mo ta hoa don ' ,0, 'Available', 200, ''),
	   	(4, 5, '2023-05-04 08:00:00', '2023-05-09 18:00:00', 'Mo ta hoa don ',1, 'Waiting',  150, ''),	
       (5, 4, '2023-05-25 10:00:00', '2023-05-27 18:00:00','Mo ta hoa don ', 0, 'Canceled',  250, 'Change of plans'),
	   	(3, 4, '2023-04-04 08:00:00', '2023-5-09 18:00:00', 'Mo ta hoa don ',0, 'Available',  150, ''),	
		(4, 5, '2023-02-04 08:00:00', '2023-02-23 18:00:00', 'Mo ta hoa don ',0, 'Available',  150, ''),	
		(1, 5, '2023-04-04 08:00:00', '2023-05-09 18:00:00', 'Mo ta hoa don ',0, 'Available',  150, ''),	
		(5, 5, '2023-03-04 08:00:00', '2023-03-09 18:00:00', 'Mo ta hoa don ',0, 'Available',  150, ''),
		(1, 2, '2023-03-04 08:00:00', '2023-02-09 18:00:00', 'Mo ta hoa don ',0, 'Available',  150, '');

INSERT INTO Rating(RentId, CarId, RatingValue, FeedBack, ClientId) VALUES
		(3, 3, 5, 'Excellent Service', 2),
		(6, 3, 3, 'Service could have been better', 3),
		(7, 4, 4, 'Good Service overall', 4),
		(8, 4, 2, 'Disappointed with the service', 5),
		(9, 2, 5, 'Great Service', 2);


INSERT INTO Discount(Code, DiscountPercent, StartDate, EndDate, Quantity, CreatedDate, CreatedBy)
	VALUES ('DIS0', 0.5, '2023-05-10 00:00:00', '2023-05-20 00:00:00', 3, '2023-05-10 12:00:00', 'Nhat');

INSERT INTO Bills (RentId, IdUser, TotalCost, CreateDate, CompensationName, Compensation, CompensationDescript, DiscountCode)
	VALUES (3, 1, 15000.00, '2022-01-01 08:00:00', '', 0, '', 'DIS0'),
			(6, 2, 9000.00, '2023-5-09 18:00:00', '', 0, '', 'DIS0'),
			(7, 3, 18000.00, '2023-02-23 18:00:00', '', 0, '', 'DIS0'),
			(8, 2, 15000.00, '2023-05-09 18:00:00', 'Hu xe', 9000, 'Gay tai nan dan den hu xe', 'DIS0'),
			(9, 1, 21000.00, '2023-04-09 18:00:00', '', 0, '', 'DIS0'),
			(10, 1, 2000.00, '2023-02-09 18:00:00', '', 0, '', 'DIS0');
