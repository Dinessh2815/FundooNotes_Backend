# 📝 Fundoo Notes - Backend API

A robust and scalable RESTful API backend for the Fundoo Notes application, built with **ASP.NET Core** and **Entity Framework Core**. This backend provides comprehensive note-taking functionality with user authentication, labeling, and collaboration features.

## 🌐 Frontend Repository

The frontend for this project is built with Angular and can be found here:  
**[FundooNotes_Frontend](https://github.com/Dinessh2815/FundooNotes_Frontend/tree/dev)**

---

## 🚀 Features

- **User Authentication & Authorization**
  - JWT-based authentication
  - User registration with email verification
  - Password reset functionality
  - Secure login/logout

- **Notes Management**
  - Create, read, update, and delete notes
  - Archive and trash functionality
  - Permanent deletion of notes
  - Restore notes from trash

- **Labels & Organization**
  - Create and manage custom labels
  - Assign multiple labels to notes
  - Filter notes by labels

- **Collaboration**
  - Share notes with other users
  - Manage collaborators on notes
  - Collaborative note editing

- **Email Notifications**
  - SMTP email service integration
  - RabbitMQ message queue for async email processing
  - Email verification and password reset emails

---

## 🛠️ Technology Stack

- **Framework:** ASP.NET Core 6.0+
- **Database:** SQL Server (Entity Framework Core)
- **Authentication:** JWT (JSON Web Tokens)
- **Messaging:** RabbitMQ
- **Email:** SMTP (Gmail)
- **Architecture:** Layered Architecture (Presentation, Business, Data, Model)
- **API Documentation:** Swagger/OpenAPI

---

## 📂 Project Structure

```
FundooNotes_Backend/
├── PresentationLayer.Fundoo/    # API Controllers & Configuration
├── BusinessLayer/                # Business Logic & Services
├── DataBaseLayer/                # Entity Framework & Repositories
├── ModelLayer/                   # DTOs & Data Models
└── FundooNotes.Tests/           # Unit & Integration Tests
```

---

## ⚙️ Prerequisites

Before running this project, ensure you have the following installed:

- **.NET SDK 6.0** or higher
- **SQL Server** (LocalDB or Full Instance)
- **RabbitMQ** (for message queue functionality)
- **Visual Studio 2022** or **VS Code** (recommended)

---

## 🔧 Installation & Setup

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/Dinessh2815/FundooNotes_Backend.git
cd FundooNotes_Backend
```

### 2️⃣ Configure Connection String

Update the `appsettings.json` file in `PresentationLayer.Fundoo/` with your database connection:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=FundooNotesDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 3️⃣ Configure JWT Secret

Update the JWT secret in `appsettings.json`:

```json
"Jwt": {
  "Secret": "your-secure-secret-key-here",
  "ExpiryMinutes": 120
}
```

### 4️⃣ Configure SMTP Settings

For email functionality, update SMTP settings in `appsettings.json`:

```json
"SmtpSettings": {
  "Host": "smtp.gmail.com",
  "Port": "587",
  "EnableSsl": "true",
  "FromName": "Fundoo Notes"
}
```

### 5️⃣ Setup RabbitMQ

Ensure RabbitMQ is running on your machine. Default configuration:

```json
"RabbitMQ": {
  "HostName": "localhost",
  "Port": 5672,
  "UserName": "guest",
  "Password": "guest"
}
```

### 6️⃣ Apply Database Migrations

Run the following commands to create the database:

```bash
dotnet ef database update --project DataBaseLayer --startup-project PresentationLayer.Fundoo
```

### 7️⃣ Run the Application

```bash
cd PresentationLayer.Fundoo
dotnet run
```

The API will start at: **`https://localhost:7XXX`** or **`http://localhost:5XXX`**

---

## 📖 API Documentation

Once the application is running, navigate to:

```
http://localhost:5XXX/
```

or

```
https://localhost:7XXX/
```

Swagger UI will be available at the root endpoint, providing interactive API documentation.

---

## 🔐 API Endpoints

### Authentication
- `POST /api/auth/register` - Register new user
- `GET /api/auth/verify-email` - Verify email address
- `POST /api/auth/login` - User login
- `POST /api/auth/forgot-password` - Request password reset
- `POST /api/auth/reset-password` - Reset password
- `GET /api/auth/me` - Test JWT authentication

### Notes
- `POST /api/notes` - Create note
- `GET /api/notes` - Get all notes
- `PUT /api/notes/{noteId}` - Update note
- `DELETE /api/notes/{noteId}` - Move note to trash
- `GET /api/notes/deleted` - Get trashed notes
- `PUT /api/notes/{noteId}/restore` - Restore note
- `DELETE /api/notes/{noteId}/permanent` - Permanently delete note

### Labels
- `POST /api/labels` - Create label
- `GET /api/labels` - Get all labels
- `PUT /api/labels/{labelId}` - Update label
- `DELETE /api/labels/{labelId}` - Delete label
- `POST /api/notes/{noteId}/labels/{labelId}` - Add label to note
- `DELETE /api/notes/{noteId}/labels/{labelId}` - Remove label from note

### Collaborators
- `POST /api/notes/{noteId}/collaborators` - Add collaborator
- `DELETE /api/notes/{noteId}/collaborators/{userId}` - Remove collaborator

---

## 🧪 Running Tests

```bash
dotnet test
```

---

## 👤 Author

**Dinessh2815**  
GitHub: [@Dinessh2815](https://github.com/Dinessh2815)

---

## 📄 License

This project is open source and available for educational purposes.

---

## 🔗 Related Links

- **Frontend Repository:** [FundooNotes_Frontend](https://github.com/Dinessh2815/FundooNotes_Frontend/tree/dev)

---
