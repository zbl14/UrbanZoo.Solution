## Urban Zoo API and Client
------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
    * <a href="#🛰️-api-documentation">API Documentation</a> 
* <a href="#🤝-contributors">Contributors</a>
* <a href="#⚖️-license">License</a>
* <a href="#🌟-acknowledgments">Acknowledgements</a> 


------------------------------

## 🌐 About the Project
Web app employing .NET MVC web framework, calls to Google’s web mapping API, and mySQL to store and display user generated points on a map. 

### 📖 Description
This web app serves as a way to collectively document and discover interesting places to explore around your neighborhood. The original concept was conceived during the Covid lockdown, when most people avoided indoor spaces.
Urban Zoo was built as part of a ‘Team Week’ at Epicodus where a group of students work together to design and build a project in one week based on what they’ve learned so far in the program. 


### 🦠 Known Bugs

* Posted Date of a location can't be updated correctly.

### 🛠 Built With

* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 5.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Google Maps API](https://developers.google.com/maps)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Postman](postman.com)

------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [VS Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [UrbanZoo repository here](https://github.com/derrak/UrbanZoo.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/derrak/UrbanZoo.Solution`
  5) Run the command `cd UrbanZoo.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the UrbanZoo_API directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```json
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=UrbanZoo;uid=root;pwd=[YourPassword];"
  }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to UrbanZoo_API directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to UrbanZoo_API directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

  #### Launch the Client Side
  1) Navigate to UrbanZoo_Client directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet run` to have access to the site in the browser.
  
------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. 

### Using Swagger Documentation 
To explore the UrbanZoo API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Note on Pagination
The UrbanZoo_API version 2 returns a default of 5 results per page.

To modify this, use the query parameters `pageNumber` and `pageSize` to alter the response results displayed. The `pageNumber` parameter will specify which page will be displayed, and the `pageSize` parameter will specify how many result in the response and the maximum is 5.

#### Example Query
```
https://localhost:5000/api/features/?version=2&pageNumber=2&pageSize=1
```

#### Sample JSON Response
```json
{
    "pageNumber": 2,
    "pageSize": 1,
    "firstPage": "https://localhost:5001/api/Features/?pageNumber=1&pageSize=1",
    "lastPage": "https://localhost:5001/api/Features/?pageNumber=10&pageSize=1",
    "totalPages": 10,
    "totalRecords": 10,
    "nextPage": "https://localhost:5001/api/Features/?pageNumber=3&pageSize=1",
    "previousPage": "https://localhost:5001/api/Features/?pageNumber=1&pageSize=1",
    "data": [
        {
        "featureId": 3,
        "userId": 0,
        "title": "Chicken ",
        "description": "Can't feed the chickens",
        "createdDate": "0001-01-01T00:00:00",
        "availability": true,
        "streetAddress": "SE 45th Ave & SE Harold St",
        "state": "OR",
        "city": "Portland",
        "lat": 45.4827529,
        "lng": 122.6164548,
        "zipcode": "97266"
        }
    ],
    "succeeded": true,
    "errors": null,
    "message": null
}
```

To use default, _don't include_ `version`, `pageNumber` and `pageSize`.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
Access information on Features from around the West Coast.
```
GET /api/features
POST /api/features
GET /api/features/{id}
PUT /api/features/{id}
DELETE /api/features/{id}
```

#### Example Query
```
https://localhost:5000/api/features/2
```

#### Sample JSON Response
```json
{
    "featureId": 2,
    "userId": 0,
    "title": "Chicken",
    "description": "Owners welcome public feeding",
    "createdDate": "0001-01-01T00:00:00",
    "availability": true,
    "streetAddress": "SE 44th & SE Tolman",
    "state": "OR",
    "city": "Portland",
    "lat": 45.4770279,
    "lng": -122.6174991,
    "zipcode": "98682"
}
```
------------------------------

 ### 🤝 Contributors

>Derrak Richard [Email](derrak@gmail.com) || [GitHub](https://github.com/derrak) || [LinkedIn](https://www.linkedin.com/in/derrak-richard/)
>
>Zhibin Liang [Email](ifthereisoneday@gmail.com) || [GitHub](https://github.com/zbl14) || [LinkedIn](https://www.linkedin.com/in/zhibin-liang/)
>
>Mo Byrne [Email](mosey.b.byrne@gmail.com) || [GitHub](https://github.com/MoseyByrne) || [LinkedIn](https://www.linkedin.com/in/mosaic-byrne/)
>
>Winnie Wang [Email](weijwang18@gmail.com) || [GitHub](https://github.com/weijwang18) || [LinkedIn](https://www.linkedin.com/in/weijiewangseattle/)
>
>Alex Mcknight [Email](alex.mcknight11@gmail.com) || [GitHub](https://github.com/alex-mcknight11) || [LinkedIn](https://www.linkedin.com/in/alexmcknight11/)
>
>Tyler Emmerson [Email](tyleremmerson0216@gmail.com) || [GitHub](https://github.com/Emmersot) || [LinkedIn](https://www.linkedin.com/in/tyler-emmerson/)
>
>Jacob Palaoro [Email](jpalaoro197@users.noreply.github.com) || [GitHub](https://github.com/jpalaoro197) || [LinkedIn](https://www.linkedin.com/in/jacobpalaoro/)

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Derrak Richard && Zhibin Liang && Mo Byrne && Winnie Wang && Alex Mcknight && Tyler Emmerson && Jacob Palaoro. All Rights Reserved.


------------------------------

### 🌟 Acknowledgments

#### [Epicodus](https://www.epicodus.com/)
>"A school for tech careers... to help people learn the skills they need to get great jobs."

------------------------------

<center><a href="#">Return to Top</a></center>