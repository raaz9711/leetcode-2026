using DSAImp;


var q = new Helper();
q.AddElement();

List<Bug> list = new List<Bug>();

while(q.pq.Count > 0)
{
    var v = q.pq.Dequeue();
    Console.WriteLine(v.Priorty);
    Console.WriteLine("---------------");
    v.IsResolve = true;
    v.Priorty *= 10;
    list.Add(v);
}

foreach(var a in list)
{
    Console.WriteLine(a.ToString());
}