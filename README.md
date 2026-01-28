# store
To run this project, please execute the DatabaseScript.sql in your SQL Server first, then update the connection string in app.config.
## ⚙️ How to Run (วิธีใช้งาน)

1. **Database Setup:**
   - Open SQL Server Management Studio (SSMS).
   - Create a new database named `StoreManagement`.
   - Run the script `DatabaseScript.sql` included in this repository to generate tables and stored procedures.

2. **Configuration:**
   - Open the solution `StoreManagement.sln` in Visual Studio.
   - Open `App.config` file.
   - Update the `connectionString` to match your SQL Server instance (e.g., change Data Source to `.` or `(local)`).

3. **Run:**
   - Press `F5` or click **Start** to run the application.

