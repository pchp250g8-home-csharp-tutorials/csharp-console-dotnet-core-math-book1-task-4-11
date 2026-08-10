float i1 = 91.7F; /*Percentage of participants who successfully completed the distance. 
                   *The 1st part of the interval*/
float i2 = 91.8F; /*Percentage of participants who successfully completed the distance. 
                   *The 2nd part of the interval*/
float r1 = i1 / 100; /*The 1st rational fraction*/
float r2 = i2 / 100; /*The 2nd rational fraction*/
bool found = false;
uint n = 0;
Console.WriteLine("Between 91.7% and 91.8% of participants successfully completed the race.");
Console.WriteLine("What is the minimum number of participants?");
while (!found)
{
    /* Find the smallest integer k that is strictly greater than the lower bound */
    var k = Math.Floor(r1 * n) + 1;
    /* Check if this k satisfies the upper bound */
    if (k < r2 * n)
    {
        Console.WriteLine("Minimum number of participants (N):{0}", n);
        found = true;
    }
    else
    {
        n += 1;
    }
}
Console.Read();
