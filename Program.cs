/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int [,] FillArray ()
{
Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input min possible value: ");
int minVal= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input max possible value: ");
int maxVal= Convert.ToInt32 (Console.ReadLine());
 
int [,] fill02Array = new int [rows, columns];

for (int i=0; i< rows; i++)
{
    for (int j=0;j< columns; j++)
    {
        fill02Array [i,j]= new Random().Next (minVal, maxVal+1);
    }
    
}
    return fill02Array;
}


void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}


int [] SumArray (int [,] array)
{
int [] array01= new int [array.GetLength(0)];


    for (int i=0; i< array.GetLength(0); i++)
    {
         int sum=0;
        for (int j=0; j< array.GetLength(1); j++)
        {
            sum=sum+array[i,j];
            array01[i]=sum;
           
        }
    }    
   return array01;
}

  
 void DigitRow (int [] array)
 {
     int count=1;
     int minVal= array[0];
    for (int i=1; i< array.Length; i++)
    {
        if (array[i]< minVal)
        {
           minVal=array[i];
           count=i+1;
        }        
      
    }   
    Console.Write ( $"  row {count} ");    
 }

 int [,] fillArray = FillArray();
 int [] newArray= SumArray (fillArray);

PrintArray(fillArray);
DigitRow(newArray);
*/

/*Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
1, 9, 9, 0,
2, 8, 0, 9
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
*/
/*
int [,] FillArray ()
{
Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());

 
int [,] fill02Array = new int [rows, columns];

for (int i=0; i< rows; i++)
{
    for (int j=0;j< columns; j++)
    {
        fill02Array [i,j]= new Random().Next (0, 10);
    }
    
}
    return fill02Array;
}

void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void NewArray (int [,] array)
{
    int [] array01= new int  [array.Length]; 
      
     for (int i=0; i< array.GetLength(1); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {  
            int count=0;
                                                 
            for (int i2=0; i2< array.GetLength(0); i2++)
            {                                     
                for (  int j2=0; j2< array.GetLength(1); j2++)
                {  
                                    
                    if (array[i,j]==array[i2,j2]) 
                    { 
                        array01[i]=array[i,j];
                        
                        count++;
                         
                        if (count>1)
                        {
                            array[i2,j2]=-1;// любое число не входящее в интервал элементов
                        }
                             
                    }
                             
                 }
            }
             
             if (array[i,j]!=-1)
                {
                                                                
                Console.WriteLine ($"{array01[i] + " "} встречается {count}");
                }              
        }               
    }
}  
int [,] fillArray = FillArray();
PrintArray(fillArray);
 NewArray (fillArray);
*/


/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int [,] FillArray ( )
{
Console.Write (" Input count of rows: ");
int rows= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input count  of columns: ");
int columns= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input min possible value: ");
int minVal= Convert.ToInt32 (Console.ReadLine());
Console.Write (" Input max possible value: ");
int maxVal= Convert.ToInt32 (Console.ReadLine());

int [,] array= new int [rows,columns];

for (int i=0; i< rows; i++)
{
    for ( int j=0; j< columns;j++ )
    { 
        array[i,j]= new Random().Next(minVal, maxVal+1); 
    }
}
return array;
}

void PrintArray (int [,] array) 
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0;j< array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}
int [,] ChangeRow (int [,] arrayToChange)

{
    for (int i=0; i< arrayToChange.GetLength(0) ; i++)
    {             
            for  (int j=0; j< arrayToChange.GetLength(1); j++)
            {
                for  (int maxj=j; maxj< arrayToChange.GetLength(1); maxj++ )
                {
                    if ( arrayToChange[i,maxj]>arrayToChange[i,j])
                    {
                    int temp= arrayToChange[i,j];
                    arrayToChange[i,j]= arrayToChange[i,maxj];
                    arrayToChange[i,maxj]= temp;
                    }
                }
            }        
    }
    return arrayToChange;
}
int [,] fillArray = FillArray();
PrintArray(fillArray);
PrintArray(ChangeRow(fillArray));
*/