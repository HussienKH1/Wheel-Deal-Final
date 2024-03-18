﻿CREATE TABLE Person(
SSN INT,
Name NVARCHAR(30),
Age INT,
Address TEXT,
Login NVARCHAR(30),
Password NVARCHAR(30),
Role NVARCHAR(30),
PRIMARY KEY(SSN));

CREATE TABLE Customer(
CSID INT,
Name NVARCHAR(30),
Gender NVARCHAR(25),
Birthday DATE,
Country NVARCHAR(30),
City NVARCHAR(30),
PhoneNumber INT,
PRIMARY KEY(CSID));

CREATE TABLE Car(
CRID INT,
SSN INT,
CSID INT,
Brand NVARCHAR(30),
Color NVARCHAR(25),
Speed INT,
Capacity INT,
Mileage INT,
Engine NVARCHAR(40),
Available BIT,
BoughtID INT,
StartID INT,
EndID INT,
Price INT,
PAYMENT INT,
Type NVARCHAR(30),
Model NVARCHAR(30),
PRIMARY KEY(CRID));

ALTER TABLE Car
ADD CONSTRAINT Person_Car_SSN
FOREIGN KEY (SSN) REFERENCES Person (SSN);

ALTER TABLE Car
ADD CONSTRAINT Customer_Car_CSID
FOREIGN KEY (CSID) REFERENCES Customer(CSID)