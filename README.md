# Listura – Task Management Web API (In Development)

Listura is a modular task management backend inspired by Todoist, built using **ASP.NET Core Web API**,  
**Entity Framework Core**, and **SQL Server**.  
The project focuses on clean domain modeling, scalable architecture, and secure authentication using ASP.NET Identity.

---

##  Features

### User Authentication & Authorization
- ASP.NET Core Identity integration  
- Secure password hashing  
- Per-user data isolation  
- Token-based authentication (JWT planned)

### Project Structure
- Users → Projects → Sections → Tasks → Subtasks  
- Individual Labels and Reminders  
- Many-to-many support between Tasks and Labels

### Task Management
- Task creation, updating, and organization under sections  
- Subtasks for finer work breakdown  
- Priority levels, descriptions, and due dates  
- Repeat patterns (daily, weekly, biweekly, monthly, etc.)

###  Labels & Tagging
- User-specific custom labels  
- Many-to-many relationship with tasks (TaskLabels join table)

###  Reminders
- Create reminder entries linked to tasks  
- Structured for future background notification service

---


##  Project Architecture

AppUser (Identity)
↓ 1-many
Project
↓ 1-many
Section
↓ 1-many
TaskItem
↓ 1-many
SubTask

Tasks also connect to: TaskItem ↔ TaskLabel ↔ Label
                      TaskItem → Reminder


---

## Technologies Used

- **ASP.NET Core 8 Web API**
- **Entity Framework Core**
- **SQL Server / LocalDB**
- **ASP.NET Core Identity**
- **C# 12**
- **Swagger for API documentation**
- **Visual Studio 2022**

---

##  Folder Structure
```
  Listura_v1.0/
  │
  ├── Models/
  │ ├── AppUser.cs
  │ ├── Project.cs
  │ ├── Section.cs
  │ ├── TaskItem.cs
  │ ├── SubTask.cs
  │ ├── Label.cs
  │ ├── TaskLabel.cs
  │ ├── Reminder.cs
  │ └── BaseEntity.cs
  │
  ├── Enums/
  │ ├── TaskPriority.cs
  │ ├── TaskStatus.cs
  │ └── TaskRepeat.cs
  │
  ├── Data/
  │ └── ListuraDbContext.cs
  │
  └── ...
```

---

##  Roadmap

- [ ] Complete full CRUD for all entities  
- [ ] Implement JWT token issuance  
- [ ] Add Role-based access  
- [ ] Add background reminder scheduler  
- [ ] Create API documentation & client integration  
- [ ] Deploy API to Azure  

---

##  Contributions

This is a personal learning project, but suggestions and improvements are welcome through issues or pull requests.

---

##  License

This project is open-source under the MIT License.
