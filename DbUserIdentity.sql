Update Applications set ApplicationStatus=1

--Update Roles set RoleStatus=1

--Update UserRoles set UserRoleStatus=1

Update Users set UserStatus=1




ALTER TABLE UserRoles
ADD FOREIGN KEY (UserID) REFERENCES Users(UserID);


ALTER TABLE UserRoles
ADD FOREIGN KEY (RoleID) REFERENCES Roles(RoleID);

ALTER TABLE Applications
ADD FOREIGN KEY (UserID) REFERENCES Users(UserID);


Select * from Users 
Where Users.UserID = 1;
