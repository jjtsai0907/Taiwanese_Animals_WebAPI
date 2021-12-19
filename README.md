# Taiwanese_Animals_WebAPI

This is a school project for a Backend course. The aim of this is to create a simple Web-API that implements CRUD, Create Read Update Delete.

# Basic Info
- Windows 10
- Visual Studio 2022  v.17.0.2
- ASP .NET Core Web API
- C#
- Framework - .NET 6.0

# Request Methods
- **GET /api/taiwanese_animal**                
  *to list all of the animals*.
  
- **GET /api/taiwanese_animal/{id}**               
  *to return an animal with the corresponding id number*.
  
- PUT /api/taiwanese_animal/{id}             
  *to update an aniamal with the corresponding id number*.
  
- DELETE /api/taiwanese_animal/{id}           
  *to delete an aniamal with the corresponding id number*.
  
- POST /api/taiwanese_animal              
  *to create a new aniamal*.
 
# Animal.cs
The Animal Class has the following as properties:
- ID (int, is unique)
- EnglishName (string)
- LatinName (string)
- Type (string)
- ImageURL (string)

# Data
The data of animals is hard coded in the AnimalRepo file.

# HTTP Status
I have implemented IActionResult to display corresponding HTTP status after each request.

# Screenshots

## GET - get all of the Tawianese animals
![Get all of the Tawianese animals](https://github.com/jjtsai0907/Taiwanese_Animals_WebAPI/blob/master/Taiwanese_Animals_WebAPI/Screenshots/GET%20Taiwanese%20Animals%20API.png)

## GETONE - get an animal with the corresponding id number
![Get an animal with the corresponding id number](https://github.com/jjtsai0907/Taiwanese_Animals_WebAPI/blob/master/Taiwanese_Animals_WebAPI/Screenshots/GETONE%20Taiwanese%20Animals%20API.png)

## PUT - update an aniamal with the corresponding id number
![Update an aniamal with the corresponding id number](https://github.com/jjtsai0907/Taiwanese_Animals_WebAPI/blob/master/Taiwanese_Animals_WebAPI/Screenshots/PUT%20Taiwanese%20Animals%20API.png)

## DELETE - delete an aniamal with the corresponding id number
![Delete an aniamal with the corresponding id number](https://github.com/jjtsai0907/Taiwanese_Animals_WebAPI/blob/master/Taiwanese_Animals_WebAPI/Screenshots/DELETE%20Taiwanese%20Animals%20API.png)

## POST - create a new aniamal
![Create a new aniamal](https://github.com/jjtsai0907/Taiwanese_Animals_WebAPI/blob/master/Taiwanese_Animals_WebAPI/Screenshots/POST%20Taiwanese%20Animals%20API.png)
