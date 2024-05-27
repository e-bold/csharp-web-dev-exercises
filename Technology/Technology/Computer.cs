using System.Security.Authentication.ExtendedProtection;

namespace Technology;

public class Computer : AbstractEntity
{
    public double Ram {get; set;}
    public double Storage {get; set;}
    public double BatteryCapacity {get; set;}
    public readonly bool hasKeyboard;
    public double CurrentBatteryLevel {get; set;}

    public Computer(double ram, double storage, double batteryCapacity, bool hasKeyboard)
    {
        Ram = ram;
        Storage = storage;
        BatteryCapacity = batteryCapacity;
        this.hasKeyboard = hasKeyboard;
        CurrentBatteryLevel = batteryCapacity;
    }
    public void ChargeHours(double hours)
    {
        double chargeAmount = hours * 0.1 * BatteryCapacity;
        CurrentBatteryLevel += chargeAmount;

        if(CurrentBatteryLevel > BatteryCapacity)
        {
            CurrentBatteryLevel = BatteryCapacity;
        }

    }
    public void UseHours (double hours)
    {
        double usageAmount = hours * 0.1 * BatteryCapacity;
        CurrentBatteryLevel -= usageAmount;
        if (CurrentBatteryLevel < 0)
        {
            CurrentBatteryLevel = 0;
        }

    }
    public double IncreaseRam (double ramSize)
    {
        return Ram += ramSize;
    }
    public double AddStorage (double exraStorage)
    {
        return Storage += exraStorage;
    }

    public override string ToString()
    {
        return "You have a computer with " + Ram + "GB ram and " + Storage + " GB storage and " + CurrentBatteryLevel + "MAH battery life.";
    }



}
