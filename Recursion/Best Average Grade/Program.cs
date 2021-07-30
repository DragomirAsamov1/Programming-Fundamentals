using System;
using System.Collections;

class MainClass
{

    /*
    Дадена е структура Студент.

    Да се направи програа която подканва потребителя да въведе 5 студента и 
    за всеки студент да въведе 3 оценки.

    След това програмата да извежда студента с най висок среден успех.

    
    const int STUDENTS_COUNT = 5;
    const int GRADES_COUNT = 3;

    public static void Main()
    {
        int[][] students = new int[STUDENTS_COUNT][];

        for (int i = 0; i < students.Length; i++)  //num.Length=5
        {
            students[i] = new int[GRADES_COUNT];
            int sumGrades = 0;
            for (int j = 0; j < students[i].Length; j++)
            {
                
                int currentGrade = int.Parse(Console.ReadLine());
                students[i][j] = currentGrade;
                sumGrades += students[i][j];
                if (j == students[i].Length - 1)
                {
                    int averageGrade = sumGrades / GRADES_COUNT;
                }
            }

        }
    }
    */
    public static void Main()
    {
        int studentsCount = int.Parse(Console.ReadLine());
        int gradesCount = int.Parse(Console.ReadLine());
        int[] bestGradeOfEveryStudent = new int[studentsCount];

        int sumGrades = 0;
        for (int i = 0; i < studentsCount; i++)
        {
            for (int j = 0; j < gradesCount; j++)
            {
                int currentGrade = int.Parse(Console.ReadLine());
                sumGrades += currentGrade;
                if (j==gradesCount-1)
                {
                    bestGradeOfEveryStudent[i] = sumGrades / gradesCount;
                    sumGrades = 0;
                }
            }
        }
        int largest = 0;
        for (int i = 1; i < bestGradeOfEveryStudent.Length; i++)
        {
            if (bestGradeOfEveryStudent[i]>bestGradeOfEveryStudent[largest])
            {
                largest = i;
            }
        }
        Console.WriteLine(largest);
    }
}