using System.Text.Json;
using System.Text.Json.Serialization;

public class Synergy
{
    public string? Name { get; set; }
    public ItemGroup[]? ItemGroups { get; set; }
    public string? Description { get; set; }

}


public class ItemGroup
{
    public string[]? _items;
    public (string, string)[]? _pairs;
    public string? _type;
    public string? Type
    {
        get
        {
            return _type;
        }
        set
        {
            if (value!.StartsWith("All"))
            {
                _type = "";
                return;
            } 
            _type = value;
        }
    }
    public string[] Items
    {
        get
        {
            return _items;
        }
        set
        {
            _items = value;
            _pairs = GetLabelledIconPairs(_items!);
        }
    }
    public (string, string)[] Pairs
    {
        get
        {
            return _pairs;
        }
    }

    public (string, string)[] GetLabelledIconPairs(string[] items)
    {
        (string, string)[] result = new (string, string)[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            result[i] = (items[i], $"icons/{items[i].Replace(' ','_')}.png");
        }
        return result;
    }
}
