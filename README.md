# 🛒 ASP.NET-shop

> ⚠️ This project is created purely for **fun and experimental purposes**.  
> It is not a real online store and is intended to demonstrate basic logic, file generation, and system control features using **ASP.NET Core MVC**.

---

![C#](https://img.shields.io/badge/C%23-blue?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-MVC-black?style=for-the-badge&logo=dotnet)
![XML](https://img.shields.io/badge/XML-FF6600?style=for-the-badge&logo=xml&logoColor=white)

---

## 📦 Project Overview

This is a humorous C# ASP.NET Core MVC web application where:

- Users enter basic data (name, age, amount of money)
- The app generates an `.xml` file based on that input
- If the user chooses **option 1** *and* enters **1000 or more**, the system attempts to **shut down** the PC 💣

---

## ⚙️ Features

- 🖥 Web interface built with Razor Pages (Views)
- 📄 XML file generation based on user input
- 🤖 Simple logic-based system behavior (shutdown)
- 🧪 Demonstrates:
  - Controllers & Views in ASP.NET Core
  - User input handling
  - File creation (System.Xml)
  - Access to system commands (via `System.Diagnostics.Process`)

---

## 🚀 Tech Stack

| Category      | Technology             |
|---------------|------------------------|
| Language      | C#                     |
| Framework     | ASP.NET Core MVC 6.0   |
| UI            | Razor Pages, HTML      |
| Output        | XML File               |
| Runtime       | .NET 6 (Windows)       |
| Tools         | Visual Studio 2022     |

---

## 🧠 Purpose

> This project is **not a real shop**. It’s a learning project with a comic twist 😄  
It was built to:
- Explore basic ASP.NET MVC patterns
- Practice form handling and file I/O
- Show off some funny conditional logic
- Have fun experimenting with C# features

---

## 📂 Project Structure

ASP.NET-shop/
├── Controllers/
│ └── HomeController.cs
├── Models/
│ └── UserModel.cs
├── Views/
│ └── Home/
│ ├── Index.cshtml
│ └── Result.cshtml
├── Program.cs
├── appsettings.json