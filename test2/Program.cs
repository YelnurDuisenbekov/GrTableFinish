double Input(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    double VvodimoeChislo = double.Parse(number);
    return VvodimoeChislo;
}
double VolCHK107(double input)
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
double[] diametr = new double[] { 0.315, 2.3, 2.3 };
double[] height = new double[] { 0.993, 1 };
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
    Console.WriteLine("Заполненый обьем: " + vtotal);
}
else if (hInput > sumH[sumH.Length - 1])
{
    Console.WriteLine("Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
}
else
{
    for (int k = 0; hzapolneni >= sumH[k]; k++)
    {
            vArrayZapolneni = sumV[k];
            indexArrayZapolneni = k;
    }
    if (indexArrayZapolneni == 0)
    {
        vZapolneni = FindVolume(diametr[indexArrayZapolneni], diametr[indexArrayZapolneni + 1], hzapolneni);
    }
    else
    {
        vZapolneni = vArrayZapolneni + FindVolume(diametr[indexArrayZapolneni + 1], diametr[indexArrayZapolneni + 2], hzapolneni - sumH[indexArrayZapolneni]);
        
    }
    Console.WriteLine("Заполненый обьем: " + vZapolneni);
}
return vZapolneni;
}
double volCHK107 = VolCHK107(Input("Введите замер для СНК 107 "));
