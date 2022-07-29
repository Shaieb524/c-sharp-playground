IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='my_passes' and xtype='U')
CREATE TABLE passwords (
    Service NVARCHAR (150) NOT NULL,
    Password NVARCHAR (50) NOT NULL,
    CreatedOn DATETIME NULL,
);