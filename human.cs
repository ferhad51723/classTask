using System;

class Human
{
    public string name;
    public string surname;
    public int age = 0;
    public string gender;
    public string nationality;
    public string getFullName()
    {
        return name + " " + surname;
    }

    public int getBirthYear()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - age;
    }

    public Human(string name, string surname, int age, string gender, string nationality)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.gender = gender;
        this.nationality = nationality;
    }
}