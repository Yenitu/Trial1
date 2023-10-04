/* 
Class: CSE 1322L
Section: W1
Term: Fall 2022
Instructor: Enda Sullivan
Name: Tiyeni Mbutu
Lab#:1
*/
using System;
class Lab1{
  public static void Main(string[] args)
        {
          char[,] mainArray = new char[4, 13];
        //  Populate the new array using the old Array's method
            mainArray = make_foward();
            //For loop to print first car
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 13; column++)
                {
                    Console.Write(mainArray[row, column]);
                }
                Console.WriteLine();
            }
            
            mainArray = make_mirror(mainArray);
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 13; column++)
                {
                    Console.Write(mainArray[row, column]);
                }
                Console.WriteLine();
            }
            for (int row = 0; row < 4; row++)
            {
              //This line is needed to keep the lines at the top centered with the car, else the -- end up in the wrong column.
             mainArray = make_foward();
                for (int column = 0; column < 13; column++)
                {
                
                    Console.Write(mainArray[row, column]);
                }
                mainArray = make_mirror(mainArray);
                for (int p = 0; p<13; p++) {
                  //p is just the mirrored column, since row number stays the same.
          
                      Console.Write(mainArray[row,p]);
                    }
                Console.WriteLine();
            }
          }
  public static char[,] make_mirror(char [,] inTake)
        {//Intakes mainArray
            char[,] mirrored = new char[4, 13];
            int x = 0; int y = 0;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 12; i >= 0; i--)
                {
                    mirrored[j, i] = inTake[x,y];
                    y++;
                }
                x++;
                y = 0;
            }
            for (int j = 0; j < 13; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                  //switch each sign the other way
                    if (mirrored[i,j] == '(')
                    {
                        mirrored[i, j] = ')';
                    }
                    else if (mirrored[i, j] == ')')
                    {
                        mirrored[i, j] = '(';
                    }
                    else if (mirrored[i, j] == '/')
                    {
                        mirrored[i,j] = '\\' ;
                    }
                    else if (mirrored[i, j] == '\\')
                    {
                        mirrored[i, j] = '/';
                    }
                }
            }
            return mirrored;
        }
     
   public static char[,] make_foward()
        {// Copied straight from the Lab instructions
            char[,] pixel = new char[4, 13];
            pixel[0, 0] = ' ';
            pixel[0, 1] = ' ';
            pixel[0, 2] = '_';
            pixel[0, 3] = '_';
            pixel[0, 4] = '_';
            pixel[0, 5] = '_';
            pixel[0, 6] = '_';
            pixel[0, 7] = '_';
            pixel[0, 8] = ' ';
            pixel[0, 9] = ' ';
            pixel[0, 10] = ' ';
            pixel[0, 11] = ' ';
            pixel[0, 12] = ' ';
            pixel[1, 0] = ' ';
            pixel[1, 1] = '/';
            pixel[1, 2] = '|';
            pixel[1, 3] = '_';
            pixel[1, 4] = '|';
            pixel[1, 5] = '|';
            pixel[1, 6] = '_';
            pixel[1, 7] = '\\';
            pixel[1, 8] = '\'';
            pixel[1, 9] = '.';
            pixel[1, 10] = '_';
            pixel[1, 11] = '_';
            pixel[1, 12] = ' ';
            pixel[2, 0] = '(';
            pixel[2, 1] = ' ';
            pixel[2, 2] = ' ';
            pixel[2, 3] = ' ';
            pixel[2, 4] = '_';
            pixel[2, 5] = ' ';
            pixel[2, 6] = ' ';
            pixel[2, 7] = ' ';
            pixel[2, 8] = ' ';
            pixel[2, 9] = '_';
            pixel[2, 10] = ' ';
            pixel[2, 11] = '_';
            pixel[2, 12] = '\\';
            pixel[3, 0] = '=';
            pixel[3, 1] = '\'';
            pixel[3, 2] = '-';
            pixel[3, 3] = '(';
            pixel[3, 4] = '_';
            pixel[3, 5] = ')';
            pixel[3, 6] = '-';
            pixel[3, 7] = '-';
            pixel[3, 8] = '(';
            pixel[3, 9] = '_';
            pixel[3, 10] = ')';
            pixel[3, 11] = '-';
            pixel[3, 12] = '\'';
            return pixel;
        }
    }