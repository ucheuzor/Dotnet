﻿using System;

int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
int[] studentScores = new int[10];

Console.WriteLine("Student\t\t Exam Score\t\t Overall Grade\t\t Extra Credits\n");

foreach (string currentStudent in studentNames)
{

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;


    int sumAssignmentScores = 0;
    int examScoreTotal = 0;
    int extraCreditTotal = 0;
    int extraCredtCount = 0;
    decimal currentStudentGrade = 0;
    decimal extraExamGradeAverage = 0;
    decimal extraCreditAvergae = 0;
    string currentStudentLetterGrade = "";
    int gradedAssignments = 0;
    decimal extraCoursePoint = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            examScoreTotal += score;
        }
        else
        {
            extraCreditTotal += score;
            sumAssignmentScores += score / 10;
            extraCredtCount += 1;
        }
    }

    currentStudentGrade = Math.Round((decimal)(sumAssignmentScores + examScoreTotal) / examAssignments, 2);
    extraExamGradeAverage = Math.Round((decimal)examScoreTotal / examAssignments, 2);
    extraCreditAvergae = Math.Round((decimal)extraCreditTotal / extraCredtCount, 2);
    extraCoursePoint = Math.Round(Math.Abs(currentStudentGrade - extraExamGradeAverage), 2);

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93 && currentStudentGrade < 97)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90 && currentStudentGrade < 93)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87 && currentStudentGrade < 90)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83 && currentStudentGrade < 87)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80 && currentStudentGrade < 83)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77 && currentStudentGrade < 80)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73 && currentStudentGrade < 77)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70 && currentStudentGrade < 73)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67 && currentStudentGrade < 70)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63 && currentStudentGrade < 67)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60 && currentStudentGrade < 63)
        currentStudentLetterGrade = "D-";
    else if (currentStudentGrade >= 0 && currentStudentGrade < 60)
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t{extraExamGradeAverage} \t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{extraCreditAvergae} ({extraCoursePoint})");

}




/*
using System;

int examAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string currentStudent in studentNames)
{

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;


    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    string currentStudentLetterGrade = "";
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93 && currentStudentGrade < 97)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90 && currentStudentGrade < 93)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87 && currentStudentGrade < 90)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83 && currentStudentGrade < 87)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80 && currentStudentGrade < 83)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77 && currentStudentGrade < 80)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73 && currentStudentGrade < 77)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70 && currentStudentGrade < 73)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67 && currentStudentGrade < 70)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63 && currentStudentGrade < 67)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60 && currentStudentGrade < 63)
        currentStudentLetterGrade = "D-";
    else if (currentStudentGrade >= 0 && currentStudentGrade < 60)
        currentStudentLetterGrade = "F";


    Console.WriteLine($"{currentStudent}:\t\t {currentStudentGrade}\t{currentStudentLetterGrade}");

}
*/