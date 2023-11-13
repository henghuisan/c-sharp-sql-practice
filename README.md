<h1 align="center" id="title">(1) Create ASP.NET Core Web Application With SQL Server Database Connection and CRUD Operations</h1>

## Tutorial
[![Create ASP.NET Core Web Application With SQL Server Database Connection and CRUD Operations](https://img.youtube.com/vi/T-e554Zt3n4/0.jpg)](https://www.youtube.com/watch?v=T-e554Zt3n4)


## Getting Started
### 1. Inititalize Project
- Create a <b>ASP.NET Core Web App</b> project

### 2. Connect Database
- Select "Tools" -> "Connect to Database..." -> Enter server name <b>LAPTOP-JP6QO1OQ\SQLEXPRESS</b> -> Select database (make sure the database is created in SQL Server)
- Create table
  ```
  CREATE TABLE (
  properties...
  )
  ```
- Open appsettings.json, append the code
    ```
    "ConnectionStrings": {
      "SqlServerDb": "the connection string"
    }
    ```

### 3. Create Page
- Create folder for specific page, e.g. ``` Client ```
- Create empty Razor Page for CRUD ( right click the folder -> select "Add" -> select "Razor Page" -> name the "Razor Page"
- Edit the page with HTML, CSS ...
- For view code page, remember to include the <b>Model</b> class
  ```
  // for example
  public class ClientIno
  {
    public String id;
    public String name;
    public String email;
    public String phone;
    public String address;
  }
  ```
* Press f7 to switch between page and code

### 4. Write API
You can refer to the project..
