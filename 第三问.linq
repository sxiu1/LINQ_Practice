<Query Kind="Statements">
  <Connection>
    <ID>06026aed-7390-4ab9-90b8-6bf575d34bcf</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from y in Skills
		where y.RequiresTicket==true
              select new
			  {
			  Description = y.Description,
			  Employees= from t in y.EmployeeSkills
			  orderby t.YearsOfExperience descending
			  select new
				{
					Name = t.Employee.FirstName +" "+t.Employee.LastName,
					Level = t.Level,
					YearsOfExperience = t.YearsOfExperience
				}
			};
  
results.Dump();