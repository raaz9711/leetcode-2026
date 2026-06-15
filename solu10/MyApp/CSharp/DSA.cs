namespace DSAImp;

public class Bug
{
    public  int Priorty  { get; set; }
    public string Name {get;set;}

    public bool IsResolve {get;set;}

    public override string ToString()
    {
        return $"Priorty -> {Priorty} \n Name -> {Name} \nIsResolve -> {IsResolve} \n";
    }
    
}

public class Helper
{
    public PriorityQueue<Bug,int> pq = new();

    public void AddElement()
    {
        this.pq.Enqueue(new Bug()
        {
            Priorty = 1,
            Name = "Critical",
            IsResolve = false
        },3);

        this.pq.Enqueue(new Bug()
        {
            Priorty = 2,
            Name = "Medium",
            IsResolve = false
        },2);

        this.pq.Enqueue(new Bug()
        {
            Priorty = 3,
            Name = "Low",
            IsResolve = false
        },1);
    }
}


public class DSA
{
    public static void QueueImplementation()
    {
        Queue<string> list = new();
        list.Enqueue("raj");
        list.Enqueue("kumar");
        list.Enqueue("singh");

        while(list.Count > 0)
        {
            Console.WriteLine(list.Dequeue());
        }
    }
}