using System.Collections.Generic;

public class UnitMethods
{
    public static IReadOnlyDictionary<int, UnitType> TypeById { get; } = new Dictionary<int, UnitType>
    {
        { 0,  UnitType.Big },
        { 1,  UnitType.Standard }
    };
}
