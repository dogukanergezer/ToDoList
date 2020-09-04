# ToDoList

#To make it run;

1- Go to appsetting.json file, then enter your "ConnectionStrings" information and the name of the table you want to create.

2-Select TaskList.Web as the initial startup project and run it.

3-After creating a user and password in the database, you can log in.

If you get a database error;

$ dotnet migrations, add TaskItems --startup-project ./ --project ../TaskList.DAL/

#Next

$ dotnet ef data update --startup-project ./ --project ../TaskList.DAL/

You can run the commands and try again.
