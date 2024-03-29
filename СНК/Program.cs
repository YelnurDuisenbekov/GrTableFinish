﻿double[] diametr1073 = new double[] { 0.315, 2.3, 2.3 };            // 107 -  3,8,16,17,19,20,21
double[] height1073 = new double[] { 0.993, 1 };                    // 107 -  3,8,16,17,19,20,21
double[] diametr1074 = new double[] { 0.273, 2.5, 2.5 };            // 107 -  4,5,6,7,9,10,11,12,14,15
double[] height1074 = new double[] { 0.940, 1.5 };                  // 107 -  4,5,6,7,9,10,11,12,14,15
double[] diametr1071 = new double[] { 0.34, 2.2, 2.2 };             // 107 -  1,2,18
double[] height1071 = new double[] { 1.2, 0.8 };                    // 107 -  1,2,18
double[] diametr10713 = new double[] { 0.315, 3, 3 };               // 107 -  13
double[] height10713 = new double[] { 1.77, 1 };                    // 107 -  13


double[] diametr1063 = new double[] { 0.164, 3, 3, 0.315, 0.315 };  // 106 -  3,8,16,17,19,20,21
double[] height1063 = new double[] { 1.335, 7.31, 0.3, 1.7 };       // 106 -  3,8,16,17,19,20,21
double[] diametr1064 = new double[] { 0.13, 3, 3, 2.73, 2.73 };     // 106 -  4,5,6,7,9,10,11,12,14,15
double[] height1064 = new double[] { 1.2, 7.3, 0.3, 1.72 };         // 106 -  4,5,6,7,9,10,11,12,14,15
double[] diametr1061 = new double[] { 0.164, 3, 3, 0.34, 0.34 };    // 106 -  1,2,18
double[] height1061 = new double[] { 1.2, 6.3, 0.3, 1.75 };         // 106 -  1,2,18
double[] diametr10613 = new double[] { 0.164, 3, 3, 0.315, 0.315 }; // 107 -  13
double[] height10613 = new double[] { 1.335, 7.31, 0.3, 0.85 };     // 107 -  13

int kolvoPosCHK=21;                                                 // поз. 107 21шт., поз. 106 21шт.

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
double[] FillArrayVolCHK(double [] array, double [] diametr1, double [] diametr2, double [] diametr3, double [] diametr4, double [] height1, double [] height2, double [] height3,  double [] height4)
{
    double size = array.Length;
    int sizeConvert = Convert.ToInt32(size);
    double[] fillArrayVol = new double[sizeConvert];
    for (int i = 0; i < size; i++)
    {
        if (i==2 || i==7 || i==15 || i==16 || i==18 || i==19 || i==20)
        {
        fillArrayVol[i] = Vol(array [i], diametr1, height1);
        }
        else if (i==3 || i==4 || i==5 || i==6 || i==8 || i==9 || i==10 || i==11|| i==13 || i==14)
        {
        fillArrayVol[i] = Vol(array [i], diametr2, height2);
        }
        else if (i==0 || i==1 || i==17)
        {
        fillArrayVol[i] = Vol(array [i], diametr3, height3);
        }
        else
        {
        fillArrayVol[i] = Vol(array [i], diametr4, height4);
        }
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

double [] zamerCHK106 = FillArrayZamer("Введите замер СНК 106/", kolvoPosCHK);
double [] zamerCHK107 = FillArrayZamer("Введите замер СНК 107/", kolvoPosCHK);

double [] volCHK106 = FillArrayVolCHK(zamerCHK106, diametr1063, diametr1064, diametr1061, diametr10613, height1063, height1064, height1061, height10613);
double [] volCHK107 = FillArrayVolCHK(zamerCHK107, diametr1073, diametr1074, diametr1071, diametr10613, height1073, height1074, height1071, height10613);

double sumCHK106 = SumArray(volCHK106, kolvoPosCHK);
double sumCHK107 = SumArray(volCHK107, kolvoPosCHK);

double sum = sumCHK106 + sumCHK107;
PrintArray(volCHK106, "Обьем позиции 106/");
PrintArray(volCHK107, "Обьем позиции 107/");


Console.WriteLine("Общий обьем СНК 106 = " + sumCHK106);
Console.WriteLine("Общий обьем СНК 107 = " + sumCHK107);
Console.WriteLine("Общий обьем CНК = " + sum);

