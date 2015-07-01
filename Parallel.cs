using System.Threading.Tasks;

static void _square(int n) 
{
    double squ = (double)n * (double)n;
    string harmonic = n.ToString();
    string str_squ = squ.ToString();
    Console.WriteLine("{0} ; {1}",n, squ);
}

static void Main(string[] args)
{
    int[] _array = new int[50];
    for (int i = 1; i <= _array.Length; i++)
    {
        _array[i - 1] = i;
    }
    Parallel.ForEach(_array, _square);
    Console.ReadLine();
}
