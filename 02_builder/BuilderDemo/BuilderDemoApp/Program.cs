// v1: build a house without using Builder Pattern

using v1 = BuilderDemoLib.v1;
using v2 = BuilderDemoLib.v2;

var houseV1 = new v1.House(windows: 10, doors: 5, rooms: 3, hasGarage: true, hasSwimmingPool: true, hasStatues: true, hasGarden: true);

Console.WriteLine(houseV1);

// v2: build a house using Builder Pattern

// use director to build a house

var houseDirector = new v2.HouseDirector(new v2.SimpleHouseBuilder());

var houseV2 = houseDirector.BuildHouse(v2.HouseType.Simple);

Console.WriteLine(houseV2);

houseV2 = houseDirector.BuildHouse(v2.HouseType.Complex);

Console.WriteLine(houseV2);

houseDirector.ChangeBuilder(new v2.LuxuryHouseBuilder());

houseV2 = houseDirector.BuildHouse(v2.HouseType.Complex);

Console.WriteLine(houseV2);

// create a new house builder and use fluent interface to build a house

var houseBuilder = new v2.HouseBuilder();

var simpleHouseV2 = houseBuilder
    .AddWindows(5)
    .AddDoors(5)
    .AddRooms(3)
    .Build();

Console.WriteLine(simpleHouseV2);

var luxuryHouse = houseBuilder
    .Reset()
    .AddWindows(20)
    .AddDoors(10)
    .AddRooms(6)
    .AddGarage()
    .AddSwimmingPool()
    .AddStatues()
    .AddGarden()
    .Build();

Console.WriteLine(luxuryHouse);