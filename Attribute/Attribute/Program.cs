using System.ComponentModel.DataAnnotations;

Validate(new User("Bob", 41));
Validate(new User("admin", 37));

void Validate(User user)
{
    var results = new List<ValidationResult>();
    var context = new ValidationContext(user);
    if (!Validator.TryValidateObject(user, context, results, true))
    {
        foreach (var error in results)
        {
            Console.WriteLine(error.ErrorMessage);
        }
    }
    else
        Console.WriteLine("Пользователь прошел валидацию");
    Console.WriteLine();
}

public class User
{
    public string Name { get; set; }

    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}