using System;

class Student : Person
{
    private double score;
    private string grade;

    public Student(string name, string id, double score) : base(name, id)
    {
        this.score = score;
        this.grade = CalculateGrade();
    }

    // =================== ENCAPSULATION ===================
    public double GetScore()
    {
        return score;
    }

    public string GetGrade()
    {
        return grade;
    }

    // =================== POLYMORPHISM ===================
    public override void ShowInfo()
    {
        Console.WriteLine($"ID: {id} | Name: {name} | Score: {score} | Grade: {grade}");
    }

    private string CalculateGrade()
    {
        if (score >= 80) return "A";
        else if (score >= 75) return "B+";
        else if (score >= 70) return "B";
        else if (score >= 65) return "C+";
        else if (score >= 60) return "C";
        else if (score >= 55) return "D+";
        else if (score >= 50) return "D";
        else return "F";
    }
}