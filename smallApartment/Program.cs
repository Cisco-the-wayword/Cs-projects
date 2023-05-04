using System;

class House
{
    private int area;
    private Door door;

    public House(int area)
    {
        this.area = area;
        this.door = new Door();
    }

    public int Area
    {
        get { return this.area; }
        set { this.area = value; }
    }

    public Door GetDoor()
    {
       return this.door;
    }

    public void ShowData()
    {
        Console.WriteLine("I am a house, my size is {0} m2", this.area);
    }
}

class Door
{
    private string color;

    public Door()
    {
        this.color = "brown";
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public void ShowData()
    {
        Console.WriteLine("I am a door, my color is {0}", this.color);
    }
}

class SmallApartment : House
{
    public SmallApartment() : base(50)
    {
    }

}

class Person
{
    private string name;
    private House house;

    public Person(string name, House house)
    {
        this.name = name;
        this.house = house;
    }

    public void ShowData()
    {
        Console.WriteLine("My name is {0}", this.name);
        this.house.ShowData();
        this.house.GetDoor().ShowData();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmallApartment myApartment = new SmallApartment();
        
        Person me = new Person("John", myApartment);
        myApartment.ShowData();
        
    }
}