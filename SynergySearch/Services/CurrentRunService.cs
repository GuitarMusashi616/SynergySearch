public interface ICurrentRunService
{
    Dictionary<string, bool> Guns { get; set; }
    void AddToRun(string gun);
}
public class CurrentRunService : ICurrentRunService
{
    public CurrentRunService()
    {
        Guns = new Dictionary<string, bool>();
    }
    public Dictionary<string, bool> Guns { get; set; }

    public void AddToRun(string gun)
    {
        Guns.Add(gun, true);
    }
}