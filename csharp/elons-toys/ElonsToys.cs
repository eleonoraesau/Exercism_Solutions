using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy() => new RemoteControlCar();
    private int distance = 0;
    private int battery = 100;

    public string DistanceDisplay() => $"Driven {distance} meters";

    public string BatteryDisplay() => battery == 0 ? "Battery empty" : $"Battery at {battery}%";

    public void Drive()
    {
        if (battery> 0)
         {
            distance +=20;
            battery -=1;
        }
    }
}
