using System;
using System.Linq;
using System.Collections.Generic;

public interface IWaterVehicle
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}
public interface IAirVehicle
{
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly();

}
public interface ILandVehicle
{
    int Wheels { get; set; }
    double MaxLandSpeed { get; set; }
    void Drive();
}

public interface IVehicle
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();

    
}

public class JetSki : IVehicle, IWaterVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class SpeedBoat : IVehicle, IWaterVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxWaterSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The speed boad pulls passengers in a tube who will soon get thrown off and suffer a concussion");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IVehicle, ILandVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IVehicle, IAirVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    bool IAirVehicle.Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    double IAirVehicle.MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    void IAirVehicle.Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }
}

public class Propplane : IVehicle, IAirVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool Winged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxAirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("The Prop Plane spreds pesticides over all the land");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Ferrari : IVehicle, ILandVehicle
{
    public int Doors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string TransmissionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double EngineVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Wheels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double MaxLandSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Drive()
    {
        Console.WriteLine("The Ferrari whips out of the dealership into a lightpost and the new owner regrets his decision immediately");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        List<IAirVehicle> thingsThatFly = new List<IAirVehicle>();
        Cessna plane = new Cessna();
        Propplane pesticide = new Propplane();
        thingsThatFly.Add(plane);
        thingsThatFly.Add(pesticide);

        // With a single `foreach`, have each vehicle Fly()
        foreach(IAirVehicle flys in thingsThatFly){
            flys.Fly();
        }


        // Build a collection of all vehicles that operate on roads

        List<ILandVehicle> thingsThatDrive = new List<ILandVehicle>();
        Motorcycle bike = new Motorcycle();
        Ferrari coolCar = new Ferrari();
        thingsThatDrive.Add(bike);
        thingsThatDrive.Add(coolCar);

        // With a single `foreach`, have each road vehicle Drive()
        foreach(ILandVehicle ride in thingsThatDrive){
            ride.Drive();
        }


        // Build a collection of all vehicles that operate on water

        List<IWaterVehicle> thingsThatSwim = new List<IWaterVehicle>();
        JetSki ski = new JetSki();
        SpeedBoat midlifeCrisis = new SpeedBoat();
        thingsThatSwim.Add(ski);
        thingsThatSwim.Add(midlifeCrisis);
        
        // With a single `foreach`, have each water vehicle Drive()
        foreach(IWaterVehicle swim in thingsThatSwim){
            swim.Drive();
        }
    }

}