https://youtu.be/cOZAEJ9VWEg
This section summarizes the major upgrades from the Part 1 prototype to the Part 2 functional MVC application, addressing all feedback and rubric requirements.

Architectural Shift: Migrated the project from a static HTML/JavaScript front-end prototype (Part 1) to a fully functional, server-side .NET Core MVC application (Part 2).

Data Management: Replaced the JavaScript-based data simulation with a C# in-memory database (AppDbContext and UseInMemoryDatabase), managed by Entity Framework Core.

Business Logic: Created the ClaimsController in C# to handle all server-side logic, data validation, and user actions, moving this responsibility from the front-end.

Model Expansion: Updated the Claim.cs model to include the new required fields: HoursWorked, HourlyRate, and Notes. Created User.cs and various ViewModel classes to pass data cleanly to the views.

Enhanced Lecturer View: Rebuilt the Lecturer.cshtml view to be a dynamic, data-driven form that posts to the SubmitClaim controller action.

New Admin Views: Added two new, distinct views as requested in the Part 1 feedback ("add more UI"):

Coordinator.cshtml: A view for Programme Coordinators to see only claims "Pending Verification" and "Verify" or "Reject" them.

Manager.cshtml: A view for Academic Managers to see only "Verified" claims and "Approve" or "Reject" them.

Robust File Upload: Implemented server-side file handling in the ClaimsController that:

Validates file size (5MB limit).

Validates file type (accepts only .pdf, .docx, .xlsx).

Displays specific error messages back to the user on the form.

Saves valid files to the server's wwwroot/uploads directory.

Functional Status Tracking: Implemented the complete claim lifecycle. When an admin changes a claim's status (e.g., from "Pending Verification" to "Verified"), the change is saved to the in-memory database and is immediately and accurately reflected in the Lecturer's "Claim History" table.

User Simulation: Added a user-switching dropdown in the _Layout.cshtml file to simulate logging in as different roles (Lecturer, Coordinator, Manager) without a full login system.

Unit Testing: Created a new xUnit test project and implemented 5+ unit tests to ensure the controller's logic (especially validation and status changes) is reliable.
