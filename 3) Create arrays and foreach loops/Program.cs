/*This code block calculates the average grade for 
a student based on their scores in a set of graded assignments.
*/

int currentAssignments = 5;

int[] aliceScores = new int[] { 88, 76, 92, 94, 85 };
int[] bobScores = new int[] { 78, 82, 91, 88, 90 };
int[] carolScores = new int[] { 95, 87, 89, 78, 92 };
int[] davidScores = new int[] { 90, 94, 82, 88, 96 };

int aliceSum = 0;
decimal aliceScore;

foreach (int score in aliceScores)
{
    // add the exam score to the sum
    aliceSum += score;
}

aliceScore = (decimal)aliceSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Alice:\t\t" + aliceScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

