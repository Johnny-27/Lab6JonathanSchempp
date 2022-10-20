//Stack with no parameters

void StackNoParams ()
{
    int x = 1;
    int y = 2;
    int z = 3;
    int v = 4;
    int k = 5;
}

double StackWithParams (double a)
{
    double b = 8;
    double c = 10;
    double d = 12;
    double e = a + b + c + d;
}

string StackWithHeap (string t) 
{
    int w = 7;
    int u = 9;
    int i = 11 + u;
}

void StackOver () 
{
    void StackOver ()
    {
        void StackOver ();
    }
}

//Driver Program