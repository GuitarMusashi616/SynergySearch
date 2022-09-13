public class Synergy
{
    public string Name { get; set; }
    public ItemGroup[] ItemGroups { get; set; }
    public string Description { get; set; }
}

public class ItemGroup
{
    public string Type { get; set; }
    public string[] Items { get; set; }
}
