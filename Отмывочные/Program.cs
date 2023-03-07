double[] diametr206 = new double[] { 0.581, 0.581, 2, 2 };          // 206 -  1,2
double[] height206 = new double[] { 0.341, 0.67, 14.23 };           // 206 -  1,2 0,5

int kolvoPos206=2;                                                  // поз. 206 отмывочные колоны 2шт.

void PrintArray(double[] numbers, string msg)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(msg + (i+1) + " = " + numbers[i] + " ");
        Console.WriteLine(" ");
    }
    Console.WriteLine();
}
double Input(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    double VvodimoeChislo = double.Parse(number);
    return VvodimoeChislo;
}
double Vol(double input, double [] diametr, double [] height)
{
    double FindVolume(double D1, double D2, double height)
    {
        double pi = 3.14;
        double v = (pi * height * (Math.Pow(D1, 2) / 4 + (D1 * D2) / 4 + Math.Pow(D2, 2) / 4)) / 3;
        return v;
    }
    double[] SumArray(double[] array)
    {
        int size = array.Length;
        double sum = 0;
        double[] sumArray = new double[size];
        for (int i = 0; i < size; i++)
        {
            sum = sum + array[i];
            sumArray[i] = sum;
        }
        return sumArray;
    }
    double vtotal = 0;
    double vArrayZapolneni = 0;
    double vZapolneni = 0;
    int indexArrayZapolneni = 0;
    double hInput = input;
    double[] sumH = SumArray(height);
    int sizeH = height.Length;
    double[] sumV = new double[sizeH];
    for (int i = 0; i < height.Length; i++)
    {
        vtotal = vtotal + FindVolume(diametr[i], diametr[i + 1], height[i]);
        sumV[i] = vtotal;
    }
    double hzapolneni = sumH[sumH.Length - 1] - hInput;
    if (hInput == 0)
    {
        vZapolneni= vtotal;
    }
    else if (hInput > sumH[sumH.Length - 1])
    {
        vZapolneni = 0;
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
        }
        else
        {
            for (int k = 0; k < sizeH; k++)
            {
                if (hzapolneni >= sumH[k])
                {
                    vArrayZapolneni = sumV[k];
                    indexArrayZapolneni = k;
                }
            }
            vZapolneni = vArrayZapolneni + FindVolume(diametr[indexArrayZapolneni + 1], diametr[indexArrayZapolneni + 2], hzapolneni - sumH[indexArrayZapolneni]);
        }
    }
    return vZapolneni;
}
double[] FillArrayVol(double [] array, double [] diametr, double [] height)
{
    double size = array.Length;
    int sizeConvert = Convert.ToInt32(size);
    double[] fillArrayVol = new double[sizeConvert];
    for (int i = 0; i < size; i++)
    {
        fillArrayVol[i] = Vol(array [i], diametr, height);
    }
    return fillArrayVol;
}
double[] FillArrayZamer(string msg, int kolvoPosCHK)
{
    int size = kolvoPosCHK;
    double[] fillArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        fillArray[i] = Input(msg + (i+1) + " ");
    }
    Console.WriteLine("");
    return fillArray;
    
}

double SumArray(double [] array, int kolvoPos)
{
    int size = kolvoPos;
    double sum =0;
    for (int i = 0; i < size; i++)
    {
        sum = sum + array[i];
    }
    Console.WriteLine("");
    return sum;
}

double [] zamer206 = FillArrayZamer("Введите замер отмывочных колог 206/", kolvoPos206);

double [] vol206 = FillArrayVol(zamer206, diametr206, height206);

double sum206= SumArray(vol206,kolvoPos206 );

PrintArray(vol206, "Обьем позиции 206/");

Console.WriteLine("Общий обьем отмывочных колон = " + sum206);


