# 🎓 Ugarit Gradebook

> An institutional student management and academic grading system designed to securely track enrollment, course progress, and student evaluations.

---

### 🚀 Key Features
* **Academic Tracking:** Secure CRUD operations for managing students, courses, and semester grades.
* **Role-Based Access:** Differentiated dashboard views and permissions for educators and administrators.
* **Data Integrity:** Relational database design ensuring accurate mapping between students, their enrolled courses, and their grade records.
* **Reporting:** Automated calculation of GPA and academic standing.

---

### 🛠️ Tech Stack
* **Core Logic:** [e.g., PHP / Python / Java]
* **Database:** [e.g., MySQL / PostgreSQL]
* **Frontend:** [e.g., HTML, CSS, JavaScript]

---

### ⚙️ Quickstart

#### 1. Database Initialization
* Create a local database named `ugarit_gradebook`.
* Import the provided `schema.sql` file to generate the required tables and relationships.

#### 2. Environment Setup
Create a `.env` or configuration file with your database credentials:
```env
DB_HOST=localhost
DB_NAME=ugarit_gradebook
DB_USER=root
DB_PASS=your_password
