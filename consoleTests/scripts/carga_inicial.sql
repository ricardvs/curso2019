create table if not exists PERSONA(Id INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(32), LastName varchar(32));
create table if not exists Empresa(nombre varchar(20));

delete from PERSONA where Id > 10;

insert into PERSONA(Id, Name, LastName)
values (50, 'Rick', 'Sanchez');
insert into PERSONA(Id, Name, LastName)
values (54, 'Morty', 'Smith');
