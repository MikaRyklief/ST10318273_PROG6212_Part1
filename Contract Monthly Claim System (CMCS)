Contract Monthly Claim System (CMCS)

Project Overview

The Contract Monthly Claim System (CMCS) is a .NET Core-based web application designed to streamline the process of submitting, verifying, and approving monthly claims for Independent Contractor (IC) lecturers. This system simplifies the administrative workflow by enabling lecturers to submit their claims along with supporting documents and allowing program coordinators and academic managers to review and approve those claims. The goal is to increase efficiency, ensure accuracy, and provide transparency throughout the claim process.

The system’s current version only includes the front-end interface, which is built using ASP.NET Core MVC and Bootstrap for styling. This prototype does not yet connect to backend logic or a database but offers a working user interface as a visual representation of how the system would function.

Features

Submit Claims: Lecturers can easily submit new claims by filling out a form, including details such as the claim date, total amount, and uploading supporting documents.
View Claims: Users can see a list of submitted claims, including relevant details such as claim ID, lecturer name, claim date, total amount, and current status.
Role-Based Interaction: Program coordinators and academic managers can track, verify, and approve claims.
Responsive Design: The system’s UI is built with Bootstrap to ensure a consistent and responsive design across various devices.

Project Structure

ASP.NET Core MVC: The project is structured using the MVC (Model-View-Controller) design pattern, though this phase focuses only on the front-end, with no backend or database implementation.
Views: The UI is built with Razor Views (Index.cshtml), providing the form and table layout for claim submission and review.
Static Design: All interactions and data (e.g., claims, forms) are static and used for prototyping purposes.

Database Structure (Future Implementation)

The database will consist of several key entities:

Lecturer: Represents an independent contractor lecturer who submits claims.
Claim: Contains details of each submitted claim, such as the claim date, total amount, and associated lecturer.
Supporting Document: Files uploaded by lecturers to support their claims.
Staff: Base entity for both Program Coordinator and Academic Manager, who oversee the claim process.
Program Coordinator and Academic Manager: Inherited entities from Staff, responsible for reviewing and approving claims.

Design Choices

The CMCS was built using ASP.NET Core MVC for its robust architecture, separation of concerns, and ease of scaling. The user interface was designed with Bootstrap to ensure a clean and responsive layout, providing a simple and intuitive workflow for users. In terms of database structure (to be implemented later), the decision to have Program Coordinator and Academic Manager inherit from Staff ensures clean code reusability and maintains consistency when managing staff roles.

Future Enhancements

Backend Logic: Implement backend logic using C# and .NET Core to process claims and connect the UI to a database.
Database Integration: Set up the database using either SQL Server or Oracle, and create the necessary tables and relationships to store claim data.
Authentication: Introduce role-based authentication so that only authorized users (lecturers, coordinators, managers) can access certain features.

License

This project is licensed under the MIT License - see the LICENSE file for details.
