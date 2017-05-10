<Query Kind="Statements">
  <Connection>
    <ID>8d4ebb39-e3e3-47d1-b678-6c8cc8f53dac</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              select new
			  {
			  Name = m.Name,
			  Track = m.Tracks
			  };
			  results.Dump();
			  
			  
			  