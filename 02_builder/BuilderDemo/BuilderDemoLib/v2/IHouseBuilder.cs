namespace BuilderDemoLib.v2;

public interface IHouseBuilder
{
    IHouseBuilder Reset();
    IHouseBuilder AddWindows(int windows);
    IHouseBuilder AddDoors(int doors);
    IHouseBuilder AddRooms(int rooms);
    IHouseBuilder AddGarage();
    IHouseBuilder AddSwimmingPool();
    IHouseBuilder AddStatues();
    IHouseBuilder AddGarden();
    House Build();
}