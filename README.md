# Todo App

A prototype for a Todo application with basic implementation for creating users and CRUD operations for Todo items.

---

## Entities

- **User**: Represents a user in the application.
- **Tasks**: Todo items associated with a user.
- **Project**: A project that contains tasks (Todo items).

---

## Database

- **MongoDB**: NoSQL database used for storing user data, tasks, and projects.

---

## Design Patterns Used

- **Factory Pattern**: Used for creating objects based on certain parameters.
- **Builder Pattern**: Used for creating complex objects by providing a simple interface.
- **Mediator Pattern**: Used to reduce dependencies between objects by centralizing communication.
- **CQRS (Command Query Responsibility Segregation)**: Segregates reading and writing operations for better scalability.
- **Repository Pattern**: Abstracts the data access layer for easier maintenance and testing.

---

## Features

You can try out the following scenarios with this app:

- **Create User**
- **Add Todo Item**
- **Edit Todo Item**
- **Get Todo Item**
- **Get All Todo Items**
- **Delete Todo Item**

---

## Postman Collection

- **[Download the Postman Collection](https://github.com/fatmaashraframadan/todo-backend/blob/main/todo-.Net.postman_collection.json)**: Download the collection to test the API.
- **[View Postman Documentation](https://documenter.getpostman.com/view/10825556/2sAYHzF2qp)**: View API documentation for detailed requests and responses.

---

## Getting Started

1. **Clone the repository**:
   ```bash
   git clone https://github.com/fatmaashraframadan/todo-backend.git
2. Download .net 8.0
3. Download Mongodb & run it.
4. Download Mongodb driver.
