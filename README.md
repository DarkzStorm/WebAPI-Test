<a name="readme-top"></a>
# Web API - Test

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

<!-- ABOUT THE PROJECT -->
## About The Project

![image](https://user-images.githubusercontent.com/26399414/228475173-2060bdab-5503-4f2d-bda5-6f55e9129156.png)


A basic CRUD Web API createed using ASP.NET Core Web API Template

Here's why:
* Demostrating Create, Read, Update and Delete operations using ASP.NET Core Web API template
* Search information using given parameters
* Experimenting with in-memory caching (in-progress)


<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Built With
* ASP.NET Core
* Swagger


<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

This project was created in Visual Studio 2022 Community Edition. To get started you will require to use any version of Visual Studio that can support .NET 6.

### Prerequisites

Download or clone the repo in Visual Studio Code or Visual Studio 2022. Install .NET 6
* Clone the repo
  ```sh
  git clone https://github.com/DarkzStorm/WebAPI-Test.git
  ```
* Create and connect to the database, you may refer TestDB.sql to create TestDB and the UserInformation table. Change DefaultConnection path in appsettings.json to reflect your database path.


<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage

### Parameters

* Get: Id
* Create: FullName, Email, PhoneNumber, Age, type in request body
* Update: Id, edit in request body for FullName, Email, PhoneNumber, Age
* Delete: Id
* Search: Email, PhoneNumber, SortField to enter either FullName, Email, PhoneNumber or Age as parameter


<p align="right">(<a href="#readme-top">back to top</a>)</p>
