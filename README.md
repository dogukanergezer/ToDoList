# ToDoList

# To make it run;

1-Go to appsetting.json file, then enter your "ConnectionStrings" server information.

2-Search TaskList.Web as a starter project.

3-After creating a user and password in the database, you can log in.

If you get an error;

$ dotnet migrations, add TaskItems --startup-project ./ --project ../TaskList.DAL/

#Next

$ dotnet ef data update --startup-project ./ --project ../TaskList.DAL/

You can run the commands and try again.
