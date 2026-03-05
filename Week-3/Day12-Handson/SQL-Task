CREATE DATABASE EventDb1;
USE EventDb1;
CREATE TABLE UserInfo
(
    EmailId VARCHAR(100) PRIMARY KEY,

    UserName VARCHAR(50) NOT NULL
        CHECK (LENGTH(UserName) BETWEEN 1 AND 50),

    Role VARCHAR(20) NOT NULL
        CHECK (Role IN ('Admin', 'Participant')),

    Password VARCHAR(20) NOT NULL
        CHECK (LENGTH(Password) BETWEEN 6 AND 20)
);


CREATE TABLE EventDetails
(
    EventId INT PRIMARY KEY,

    EventName VARCHAR(50) NOT NULL
        CHECK (LENGTH(EventName) BETWEEN 1 AND 50),

    EventCategory VARCHAR(50) NOT NULL
        CHECK (LENGTH(EventCategory) BETWEEN 1 AND 50),

    EventDate DATETIME NOT NULL,
	Description VARCHAR(500) NULL,

    Status VARCHAR(20) NOT NULL
        CHECK (Status IN ('Active', 'In-Active'))
);
CREATE TABLE SpeakersDetails
(
    SpeakerId INT PRIMARY KEY,
    SpeakerName VARCHAR(50) NOT NULL
        CHECK (LENGTH(SpeakerName) BETWEEN 1 AND 50)
);

CREATE TABLE SessionInfo (
    SessionId INT PRIMARY KEY,
    SessionTitle VARCHAR(50),
    EventId INT,
    SpeakerId INT,
    Description VARCHAR(100),
    SessionStart DATETIME NOT NULL,
    SessionEnd DATETIME NOT NULL,
    SessionUrl VARCHAR(200),

  
    FOREIGN KEY (EventId) REFERENCES EventDetails(EventId),
    FOREIGN KEY (SpeakerId) REFERENCES SpeakersDetails(SpeakerId)
);

CREATE TABLE ParticipantEventDetails
(
    Id INT PRIMARY KEY,

    ParticipantEmailId VARCHAR(100) NOT NULL,

    EventId INT NOT NULL,

    SessionId INT NOT NULL,

    IsAttended BIT NOT NULL
        CHECK (IsAttended IN (0,1)),
        FOREIGN KEY (ParticipantEmailId)
        REFERENCES UserInfo(EmailId),

        FOREIGN KEY (EventId)
        REFERENCES EventDetails(EventId),

        FOREIGN KEY (SessionId)
        REFERENCES SessionInfo(SessionId)
);

INSERT INTO UserInfo VALUES
('anjanimounika@gmail.com', 'Mounika', 'Admin', 'admin123'),
('kavya12.com', 'Kavya', 'Participant', 'john1234');

INSERT INTO EventDetails 
(EventId, EventName, EventCategory, EventDate, Description, Status)
VALUES
(1, 'Spring Fest', 'Cultural', '2026-04-10', 
 'Annual cultural celebration event', 'Active');
 
 INSERT INTO SpeakersDetails (SpeakerId, SpeakerName) VALUES
(1, 'Bindu'),
(2, 'Deepika');

select * from SpeakersDetails;
select * from UserInfo;
select * from EventDetails;

 



