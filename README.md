# Gantz Bakery Order tracking


#### By: _Mitchell Gantz_

#### _Tracking Vendors and Orders._

## Technologies Used

- _C#_
- _.NET 6_
- _MSTest_

## Description/Objectives

- _Use Razor to display information on each page._
- _Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor._
- _Create an Order class. This class should include properties for the title, the description, the price, the date._
- _The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Gantz and providing him with a link to a Vendors page_
- _The vendors page should contain a link to a page presenting Gantz with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Gantz should be routed back to the homepage_
- _Gantz should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders_
- _Gantz should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new"._

## Setup/Installation Requirements 

* clone this repo & navigate to the GantzOrders directory
* open a command line interface within the GantzOrders directory and run the following commands:
* build the project using $ `dotnet build`
* execute code with $ `dotnet run`

## Testing Instructions

* To run tests, first install/setup as detailed above
* navigate to the GantzOrders.Tests directory and open a command line interface
* run tests by executing $ `dotnet test`
* if additional tests are required, first modify the existing test file within the correct folder before running `dotnet test` again

## Known Bugs

- _If you find additional bugs not listed here, please email me at mgantz22@icloud.com with the subject_ **[_Repo Name_] Bug** _and include:_
  - BUG: _A brief description of the bug_
  - FIX: _Suggestion for solution (if you have one!)_
- _If you'd like to be credited, please also include your_ **_github user profile link_**

## Furture Implementations
- _Custom backgrounds for each vendor_
- _Interavtive page_
- _More styling_

## License

_MIT License_

Copyright (c) _2023_  _Mitchell Gantz_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS 
BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE
OR OTHER DEALINGS IN THE SOFTWARE.