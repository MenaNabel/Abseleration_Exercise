CREATE DATABASE ProgramBase;
use ProgramBase;
CREATE TABLE Programs(
    ProgramId  int IDENTITY(1,1) PRIMARY KEY,
    ProgramText varchar(MAX),
);
DECLARE @code NVARCHAR(MAX)
SET @code = '#include <iostream> ' + CHAR(10) + 
'using namespace std;' + CHAR(10) +
'int main() { ' + CHAR(10) +
'cout << "Hello World!" << endl;' + CHAR(10) +
'return 0;' +CHAR(10)+ 
'}'  + CHAR(10);
SELECT @code
INSERT INTO Programs VALUES(@code);