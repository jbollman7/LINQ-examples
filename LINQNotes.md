Types of LINQ Execution

Immediate
Deferred Streaming
Deferred Non-streaming

Deferred Execution
A LINQ query is a data structure ready to execute
QUery is not executed until a value is needed


Immediate Execution
Creating the query and add .ToList() for example will execute the query immediately


Streaming operators
Results can be returned prior to the entire collection is ready
IE
Distinct(), GroupBy(), Join(), Select(), Skip(), Take(), Union(), Where()


var results = Products
	.Select(p=> p)
	.Where(p => p.Color = "Red");
	
Both Select() and Where() are deferred and streaming operators
- If they were not, then the Products collection would have to be looped through 2 times; once for the select, and once for the Where()


Non Streaming Operators
All data in collection must be read before a result can be returned
IE
Except(), GroupBy(), GroupJoin(), Intersect(), Join(), OrderBy(), ThenBy()
Also depends on the context, how they are used in the query.


Convert custom extension to be streaming, do this with the yield keyword
Non streaming is the least efficient computational

Deferred execution can be advantageous
-Better performance
- Less iterations

