﻿ALTER TABLE Car
drop column StartID
ALTER TABLE Car
drop column EndID
ALTER TABLE Car
ADD Boughtdate DATE
ALTER TABLE Rentby
DROP COLUMN StartID
ALTER TABLE Rentby
drop column EndID
ALTER TABLE Rentby
ADD Startdate DATE
ALTER TABLE Rentby
ADD Enddate DATE