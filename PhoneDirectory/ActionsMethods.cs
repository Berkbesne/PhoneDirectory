using System;
using System.ComponentModel;

public class DirectoryActionsMethods
{
    List<Person> Persons = new List<Person>();
    public DirectoryActionsMethods()
    {
        // Baþlagýç olarak 5 adet numara constuructorda atanmýþtýr
        Persons.Add(new Person("berk", "besne", "7894561234"));
        Persons.Add(new Person("ahmet", "tarýk", "789456215"));
        Persons.Add(new Person("mehmet", "faruk", "753951753"));
        Persons.Add(new Person("dayi", "ramiz", "3461234123141"));
        Persons.Add(new Person("oðuz", "mete", "1234576"));
    }

    public void add()

    {
    head:
        Console.WriteLine("Enter name :");
        string name = Console.ReadLine();
        Console.WriteLine("Surname :");
        string surname = Console.ReadLine();
        Console.WriteLine("Number :");
        string number = Console.ReadLine();
        name = name.ToLower();
        surname = surname.ToLower();
        number = number.ToLower();
        Person newPerson = new Person(name, surname, number);
        Persons.Add(newPerson);
        Console.WriteLine(name + " The person mentioned has been recorded in the directory.");
    }
    public void remove()
    {
    head:

        Console.WriteLine("Enter the name, surname or number of the person to be deleted.");
        string DeletePerson = Console.ReadLine();
        DeletePerson = DeletePerson.ToLower();

        for (int i = 0; i < Persons.Count; i++)
        {
            if ((Persons[i].Name.Equals(DeletePerson) || Persons[i].Surname.Equals(DeletePerson)) || Persons[i].Number.Equals(DeletePerson))
            {
                Console.WriteLine(Persons[i].Name + "If this is the person you want to delete, press 1, otherwise press 2.");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)

                {
                    Console.WriteLine(Persons[i].Name + "This person has been deleted from the phone.");
                    Persons.RemoveAt(i);

                    break;
                }
                else
                {

                    break;
                }
            }
            if (i == Persons.Count - 1)
            {

                Console.WriteLine("The searched person is not in the directory. Press (1) to try again or (0) to exit the delete operation.");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    goto head;
                else
                    break;


            }
        }

    }
    public void update()
    {
    head:
        Console.WriteLine("Enter the name, surname or number of the person to be searched ");
        string uptadeperson = Console.ReadLine();
        for (int i = 0; i < Persons.Count; i++)
        {
            if ((Persons[i].Name.Equals(uptadeperson) || Persons[i].Surname.Equals(uptadeperson)) || Persons[i].Number.Equals(uptadeperson))
            {
            head1:
                Console.WriteLine("1.Update the name\r\n2. Surname update\r\n3.Number update");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine("Enter Name for update");
                    string name = Console.ReadLine();
                    Persons[i].Name = name;
                    Console.WriteLine(Persons[i].Name + " Updated to");
                    break;
                }
                else if (choose == 2)
                {
                    Console.WriteLine("Enter Surname for update");
                    string surname = Console.ReadLine();
                    Persons[i].Surname = surname;
                    Console.WriteLine(Persons[i].Surname + " Updated to");
                    break;
                }
                else if (choose == 3)
                {
                    Console.WriteLine("Enter Number for uptdate");
                    string number = Console.ReadLine();
                    Persons[i].Number = number;
                    Console.WriteLine((Persons[i].Number + "Updated to "));
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choose");
                    goto head1;
                }

            }
            if (i == Persons.Count - 1)
            {
                Console.WriteLine("The called person is not registered in the phonebook. Press (1) to try again or (0) to exit the update process.");
                int choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    goto head;
                else
                    break;
            }
        }

    }
    public void search()
    {
        Console.WriteLine("Please enter the name or surname or number of the person you want to call:: ");
        string searchname = Console.ReadLine();
        searchname = searchname.ToLower();
        for (int i = 0; i < Persons.Count; i++)
        {

            if (Persons[i].Name.Equals(searchname) || Persons[i].Surname.Equals(searchname) || Persons[i].Equals(searchname))
            {
                Console.WriteLine("Name: " + Persons[i].Name);
                Console.WriteLine("Surname " + Persons[i].Surname);
                Console.WriteLine("Number: " + Persons[i].Number);


            }
            if (i == Persons.Count - 1)
            {
                Console.WriteLine("The called person is not listed in the phone book");
                break;
            }
        }

    }
    public void OrderbyAlphabetical()
    {
        var sortedPersons = Persons.OrderBy(value => value.Name);


        foreach (var person in sortedPersons)
        {
            Console.WriteLine("Name : " + person.Name + "\nSurname  :" + person.Surname + "\nNumber: " + person.Number);

        }


    }
    public void OrderReverse()
    {
        var sortedPersons = Persons.OrderBy(value => value.Name).Reverse();
        foreach (var person in sortedPersons)
        {

            Console.WriteLine("Name : " + person.Name + "\nSurname  :" + person.Surname + "\nNumber: " + person.Number);


        }
    }

}
