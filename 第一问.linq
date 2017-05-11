<Query Kind="Statements">
  <Connection>
    <ID>06026aed-7390-4ab9-90b8-6bf575d34bcf</ID>
    <Server>.\SQLEXPRESS</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

var results = from x in Skills
              orderby x.Description
			  select new
			  {
			     Accountant = x.Description
			};
results.Dump();