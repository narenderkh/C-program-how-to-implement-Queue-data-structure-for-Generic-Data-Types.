class Lst<T>
{
    private const int MAXSIZE = 100;
    private int front = 0;
    private int rear =0;
    // private T[] arr = new T[100];
    private T[] arr;
    private int numofelements =0;
     public  Lst()
    {
       this.arr = new T[MAXSIZE];
          
            
    }

   /* public  Lst ( int size)
    {
        this. arr = new T[size];
         
    } */  

   public void Enqueue(T item)
    {
        if (numofelements == MAXSIZE)
        {
            throw new Exception("Queue Full");

        }
        
        arr[rear] = item;
        rear++;
        numofelements++;
      


    }
    public T Dqueue()
    {
        T item;

        if (numofelements == 0)
        {
            throw new Exception("Queue Empty");

        }
        
        item = arr[front];
        front++;
        numofelements--;
        return item;
            
    }


}

class Program
{
    static void Main()
    {
        Lst<int> L = new Lst<int>();

        
        L.Enqueue(50);
        L.Enqueue(60);
        L.Enqueue(70);
        L.Enqueue(80);
       

        int item = L.Dqueue();
        Console.WriteLine(item);
        
         item = L.Dqueue();
        Console.WriteLine(item);

        item = L.Dqueue();
        Console.WriteLine(item);

        item = L.Dqueue();
        Console.WriteLine(item);

        
    }


}

