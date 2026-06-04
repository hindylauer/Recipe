create login //loginname// with password = //password//

create user devcpu_user from login //loginname//

alter role db_datareader add member devcpu_user
alter role db_datawriter add member devcpu_user