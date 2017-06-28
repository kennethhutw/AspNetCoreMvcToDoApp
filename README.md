# AspNetCoreMvcToDoApp
AspNetCoreMvcToDoApp


![TodoListApp](img/todo.gif)


The Github Repo of TodoApp using ASP.NET Core MVC.


## Step 1. Create Database in MSSQL Server 

  Script : AspNetCoreMvcToDoAppDBSchema.sql (including Database )

  Script : AspNetCoreMvcToDoAppDBTablesSchema.sql

## Step 2. Restore the project 

   Open the AspNetCoreMvcToDoApp directory  commnad line

   Type "dotnet restore"

   ![TodoListApp](img/restore.png)

   Type "dotnet run"

   ![TodoListApp](img/run.png)

   Open "http://localhost:5000" in the browser

   ![TodoListApp](img/index.png)

   click "ToDo List"
  
   ![TodoListApp](img/ToDoIndex.png)

## Step 3 : Pages

   View ToDos

   ![TodoListApp](img/ToDoIndex.png)

   Add a ToDo

   ![TodoListApp](img/ToDoAdd.png)

   Edit a ToDo

   ![TodoListApp](img/ToDoEdit.png)

    Delete a ToDo

   ![TodoListApp](img/ToDoDelete.png)

   ####If it cannot connect to Database, please check whether the connectionString is correct in Startup.cs

    My default connectionString is  :  var connection = @"Server=.\SQLEXPRESS;Database=AspNetCoreToDo;Trusted_Connection=True;";