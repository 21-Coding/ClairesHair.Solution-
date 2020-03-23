# Hair Salon

## By **Dominique Youmans**



### Description

This application allows the user to develop a client list with an associated stylist list to match.

### Sql
```

CREATE DATABASE `dominique_youmans`;
USE `dominique_youmans`;  
CREATE TABLE `clients` (  
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,  
  `ClientName` varchar(255) DEFAULT NULL,  
  `Phone` varchar(255) DEFAULT NULL,  
  `StylistId` int(11) DEFAULT NULL,  
  PRIMARY KEY (`ClientId`)  
);
CREATE TABLE `stylists` (  
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,  
  `StylistName` varchar(255) DEFAULT NULL,  
  `StylistCell` varchar(255) DEFAULT NULL,  
  `Skillset` varchar(255) DEFAULT NULL,  
  PRIMARY KEY (`StylistId`)  
);

```
   

   


### Specs
|Behavior| Input | Output | 
|--|--|--|
|User creates a stylist  | post request  |	Stylist is now added to table |
|	User enters localhost | get request |Stylists displayed |
|User creates a client | post request | Client is now added to table |
|User deletes client | patch request | Client is deleted |
|User deletes stylist | patch request | Stylist is deleted |
|User updates client | post request | Client is updated |
|User updates stylist | post request | Stylist is updated |
|User can see clients and associated stylist | get request | List is displayed with one to many relationship |





### Known Bugs

Database connection issues.

### Support Details

If you run into any issues running this application, please contact Dominique Youmans at ddyoumans@icloud.com.

### Technologies Used

 - [x] .NET
 - [x] C#
 - [x] HTML
 - [x] CSS


### License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Copyright (c) 2020 **_Dominique Youmans_**
