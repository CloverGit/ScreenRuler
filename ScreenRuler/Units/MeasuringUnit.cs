using ScreenRuler.Properties;

namespace ScreenRuler.Units
{
    /// <summary>
    /// Possible measuring units used for the user scale.
    /// </summary>
    public enum MeasuringUnit
    {
        [LocalizedDescription("Pixels", typeof(EnumResources))]
        Pixels = 0,
        [LocalizedDescription("Millimeters", typeof(EnumResources))]
        Millimeters = 1,
        [LocalizedDescription("Centimeters", typeof(EnumResources))]
        Centimeters = 2,
        [LocalizedDescription("Inches", typeof(EnumResources))]
        Inches = 3,
        [LocalizedDescription("Points", typeof(EnumResources))]
        Points = 4,
        [LocalizedDescription("Percent", typeof(EnumResources))]
        Percent = 5
    }
}
