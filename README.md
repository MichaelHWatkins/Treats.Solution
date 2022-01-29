# _Treats_

#### By _**{Mike Watkins}**_

#### _{An app that records Sweets and Flavors.}_

## Technologies Used

* _GitHub repositories_
* _C#_
* _.Net 5_
* _NuGet_
* _MySql_



## Description

_{Tells you how Flavors and Sweets are related.}_

## Setup/Installation Requirements

* _Install .NET Framework_
* _Navigate to https://github.com/MichaelHWatkins/Treats.Solution_
* _Click on the green "Code" button and copy the repository URL or click on the copy button_
* _Open the terminal on your desktop_
* _Once in the terminal, use it to navigate to your desktop folder_
* _Once inside your desktop folder, use the command "git clone https://github.com/MichaelHWatkins/Treats.Solution"_
* _After cloning the project, navigate into it using the command "cd Treats.Solution"_
* _Use the command "git remote -v" to confirm the creation of the new local repository_
* _Open the project with the code editor of your choice_
* _Navigate to Treats directory and enter command "dotnet restore"_
* _Create a file in production folder called appsettings.json_
* _Add the following to the .json file, {
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=michael_watkins.sql;uid=root;pwd=[YOUR PASSWORD];"
}
}_
* To recreate the database run "dotnet ef database update" which will trigger the migrations.
* _In Treats directory enter command "dotnet run"_

_Note: when using the commands listed above, do not include the quotation marks. They are used here for readability._

## Known Bugs

* _No known bugs_

## Contact Information
_michaelhugheswatkins@gmail.com_

## License
_MIT License: https://opensource.org/licenses/MIT_

Copyright (c) _2021_ _Michael Watkins_