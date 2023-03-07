double Input(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    double VvodimoeChislo = double.Parse(number);
    return VvodimoeChislo;
}
double VolCHK1073(double input)// 107 -  3,8,16,17,19,20,21
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double VolCHK1074(double input)// 107 -  4,5,6,7,9,10,11,12,14,15
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
    double[] diametr = new double[] { 0.273, 2.5, 2.5 };
    double[] height = new double[] { 0.940, 1.5 };
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double VolCHK1071(double input)// 107 -  1,2,18
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
    double[] diametr = new double[] { 0.34, 2.2, 2.2 };
    double[] height = new double[] { 1.2, 0.8 };
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double VolCHK1063(double input)// 106 -  3,8,16,17,19,20,21
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
    double[] diametr = new double[] { 0.164, 3, 3, 0.315, 0.315 };
    double[] height = new double[] { 1.335, 7.31, 0.3, 1.7 };
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double VolCHK1064(double input)// 106 -  4,5,6,7,9,10,11,12,14,15
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
    double[] diametr = new double[] { 0.13, 3, 3, 2.73, 2.73 };
    double[] height = new double[] { 1.2, 7.3, 0.3, 1.72 };
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double VolCHK1061(double input)// 106 -  1,2,18
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
    double[] diametr = new double[] { 0.164, 3, 3, 0.34, 0.34 };
    double[] height = new double[] { 1.2, 6.3, 0.3, 1.75 };
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
        Console.WriteLine("Заполненый обьем: 0. Введены не корректные данные, так как общая высота колоны: " + sumH[sumH.Length - 1]);
    }
    else
    {
        if (hzapolneni < sumH[0])
        {
            vZapolneni = FindVolume(diametr[0], diametr[1], hzapolneni);
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
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
            Console.WriteLine("Заполненый обьем: " + vZapolneni);
        }
    }
    return vZapolneni;
}
double [] ArraySumVol (double a1, double a2, double a3,double a4,double a5,double a6,double a7,double a8,double a9,double a10,double a11,double a12,double a14,double a15,double a16,double a17,double a18,double a19,double a20,double a21)
{
        int size = 21;
        double[] ArraySumVol = new double[size];
        ArraySumVol[0] = a1;
        ArraySumVol[1] = a2;
        ArraySumVol[2] = a3;
        ArraySumVol[3] = a4;
        ArraySumVol[4] = a5;
        ArraySumVol[5] = a6;
        ArraySumVol[6] = a7;
        ArraySumVol[7] = a8;
        ArraySumVol[8] = a9;
        ArraySumVol[9] = a10;
        ArraySumVol[10] = a11;
        ArraySumVol[11] = a12;
        ArraySumVol[12] = 0;
        ArraySumVol[13] = a14;
        ArraySumVol[14] = a15;
        ArraySumVol[15] = a16;
        ArraySumVol[16] = a17;
        ArraySumVol[17] = a18;
        ArraySumVol[18] = a19;
        ArraySumVol[19] = a20;
        ArraySumVol[20] = a21;
        return ArraySumVol;
}


