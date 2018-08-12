# Lambda

I built a Student class in my project, and then queried it using a LINQ query with Lambda Expressions.

1. Write a LINQ query using Lambda Expressions and use IEnumerable and store it in "QueryResult": 
IEnumerable<Student> QueryResult = Student.GetAllStudents().Where(student => student.Gender == "Male")

2. Display the data in a GridView: GridView1.DataSource = QueryResult

3. Invoke the data bind method to the GridView: GridView1.DataBind()
