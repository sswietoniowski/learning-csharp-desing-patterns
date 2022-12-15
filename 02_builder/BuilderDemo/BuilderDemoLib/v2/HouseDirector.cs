namespace BuilderDemoLib.v2;

public class HouseDirector
{
    private IHouseBuilder _houseBuilder;

    public HouseDirector(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public void ChangeBuilder(IHouseBuilder houseBuilder)
    {
        _houseBuilder = houseBuilder;
    }

    public House BuildHouse(HouseType houseType)
    {
        switch (houseType)
        {
            case HouseType.Simple:
                return _houseBuilder
                    .Reset()
                    .AddWindows(2)
                    .AddDoors(1)
                    .AddRooms(1)
                    .Build();
            case HouseType.Complex:
                return _houseBuilder
                    .Reset()
                    .AddWindows(10)
                    .AddDoors(5)
                    .AddRooms(3)
                    .AddGarage()
                    .AddSwimmingPool()
                    .AddStatues()
                    .AddGarden()
                    .Build();
            default:
                throw new ArgumentOutOfRangeException(nameof(houseType), houseType, null);
        }
    }
}