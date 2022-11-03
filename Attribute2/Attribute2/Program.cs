using System;
using System.Reflection;

// An enumeration of books. Start at 1 (0 = uninitialized).
public enum Book
{
    // Pets.
    Detective = 1,
    Novel,
    Poem,
}

// A custom attribute to allow a target to have a pet.
public class BookTypeAttribute : Attribute
{
    // The constructor is called when the attribute is set.
    public BookTypeAttribute(Book pet)
    {
        thePet = pet;
    }

    // Keep a variable internally ...
    protected Book thePet;

    // .. and show a copy to the outside world.
    public Book Pet
    {
        get { return thePet; }
        set { thePet = value; }
    }
}

// A test class where each method has its own pet.
class BookTypeTestClass
{
    [BookType(Book.Detective)]
    public void DetectiveMethod() { }

    [BookType(Book.Novel)]
    public void NovelMethod() { }

    [BookType(Book.Poem)]
    public void PoemMethod() { }
}

class DemoClass
{
    static void Main(string[] args)
    {
        BookTypeTestClass testClass = new BookTypeTestClass();
        Type type = testClass.GetType();
        // Iterate through all the methods of the class.
        foreach (MethodInfo mInfo in type.GetMethods())
        {
            // Iterate through all the Attributes for each method.
            foreach (Attribute attr in
                Attribute.GetCustomAttributes(mInfo))
            {
                // Check for the AnimalType attribute.
                if (attr.GetType() == typeof(BookTypeAttribute))
                    Console.WriteLine(
                        "Method {0} has a pet {1} attribute.",
                        mInfo.Name, ((BookTypeAttribute)attr).Pet);
            }
        }
    }
}
