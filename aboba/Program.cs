using System.Diagnostics;

int[] arr = new int[64 * 1024 * 1024];

for (int x = 1; x < 65; x <<= 1)
{
    Stopwatch sw = new Stopwatch();
    sw.Start();
    for (int i = 0; i < arr.Length; i += x) arr[i] *= 3;
    sw.Stop();
    Console.WriteLine(sw.ElapsedMilliseconds);
}