DROP TABLE Admin;
DROP TABLE PigeonHoles;
DROP TABLE Bookings;
DROP TABLE Lanes;

CREATE TABLE Lanes (
  Lane_ID NUMERIC(2),
  Lane_Status CHAR(1) DEFAULT 'U',
  CONSTRAINT pk_Lane_ID PRIMARY KEY (Lane_ID)
);

CREATE TABLE Bookings (
  Booking_ID NUMERIC(3),
  Forename VARCHAR2(20) NOT NULL,
  Surname VARCHAR2(30) NOT NULL,
  Booking_Date DATE NOT NULL,
  Booking_Time CHAR(2) NOT NULL,
  Booking_Status CHAR(1) DEFAULT 'B',
  NumOfShoes NUMERIC(1) NOT NULL,
  Booking_Cost NUMERIC(5,2) NOT NULL,
  Lane_ID NUMERIC(2),
  CONSTRAINT pk_Booking_ID PRIMARY KEY (Booking_ID),
  CONSTRAINT fk_Lane_ID FOREIGN KEY (Lane_ID) REFERENCES Lanes(Lane_ID)
);

CREATE TABLE PigeonHoles (
  SlotNo NUMERIC(3),
  ShoeSize NUMERIC(2),
  BookingRef NUMERIC(3) DEFAULT NULL,
  CONSTRAINT pk_SlotNo PRIMARY KEY (SlotNo),
  CONSTRAINT fk_BookingRef FOREIGN KEY (BookingRef) REFERENCES Bookings(Booking_ID)
);

CREATE TABLE Admin (
  Booking_Year NUMERIC(4) NOT NULL,
  Total_Bookings NUMERIC(5),
  Total_Revenue NUMERIC(10),
  CONSTRAINT pk_Booking_Year PRIMARY KEY(Booking_Year)
);







