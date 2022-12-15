namespace BuilderDemoLib.v1;

public class House
{
    public int Windows { get; set; }
    public int Doors { get; set; }
    public int Rooms { get; set; }
    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }
    public bool HasStatues { get; set; }
    public bool HasGarden { get; set; }

    public House(int windows, int doors, int rooms, bool hasGarage, bool hasSwimmingPool, bool hasStatues, bool hasGarden)
    {
        Windows = windows;
        Doors = doors;
        Rooms = rooms;
        HasGarage = hasGarage;
        HasSwimmingPool = hasSwimmingPool;
        HasStatues = hasStatues;
        HasGarden = hasGarden;
    }
    
    public override string ToString()
    {
        return $"{this.GetType()} {(HasGarage ? "with" : "without")} garage, {(HasSwimmingPool ? "with" : "without")} swimming pool, {(HasStatues ? "with" : "without")} statues, {(HasGarden ? "with" : "without")} garden, {Windows} windows, {Doors} doors, {Rooms} rooms";
    }
}
