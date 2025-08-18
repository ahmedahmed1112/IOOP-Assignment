

SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Manager';

INSERT INTO dbo.Manager (FirstName, LastName, PhoneNumber, Password) VALUES (@FirstName, @LastName, @PhoneNumber, @Password);
