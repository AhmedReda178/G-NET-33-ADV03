namespace AssignmentC_Advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            ////Create a program that manages student grades using One Of Collections

            //// 1.Create collection with grades
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// 2.Print the collection
            //Console.Write("All grades: ");
            //foreach (var g in grades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //// 3.Count, first, last
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First grade: " + grades[0]);
            //Console.WriteLine("Last grade: " + grades[grades.Count - 1]);

            //// 4.Sort ascending and print
            //grades.Sort();
            //Console.Write("Sorted grades: ");
            //foreach (var g in grades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //// 5.First grade above 90
            //int firstAbove90 = -1;
            //foreach (var g in grades)
            //{
            //    if (g > 90)
            //    {
            //        firstAbove90 = g;
            //        break;
            //    }
            //}
            //Console.WriteLine("First grade above 90: " + firstAbove90);

            //// 6.All grades below 75 (failing)
            //List<int> failingGrades = new List<int>();
            //foreach (var g in grades)
            //{
            //    if (g < 75)
            //        failingGrades.Add(g);
            //}
            //Console.Write("Failing grades (<75): ");
            //foreach (var g in failingGrades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //// 7.Remove all failing grades
            //for (int i = grades.Count - 1; i >= 0; i--)
            //{
            //    if (grades[i] < 75)
            //        grades.RemoveAt(i);
            //}
            //Console.Write("Grades after removing failing: ");
            //foreach (var g in grades)
            //    Console.Write(g + " ");
            //Console.WriteLine();

            //// 8.Check if any grade equals 100
            //bool hasPerfect = false;
            //foreach (var g in grades)
            //{
            //    if (g == 100)
            //    {
            //        hasPerfect = true;
            //        break;
            //    }
            //}
            //Console.WriteLine("Is there a grade = 100? " + hasPerfect);

            //// 9.Create List<string> with "Grade: X"
            //List<string> gradeStrings = new List<string>();
            //foreach (var g in grades)
            //{
            //    gradeStrings.Add("Grade: " + g);
            //}
            //Console.WriteLine("Grades as strings:");
            //foreach (var s in gradeStrings)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion
        }
    }
}
