Create Database DairyFarmDB;





CREATE TABLE Cow (
    CowId       INT PRIMARY KEY IDENTITY(1,1),
    CowName     VARCHAR(50),
    EarTag      VARCHAR(50),
    Color       VARCHAR(50),
    Breed       VARCHAR(50),
    Age         INT,
    WeightAtBirth INT,
    Pasture     VARCHAR(50)
);

ALTER TABLE Cow
ADD DateOfBirth DATE;


CREATE TABLE Employee (
    EmpId       INT PRIMARY KEY IDENTITY(1,1),
    EmpName     VARCHAR(50),
    EmpDob      DATE,
    Gender      VARCHAR(50),
    Phone       VARCHAR(50),
    Address     VARCHAR(50)
);
ALTER TABLE Employee
ADD Username VARCHAR(50),
    Password VARCHAR(50),
    Role      VARCHAR(50) 

CREATE TABLE Milk (
    MilkId      INT PRIMARY KEY IDENTITY(1,1),
    CowId       INT FOREIGN KEY REFERENCES Cow(CowId),
    AmMilk      INT,
    NoonMilk    INT,
    PmMilk      INT,
    TotalMilk   AS (AmMilk + NoonMilk + PmMilk), 
    DateProd    DATE
);
CREATE TABLE Health (
    RepId       INT PRIMARY KEY IDENTITY(1,1),
    CowId       INT FOREIGN KEY REFERENCES Cow(CowId),
    RepDate     DATE,
    Event       VARCHAR(50),
    Diagnosis   VARCHAR(50),
    Treatment   VARCHAR(50),
    Cost        INT,
    VetName     VARCHAR(50)
);
CREATE TABLE MilkSales (
    SId         INT PRIMARY KEY IDENTITY(1,1),
    SaleDate    DATE,
    UPrice      INT,
    ClientName  VARCHAR(50),
    ClientPhone VARCHAR(50),
    EmpId       INT FOREIGN KEY REFERENCES Employee(EmpId),
    Quantity    INT,
    Amount      AS (UPrice * Quantity)  
);

CREATE TABLE Expenditure (
    ExpId       INT PRIMARY KEY IDENTITY(1,1),
    ExpDate     DATE,
    ExpPurpose  VARCHAR(50),
    ExpAmount   INT,
    EmpId       INT FOREIGN KEY REFERENCES Employee(EmpId)
);
ALTER TABLE Expenditure
ADD HealthId INT NULL FOREIGN KEY REFERENCES Health(RepId)

CREATE TABLE Income (
    IncId       INT PRIMARY KEY IDENTITY(1,1),
    IncDate     DATE,
    IncType     VARCHAR(50),
    IncAmount   INT,
    EmpId       INT FOREIGN KEY REFERENCES Employee(EmpId)
);
ALTER TABLE Income
ADD SaleId INT NULL FOREIGN KEY REFERENCES MilkSales(SId)

CREATE TABLE Breed (
    BreedId         INT PRIMARY KEY IDENTITY(1,1),
    HeatDate        DATE,
    BreedDate       DATE,
    CowId           INT FOREIGN KEY REFERENCES Cow(CowId),
    PregDate        DATE,
    ExpDateCalve    DATE,
    DateCalved      DATE,
    CowAge          INT,
    Remarks         VARCHAR(50)
);

INSERT INTO Cow (CowName, EarTag, Color, Breed, Age, WeightAtBirth, Pasture) VALUES
('Daisy', 'ET002', 'Light Brown', 'Jersey', 4, 30, 'River Pasture'),
('Luna', 'ET003', 'Black', 'Angus', 3, 35, 'Hill Pasture'),
('Molly', 'ET004', 'Brown & White', 'Hereford', 3, 36, 'South Field'),
('Rosie', 'ET005', 'Grey', 'Brahman', 4, 32, 'Lake Pasture'),
('Lily', 'ET006', 'Black & White', 'Holstein', 3, 39, 'East Field'),
('Ruby', 'ET007', 'Dark Brown', 'Jersey', 3, 29, 'Garden Pasture'),
('Hazel', 'ET008', 'Solid Black', 'Angus', 4, 34, 'West Field'),
('Coco', 'ET009', 'Grey & White', 'Brahman', 3, 33, 'Palm Pasture'),
('Sandy', 'ET010', 'Reddish Brown', 'Hereford', 2, 37, 'Coconut Pasture');

INSERT INTO Health (CowId, RepDate, Event, Diagnosis, Treatment, Cost, VetName) VALUES
(3, '2025-01-15', 'Illness', 'Mastitis', 'Antibiotic Injection', 4500, 'Dr. Perera'),
(4, '2025-02-10', 'Injury', 'Foot Rot', 'Hoof Cleaning', 3200, 'Dr. Silva'),
(5, '2025-03-05', 'Illness', 'Fever', 'Anti-fever Injection', 2000, 'Dr. Fernando'),
(6, '2025-03-20', 'Parasite', 'Worm Infection', 'Deworming Medicine', 1500, 'Dr. Jayasinghe'),
(7, '2025-04-12', 'Skin Issue', 'Skin Infection', 'Antibiotic Cream', 1800, 'Dr. Perera'),
(8, '2025-05-02', 'Digestive Issue', 'Bloating', 'Stomach Relief Medicine', 2500, 'Dr. Silva'),
(9, '2025-05-18', 'Injury', 'Leg Wound', 'Bandage and Cleaning', 2700, 'Dr. Fernando'),
(10, '2025-06-01', 'Parasite', 'Tick Infestation', 'Anti-tick Spray', 1600, 'Dr. Jayasinghe'),
(11, '2025-06-15', 'Illness', 'Respiratory Infection', 'Antibiotics', 3900, 'Dr. Silva');

INSERT INTO Employee (EmpName, EmpDob, Gender, Phone, Address, Username, Password, Role) VALUES
('Nimal Perera', '1990-05-12', 'Male', '0771234567', 'Kalutara', 'admin', '1234', 'Admin'),
('Saman Silva', '1988-11-03', 'Male', '0712345678', 'Panadura', 'Employee', '1234', 'Employee')
;


INSERT INTO Breed (CowId, HeatDate, BreedDate, PregDate, ExpDateCalve, DateCalved, CowAge, Remarks) VALUES
(7, '2024-06-01', '2024-06-02', '2024-06-20', '2025-03-12', '2025-03-14', 3, 'Normal delivery'),
(9, '2024-07-10', '2024-07-11', '2024-07-25', '2025-04-20', '2025-04-22', 4, 'Normal delivery'),
(3, '2024-08-05', '2024-08-06', '2024-08-20', '2025-05-15', NULL, 2, 'Expected soon'),
(4, '2024-09-01', '2024-09-02', '2024-09-18', '2025-06-10', NULL, 5, 'Awaiting calving'),
(5, '2024-10-15', '2024-10-16', '2024-11-01', '2025-07-24', NULL, 3, 'Awaiting calving');