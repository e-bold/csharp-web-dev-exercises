namespace Technology;

public class SmartPhone : Computer
{
    public double ReleaseYear {get; set;}
    public int NumberOfSelfies {get; set;}

    public SmartPhone(double ram, double storage, double batteryCapacity, bool hasKeyboard, double releaseYear) : base(ram, storage, batteryCapacity, hasKeyboard)
    {
        ReleaseYear = releaseYear;
        CurrentBatteryLevel = batteryCapacity;
    }

    public bool IsLatest()
    {
        if((2024 - ReleaseYear) < 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void TakeSelfie()
    {
        NumberOfSelfies++;
    }

    public override string ToString()
    {
        string keyboard = hasKeyboard ? "Your smartphone has a keyboard. Strange!" : "Obviously your smartphone doesn't have a physical keyboard";
        string latest = IsLatest() ? "Woow - It's a brand new technology!" : "It's an old phone -> Throw it away!";
        return Environment.NewLine + "You have a smartphone with " + Ram + "GB ram and " + Storage + " GB storage and " + CurrentBatteryLevel + "MAH battery life."+ Environment.NewLine +
        latest + Environment.NewLine + "It has " + NumberOfSelfies + " selfies stored." + Environment.NewLine +
        keyboard + Environment.NewLine;
    }

}
