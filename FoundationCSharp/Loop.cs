//for loop
for (int step = 1; step <= 10; step++)
{
    if (step <= 5)
    {

        Console.WriteLine(step + "Floor");
        // this make the output slow
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine(11 - step + "Floor");
        Thread.Sleep(1000);
    }
}

//while loop if there is unexpected condition then we have to use while loop

bool flag = true;
int c = 100;
while (flag)
{
    if (c >= 110)
    {

    flag = false;
    }
    c++;

Console.WriteLine("hello saroj");
}

