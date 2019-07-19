# Sudoku Generator  
This is a sudoku generating single page application(SPA) written using ASP.NET, C#, MVC, jQuery, CSS, HTML and Bootstrap. SPA calls the Web API written in MVC and display valid sudoku puzzle with a unique solution each time you call the service.  

## Getting Started  
These instructions explain how to build and run this project on your local machine for development and/or testing purposes.  

### Prerequisites  
Microsoft Visual Studio 2017 (.Net Framework 4.6.1)    
Postman  

### Build and Run Locally  
1. Open the SudokuGenerator.sln file in Visual Studio.    
2. To build the project, choose Build Solution from the Build menu. The Output window shows the results of the build process.    
3. To run, on the menu bar, choose Debug, Start debugging/Start without debugging or by pressing F5. This will open the browser and run the project with https://localhost:64858 and will display the valid sudoku puzzle. It's also accessible via URL https://localhost:64858/home/index  

### Testing API via Postman  
To call the web api from Postman, use URL http://localhost:64852/sudoku/board using the GET request type.  

## Running the tests  
Test cases will run automatically when you build/rebuild the solution in MS Visual Studio.     
To run manually in MS Visual Studio: Test -> Windows -> Test Explorer -> Run All    
You can also run the test cases in command prompt by following instructions given below:
1. Run command prompt as an Administrator
2. Navigate to the path which has Vstest.console.exe file in cmd. For example: cd C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow
3. Run command: Vstest.console.exe "path to the test project dll". For example: Vstest.console.exe "E:\SudokuGenerator\SudokuGenerator\SudokuGenerator.Tests\bin\Debug\SudokuGenerator.Tests.dll"  

Test cases will call functions from the project and check for validity of generated sudoku.  

**Valid Sudoku:**     
ValidateSudokuBoard() will return true as it compliance with all the rules of sudoku.      

**Rules:**    
1. All 9 sub grid of 3×3 has unique elements from 1-9  
2. All rows contains unique elements beween 1-9  
3. All columns contains unique elements beween 1-9  

<img src="SudokuGenerator/Sudoku/Content/Images/Valid_Sudoku.PNG">    

**Invalid Sudoku Board:**    
ValidateSudokuBoard() will return false as it violates the rules of sudoku.  

**Rules Violated**  
1. 4 is twice in 3rd row   
2. 4 is twice in 1st 3*3 sub grid  
3. 6 is twice in 7th row  
4. 6 is twice in 6th column  
5. 0 is present in 5th column  

<img src="SudokuGenerator/Sudoku/Content/Images/Invalid_Sudoku.PNG">  

## Authors  

* **Nilam Savani** - *Initial work* - [Nilam Savani](https://github.com/nilamsavani)
