public class Person
{ 
    private String name;

    public Person(string name, string surname, string number)
    {
        this.Name = name;
        this.Surname = surname;
        this.Number = number;
    }

    private String surname;
    private string number;

    public string Surname { get => surname; set => surname = value; }
    public string Number { get => number; set => number = value; }
    public string Name { get => name; set => name = value; }
}
