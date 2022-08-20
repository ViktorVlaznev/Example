int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 123;
int b1 = 5;
int c1 = 134;
int a2 = 5555;
int b2 = 3445;
int c2 = 1432;
int a3 = 6341;
int b3 = 4934;
int c3 = 423;

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine(max);