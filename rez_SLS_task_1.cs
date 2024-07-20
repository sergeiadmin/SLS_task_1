using System;

public class Student
{
    // Свойства класса
    private string name;
    private int age;
    private double averageGrade;

    // Конструктор класса
    public Student(string name, int age, double averageGrade)
    {
        this.name = name;
        this.age = age;
        this.averageGrade = averageGrade;
    }

    // Методы для установки и получения значений свойств
    public string GetName() { return name; }
    public void SetName(string name) { this.name = name; }

    public int GetAge() { return age; }
    public void SetAge(int age) { this.age = age; }

    public double GetAverageGrade() { return averageGrade; }
    public void SetAverageGrade(double averageGrade) { this.averageGrade = averageGrade; }

    // Метод для вывода информации о студенте
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Средний балл: {averageGrade:F2}");
    }

    // Метод для подсчета оценки студента
    public string CalculateGrade()
    {
        if (averageGrade > 8) return "Отлично";
        else if (averageGrade >= 6) return "Хорошо";
        else if (averageGrade >= 4) return "Удовлетворительно";
        else return "Неудовлетворительно";
    }

    // Дополнительный метод: проверка на отличника
    public bool IsHonorStudent()
    {
        return averageGrade > 9;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов класса Student
        Student student1 = new Student("Иван Иванов", 20, 8.5);
        Student student2 = new Student("Мария Петрова", 19, 9.2);
        Student student3 = new Student("Алексей Сидоров", 21, 6.8);

        // Демонстрация использования объектов
        student1.DisplayInfo();
        Console.WriteLine($"Оценка: {student1.CalculateGrade()}");
        Console.WriteLine($"Отличник: {student1.IsHonorStudent()}\n");

        student2.DisplayInfo();
        Console.WriteLine($"Оценка: {student2.CalculateGrade()}");
        Console.WriteLine($"Отличник: {student2.IsHonorStudent()}\n");

        student3.DisplayInfo();
        Console.WriteLine($"Оценка: {student3.CalculateGrade()}");
        Console.WriteLine($"Отличник: {student3.IsHonorStudent()}\n");

        // Изменение данных студента
        student3.SetAverageGrade(7.5);
        student3.DisplayInfo();
        Console.WriteLine($"Новая оценка: {student3.CalculateGrade()}");
    }
}