double volCHK1071 = VolCHK1071(Input("Введите замер для СНК 107/1 "));
Console.WriteLine("");
double volCHK1072 = VolCHK1071(Input("Введите замер для СНК 107/2 "));
Console.WriteLine("");
double volCHK1073 = VolCHK1073(Input("Введите замер для СНК 107/3 "));
Console.WriteLine("");
double volCHK1074 = VolCHK1074(Input("Введите замер для СНК 107/4 "));
Console.WriteLine("");
double volCHK1075 = VolCHK1074(Input("Введите замер для СНК 107/5 "));
Console.WriteLine("");
double volCHK1076 = VolCHK1074(Input("Введите замер для СНК 107/6 "));
Console.WriteLine("");
double volCHK1077 = VolCHK1074(Input("Введите замер для СНК 107/7 "));
Console.WriteLine("");
double volCHK1078 = VolCHK1073(Input("Введите замер для СНК 107/8 "));
Console.WriteLine("");
double volCHK1079 = VolCHK1074(Input("Введите замер для СНК 107/9 "));
Console.WriteLine("");
double volCHK10710 = VolCHK1074(Input("Введите замер для СНК 107/10 "));
Console.WriteLine("");
double volCHK10711 = VolCHK1074(Input("Введите замер для СНК 107/11 "));
Console.WriteLine("");
double volCHK10712 = VolCHK1074(Input("Введите замер для СНК 107/12 "));
Console.WriteLine("");
Console.WriteLine("СНК 107/13 в разработке");
Console.WriteLine("");
double volCHK10714 = VolCHK1074(Input("Введите замер для СНК 107/14 "));
Console.WriteLine("");
double volCHK10715 = VolCHK1074(Input("Введите замер для СНК 107/15 "));
Console.WriteLine("");
double volCHK10716 = VolCHK1073(Input("Введите замер для СНК 107/16 "));
Console.WriteLine("");
double volCHK10717 = VolCHK1073(Input("Введите замер для СНК 107/17 "));
Console.WriteLine("");
double volCHK10718 = VolCHK1071(Input("Введите замер для СНК 107/18 "));
Console.WriteLine("");
double volCHK10719 = VolCHK1073(Input("Введите замер для СНК 107/19 "));
Console.WriteLine("");
double volCHK10720 = VolCHK1073(Input("Введите замер для СНК 107/20 "));
Console.WriteLine("");
double volCHK10721 = VolCHK1073(Input("Введите замер для СНК 107/21 "));
Console.WriteLine("");
double volCHK1061 = VolCHK1061(Input("Введите замер для СНК 106/1 "));
Console.WriteLine("");
double volCHK1062 = VolCHK1061(Input("Введите замер для СНК 106/2 "));
Console.WriteLine("");
double volCHK1063 = VolCHK1063(Input("Введите замер для СНК 106/3 "));
Console.WriteLine("");
double volCHK1064 = VolCHK1064(Input("Введите замер для СНК 106/4 "));
Console.WriteLine("");
double volCHK1065 = VolCHK1064(Input("Введите замер для СНК 106/5 "));
Console.WriteLine("");
double volCHK1066 = VolCHK1064(Input("Введите замер для СНК 106/6 "));
Console.WriteLine("");
double volCHK1067 = VolCHK1064(Input("Введите замер для СНК 106/7 "));
Console.WriteLine("");
double volCHK1068 = VolCHK1063(Input("Введите замер для СНК 106/8 "));
Console.WriteLine("");
double volCHK1069 = VolCHK1064(Input("Введите замер для СНК 106/9 "));
Console.WriteLine("");
double volCHK10610 = VolCHK1064(Input("Введите замер для СНК 106/10 "));
Console.WriteLine("");
double volCHK10611 = VolCHK1064(Input("Введите замер для СНК 106/11 "));
Console.WriteLine("");
double volCHK10612 = VolCHK1064(Input("Введите замер для СНК 106/12 "));
Console.WriteLine("");
Console.WriteLine("СНК 106/13 в разработке");
Console.WriteLine("");
double volCHK10614 = VolCHK1064(Input("Введите замер для СНК 106/14 "));
Console.WriteLine("");
double volCHK10615 = VolCHK1064(Input("Введите замер для СНК 106/15 "));
Console.WriteLine("");
double volCHK10616 = VolCHK1063(Input("Введите замер для СНК 106/16 "));
Console.WriteLine("");
double volCHK10617 = VolCHK1063(Input("Введите замер для СНК 106/17 "));
Console.WriteLine("");
double volCHK10618 = VolCHK1061(Input("Введите замер для СНК 106/18 "));
Console.WriteLine("");
double volCHK10619 = VolCHK1063(Input("Введите замер для СНК 106/19 "));
Console.WriteLine("");
double volCHK10620 = VolCHK1063(Input("Введите замер для СНК 106/20 "));
Console.WriteLine("");
double volCHK10621 = VolCHK1063(Input("Введите замер для СНК 106/21 "));
Console.WriteLine("");

double sumvolCHK1=volCHK1061+volCHK1071;
double sumvolCHK2=volCHK1062+volCHK1072;
double sumvolCHK3=volCHK1063+volCHK1073;
double sumvolCHK4=volCHK1064+volCHK1074;
double sumvolCHK5=volCHK1065+volCHK1075;
double sumvolCHK6=volCHK1066+volCHK1076;
double sumvolCHK7=volCHK1067+volCHK1077;
double sumvolCHK8=volCHK1068+volCHK1078;
double sumvolCHK9=volCHK1069+volCHK1079;
double sumvolCHK10=volCHK10610+volCHK10710;
double sumvolCHK11=volCHK10611+volCHK10711;
double sumvolCHK12=volCHK10612+volCHK10712;
double sumvolCHK14=volCHK10614+volCHK10714;
double sumvolCHK15=volCHK10615+volCHK10715;
double sumvolCHK16=volCHK10616+volCHK10716;
double sumvolCHK17=volCHK10617+volCHK10717;
double sumvolCHK18=volCHK10618+volCHK10718;
double sumvolCHK19=volCHK10619+volCHK10719;
double sumvolCHK20=volCHK10620+volCHK10720;
double sumvolCHK21=volCHK10621+volCHK10721;

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("Сумма обьма позиции СНК" + (i+1) + " = " + numbers[i] + " ");
        Console.WriteLine(" ");
    }
    Console.WriteLine();
}
PrintArray(ArraySumVol(sumvolCHK1, sumvolCHK2, sumvolCHK3, sumvolCHK4,  sumvolCHK5, sumvolCHK6,  sumvolCHK7, sumvolCHK8, sumvolCHK9, sumvolCHK10,  sumvolCHK11, sumvolCHK12, sumvolCHK14, sumvolCHK15, sumvolCHK16, sumvolCHK17, sumvolCHK18, sumvolCHK19, sumvolCHK20, sumvolCHK21)); 
Console.WriteLine("СНК 13 в разработке");