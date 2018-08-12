# Lambda

I built a Student class in my project, and then queried it using Lambda Expressions.


1. Write a LINQ query using Lambda Expressions.
2. Use IEnumerable and store it in "QueryResult"
3. Bind to GridView.

Lambda Expression:
IEnumerable<Student> QueryResult = Student.GetAllStudents().Where(student => student.Gender == "Male")

Display the data in a GridView:
GridView1.DataSource = QueryResult

Invoke the data bind method to the GridView.
GridView1.DataBind()
