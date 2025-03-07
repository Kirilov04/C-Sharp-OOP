int n;
n = 100;
List<int> q = new List<int>();

while (n > 0)
{
    q.Add(n % 3);
    n /= 3;
}

while (q.Count > 0)
{
    Console.WriteLine(q);
}
Queue<int> s = new Queue<int>();