# Pierre's Sweet and Savory Treats.

by Sean Julius

This webpage is designed to give an introduction to Sean Julius's beginnings in coding.
Technologies Used
* _C#_
* _SQL Workbench_
* _.NET 5.0_
* _REPL_
* _VS Code_
* _Razor_
* _Bootstrap_


## Description:

This program allows the application add, remove, and manage flavors and treats. First you will have to register a user name and password then login in order to manipulate the data.

## Application Setup Instructions

* _Clone this repository to your desktop._
* _Navigate the directory: (cd PierresTreats)_
* _Download MySql WorkBench_
* _Open MySql WorkBench_
* _Importing [pierres_treats.sql] from PierresTreats._
  * _Administration window then Data Import/Resore._
  * _Import Options then Import from Self-Contained File. [pierres_treats.sql] from [PierresTreats]._
  * _Import Progress then Start Import._
  * _Reopen Navigator then Schemas tab then right click then refresh all._
* _Navigate to the "PierresTreats" ._
* _Open in Vs code: code ._
* _Open Terminal in Vs Code._
* _Go to PierresTreats Directory._
* _Create folder: $ cd "appsettings.json"_
* _Add Following code to "appsettings.json"_
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=pierres_treats;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
* _Run: dotnet restore_
* _Run: dotnet build_
* _Run: dotnet run_
* _Open web Browser: http://localhost:5000/_

## Known Bugs

No known bugs

## Licensing

Copyright (c) 2022 Sean Julius
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

## Description

This project allows the user to add a number representing the United States currency. Then from a drop down field select the country that the user would like to see the US currency converted to. Then the user just has to press "Get Rate" and the currency will be converted.