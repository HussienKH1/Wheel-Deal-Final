﻿Alter table Rentby
ADD CONSTRAINT Customer_Rentby_CSID
FOREIGN KEY (CSID) REFERENCES Customer(CSID)