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

            #region Exercise 3: Phone Book

            //    // 1. Create phone book with 4 contacts
            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>
            //{
            //    { "Ahmed", "01011112222" },
            //    { "Sara", "01033334444" },
            //    { "Ali", "01055556666" },
            //    { "Mona", "01077778888" }
            //};

            //    // 2. Add a new contact using [] syntax (add or update)
            //    phoneBook["Hassan"] = "01099990000"; // add new
            //    phoneBook["Sara"] = "01012345678";   // update existing

            //    // 3. Try adding a duplicate using .Add() — catch exception
            //    try
            //    {
            //        phoneBook.Add("Ahmed", "01100001111"); // duplicate key
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("Error adding duplicate with Add(): " + ex.Message);
            //    }

            //    // 4. Try adding a duplicate using .TryAdd()
            //    bool added = phoneBook.TryAdd("Ali", "01222223333"); // duplicate key
            //    Console.WriteLine("Adding duplicate with TryAdd() succeeded? " + added);

            //    bool addedNew = phoneBook.TryAdd("Laila", "01044445555"); // new key
            //    Console.WriteLine("Adding new contact with TryAdd() succeeded? " + addedNew);

            //    // 5. Search for a contact that doesn’t exist
            //    string searchName = "Youssef";
            //    if (phoneBook.ContainsKey(searchName))
            //    {
            //        Console.WriteLine(searchName + "'s number: " + phoneBook[searchName]);
            //    }
            //    else
            //    {
            //        Console.WriteLine(searchName + " not found.");
            //    }

            //    // 6. Get a contact with fallback "Not Found"
            //    string number = phoneBook.ContainsKey("Khaled") ? phoneBook["Khaled"] : "Not Found";
            //    Console.WriteLine("Khaled's number: " + number);

            //    // 7. Print all keys on one line
            //    Console.Write("All names: ");
            //    foreach (var name in phoneBook.Keys)
            //        Console.Write(name + " ");
            //    Console.WriteLine();

            //    // 8. Print all values on one line
            //    Console.Write("All numbers: ");
            //    foreach (var phone in phoneBook.Values)
            //        Console.Write(phone + " ");
            //    Console.WriteLine();
            #endregion


            #region Exercise 4: Unique Email Validator

            ////Use Collection to manage unique email addresses.

            //// 1. Create HashSet with case-insensitive comparer
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //// 2. Add emails
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com"); // duplicate, ignored because of case-insensitive
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");   // duplicate, ignored because of case-insensitive

            //// 3. Print Count
            //Console.WriteLine("Number of unique emails: " + emails.Count);
            //Console.WriteLine("Explanation: Duplicate emails with different cases are ignored due to case-insensitive HashSet.");

            //Console.WriteLine("Stored emails:");
            //foreach (var email in emails)
            //    Console.WriteLine(email);

            //// 4. Create sets A and B
            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //// 5. UnionWith
            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);
            //Console.Write("Union of A and B: ");
            //foreach (var n in unionSet)
            //    Console.Write(n + " ");
            //Console.WriteLine();

            //// 6. IntersectWith
            //HashSet<int> intersectSet = new HashSet<int>(setA);
            //intersectSet.IntersectWith(setB);
            //Console.Write("Intersection of A and B: ");
            //foreach (var n in intersectSet)
            //    Console.Write(n + " ");
            //Console.WriteLine();

            //// 7. ExceptWith
            //HashSet<int> exceptSet = new HashSet<int>(setA);
            //exceptSet.ExceptWith(setB);
            //Console.Write("A except B: ");
            //foreach (var n in exceptSet)
            //    Console.Write(n + " ");
            //Console.WriteLine();

            //// 8. IsSubsetOf
            //HashSet<int> subset = new HashSet<int> { 1, 2 };
            //bool isSubset = subset.IsSubsetOf(setA);
            //Console.WriteLine("{1,2} is subset of A? " + isSubset);
            #endregion
        }
    }
}
