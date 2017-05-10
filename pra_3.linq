<Query Kind="Expression" />

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new
			  {
			  TrackCount = g.Track.Count(),
			  Track = from t in g.Tracks
			  select new
				{
				TrackName = t.Name,
				AblumsName = t.Ablums.Title,
				Milliseconds = t.Milliseconds,
				Size = (t.bytes / 1000)+"kb",
				Price = t.UnitPrice
				}
			  };
			  results.Dump("Query math 1");
			  