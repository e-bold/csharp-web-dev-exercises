using System.Data.Common;

namespace Technology;

public class Laptop : Computer
{
    public double Weight {get; set;}
    public Laptop(double ram, double storage, double batteryCapacity, bool hasKeyboard, double weight) : base(ram, storage, batteryCapacity, hasKeyboard)
    {
        Weight = weight;
        CurrentBatteryLevel = batteryCapacity;
    }

    public bool IsClunky()
    {
        if(Weight > 3)
        {
            return true;
        }
        else{
            return false;
        }
    }

    public override string ToString()
    {
        string keyboard = hasKeyboard ? "Your laptop has a keyboard. Very Cool!" : "Keyboard Non-Existent! How are we going to type?";
        string newText = IsClunky() ? " - Very heavy laptop. My back hurts! - " : " - Light as air. My back is happy! - ";
        return "You have a laptop with " + Ram + "GB ram and " + Storage + " GB storage and " + CurrentBatteryLevel + "MAH battery life." + Environment.NewLine +
        newText+ Environment.NewLine +
        keyboard + Environment.NewLine;
    }


    
}
