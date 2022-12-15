namespace BuilderDemoLib.v2;

public class HouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public IHouseBuilder AddWindows(int windows)
    {
        _house.Windows = windows;
        return this;
    }

    public IHouseBuilder AddDoors(int doors)
    {
        _house.Doors = doors;
        return this;
    }

    public IHouseBuilder AddRooms(int rooms)
    {
        _house.Rooms = rooms;
        return this;
    }

    public IHouseBuilder AddGarage()
    {
        _house.HasGarage = true;
        return this;
    }

    public IHouseBuilder AddSwimmingPool()
    {
        _house.HasSwimmingPool = true;
        return this;
    }

    public IHouseBuilder AddStatues()
    {
        _house.HasStatues = true;
        return this;
    }

    public IHouseBuilder AddGarden()
    {
        _house.HasGarden = true;
        return this;
    }

    public House Build()
    {
        return _house;
    }

    public IHouseBuilder Reset()
    {
        _house = new House();
        return this;
    }
}