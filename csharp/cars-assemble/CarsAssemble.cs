using System;

static class AssemblyLine
{
    private static readonly int _baseProductionRate = 221;

    public static double SuccessRate(int speed)
    {
      if (speed == 10)
      {
        return 0.77;
      }
      else if (speed == 9)
      {
        return 0.8;
      }
      else if (speed >= 8)
      {
        return 0.9;
      }
      else if (speed >= 5 )
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }

    public static double ProductionRatePerHour(int speed) => _baseProductionRate * speed * SuccessRate;

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
