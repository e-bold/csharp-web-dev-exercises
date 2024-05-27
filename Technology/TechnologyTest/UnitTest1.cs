namespace TechnologyTest;
using Technology;

[TestClass]
public class TechnologyTest
{
    [TestMethod]
    public void TestIncreasingRam()
    {
        //Arrange
        Computer testingComputer = new(8, 256, 4000, true);

        //Act
        testingComputer.IncreaseRam(8);

        //Assert
        Assert.AreEqual(16, testingComputer.Ram);
    }

    [TestMethod]
    public void TestTakingSelfie()
    {
        //Arrange
        SmartPhone iphone = new SmartPhone(3, 64, 4000, false, 2015);

        //Act
        iphone.TakeSelfie();
        iphone.TakeSelfie();
        iphone.TakeSelfie();

        //Assert
        Assert.AreEqual(3, iphone.NumberOfSelfies);
    }
    [TestMethod]
    public void TestingLaptopWeight()
    {
        //Arrange
        Laptop alienware = new Laptop(16, 1024, 8000, true, 9);

        //Act. None to act
        

        //Assert
        Assert.AreEqual(9, alienware.Weight, 0.0001);
        Assert.AreEqual(true, alienware.IsClunky());
    }

    [TestMethod]
    public void TestingBatteryChange()
    {
        //Arrange
        Computer generic = new Computer(4, 128, 4500, true);

        //Act
        generic.UseHours(2);

        //Assert
        Assert.AreEqual(3600, generic.CurrentBatteryLevel);
    }
    [TestMethod]
    public void TestInheritsId()
    {
        //Arrange
        SmartPhone testingSmartphone1 = new SmartPhone(8, 256, 5000, false, 2021);
        SmartPhone testingSmartphone2 = new SmartPhone(16, 128, 3500, false, 2016);

        //Act
        

        //Assert
        Assert.AreEqual(1, testingSmartphone1.Id);
        Assert.AreEqual(2, testingSmartphone2.Id);
    }

    
    [TestMethod]
    public void TestInheritingBaseConstructor()
    {
        //Arrange
        Laptop elitebook = new Laptop(16, 256, 6500, true, 3.2);
        //Act
        

        //Assert
        Assert.IsNotNull(elitebook.Id);
    }
}

