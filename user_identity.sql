USE user_identity;


-- CREATE TABLE roles
CREATE TABLE roles(
roleID INT NOT NULL,
role_name VARCHAR(30) NOT NULL,
[description] VARCHAR(100),
PRIMARY KEY(roleID)
);




--DROP Table userRoles;

-- CREATE TABLE Users
CREATE TABLE users(
userID INT NOT NULL,
[name] VARCHAR(30) NOT NULL,
surname VARCHAR(30) NOT NULL,
email VARCHAR(100) NOT NULL,
phone VARCHAR(13) NOT NULL,
rumuz VARCHAR(100) NOT NULL,
[password] VARCHAR(100) NOT NULL,
birthday_date DATE NOT NULL,
hobbies VARCHAR(100) NOT NULL,
record_date DATE NOT NULL,
PRIMARY KEY(userID),
);
----------------------------------------

--ALTER TABLE users
--ADD record_date DATE NOT NULL

--SELECT * FROM users

--DROP Table userRoles;

----------------------------------------

CREATE TABLE userRoles(
userRoleID INT NOT NULL,
userID INT NOT NULL,
roleID INT NOT NULL,
assigner VARCHAR(60) NOT NULL,
record_date DATE NOT NULL,
PRIMARY KEY(userRoleID),
FOREIGN KEY (userID) REFERENCES users(userID),
FOREIGN KEY (roleID) REFERENCES roles(roleID)
);

----------------------------------------

--ALTER TABLE roles
--ADD assigner VARCHAR(60) NOT NULL

--SELECT * FROM roles

----------------------------------------

-- CREATE TABLE application
CREATE TABLE application(
applicationID INT NOT NULL,
userID INT NOT NULL,
project_name VARCHAR(100) NOT NULL,
[description] VARCHAR(100) NOT NULL,
project_type VARCHAR(100) NOT NULL,
[start_date] DATE NOT NULL,
end_date DATE NOT NULL,
record_date DATE NOT NULL,
project_status VARCHAR(100) NOT NULL,
PRIMARY KEY(applicationID),
FOREIGN KEY (userID) REFERENCES users(userID)
);

----------------------------------------

--ALTER TABLE application
--ADD record_date DATE NOT NULL

--SELECT * FROM application

----------------------------------------