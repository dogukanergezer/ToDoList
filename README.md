# ToDoList

## To make it run;

1-Go to appsetting.json file, then enter your own server information in the **ConnectionStrings** field.

2-Set **TaskList.Web** as the startup project.

3-After creating a user and password in the database, you can login.

### If you get database access error;

1-Delete the migrations folder and

2-Go to **TaskList.Web** directory on command line

`dotnet migrations add TaskItems --startup-project ./ --project ../TaskList.DAL/`

`dotnet migrations add UserEntities --startup-project ./ --project ../TaskList.DAL/`

 **Next**

`dotnet ef data update --startup-project ./ --project ../TaskList.DAL/`

You can run the commands and try again.
