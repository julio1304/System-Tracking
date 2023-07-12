<h1>Time Clock Web Application</h1>
<b>Client:</b> AFC Sushi Retail Store Owner<br>
<b>Used:</b>Blazor, C#, HTML, CSS, JavaScript

<b>Purpose:</b> To provide a business tool to manage employee's time clock.

<b>Key requirements:</b>
- simple and minimalistic design to shorten the training period and maximize the usability for the employees.
- track accurate times for employees’ work hour
- admin access to the client to manage employee and time clock records

<b>Two roles:</b>
- The user (employee) will have access to TimeClock Page and Employee-Timesheet page.
- The admin (client) will have additional access to Admin-Employee, Admin-Timesheet, and Admin-Export/Delete.

<b>Time Clock Homepage</b><br>
![Time Clock Homepage](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/TimeClock.png?raw=true)<br>
Employees will clock in and clock out by entering four digit unique employee ID created by the admin. Today's Status will provide live update of today's activity.

<b>Employee-Timesheet Page</b><br>
![Employee-Timesheet Page](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/Admin-Timesheet.png?raw=true)<br>
Employees can check their worked hours by typing their employee ID and selecting date range.<br>At the bottom, the program will auto-calculate total hours worked based on the date range.<br>

<b>Login Page</b><br>
![Login Page](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/Login.png?raw=true)<br>
Admin can gain access by logging in. Admin can reset the password (used SendGrid to send emails) if needed. One account was preset to the client.

<b>Admin-Employee Page</b>
![Admin-Employee](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/Admin-Employee.png?raw=true)<br>
Admin can view registered employees. For the employees to use this application, they must be registered on the Admin-Employee page. The pencil icon will allow the admin to edit or delete the selected employee.

<b>CRUD Employee</b>
![CRUD Employee](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/CRUDEmployee.png?raw=true)<br>
Admin can add/edit/delete employees.

<b>Admin-Timesheet Page</b>
![Admin-Timesheet](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/Admin-Timesheet.png?raw=true)<br>
Admin can filter employeee ID and date to browse through all the time clock records. The pencil icon will allow the admin to edit or delete the selected record.

<b>CRUD Record</b><br>
![CRUD Record](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/CRUDRecord.png?raw=true)<br>
Admin can add/edit/delete records.

<b>Admin-Export/Delete Page</b>
![Admin-ExportDelete](https://github.com/hgchoi1116/TimeClock-BlazorServerWebApplication/blob/master/Images/Admin-ExportDelete.png?raw=true)<br>
Admin specify the date range and download the record database in .csv file to keep a backup or to open the database in MS Excel. Also, the admin can delete the records to keep the database clean.
