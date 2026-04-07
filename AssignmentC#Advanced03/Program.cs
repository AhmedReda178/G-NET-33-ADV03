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

            #region Exercise 2: Leaderboard

            ////Create a leaderboard that automatically sorts players by score.

            //// 1. Create leaderboard using SortedDictionary<int, string>

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //// 2. Add players
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            //// 3. Print all entries (automatically sorted by score)
            //Console.WriteLine("Leaderboard (sorted by score):");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine("Score: " + entry.Key + ", Player: " + entry.Value);
            //}

            //// 4. Access first key and first value
            //int firstScore = 0;
            //string firstPlayer = "";
            //foreach (var entry in leaderboard)
            //{
            //    firstScore = entry.Key;
            //    firstPlayer = entry.Value;
            //    break; // first element only
            //}
            //Console.WriteLine($"First score: {firstScore}, First player: {firstPlayer}");

            //// 5. Check if score 500 exists
            //bool has500 = leaderboard.ContainsKey(500);
            //Console.WriteLine("Does score 500 exist? " + has500);

            //// 6. Safely get player with score 999
            //string player999;
            //if (leaderboard.TryGetValue(999, out player999))
            //{
            //    Console.WriteLine("Player with score 999: " + player999);
            //}
            //else
            //{
            //    Console.WriteLine("No player with score 999 found.");
            //}

            //// 7. Remove player with score 200
            //bool removed = leaderboard.Remove(200);
            //Console.WriteLine("Removed score 200? " + removed);

            //// Print updated leaderboard
            //Console.WriteLine("Updated Leaderboard:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine("Score: " + entry.Key + ", Player: " + entry.Value);
            //}
            #endregion
        }
    }
}
