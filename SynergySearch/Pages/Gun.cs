public class Gun
{
    private string? _name;
    private string? _link;
    private string? _rating;
    private string? _ratingString;
    private string? _borderColor;
    public string? Name {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
            _link = $"icons/{_name!.Replace(' ', '_')}.png";
        } 
    }
    public string? Link
    {
        get
        {
            return _link;
        }
    }
    public string? Quote { get; set; }
    public string? Description { get; set; }
    public string? Rating {
        get
        {
            return _rating;
        }
        set
        {
            _rating = value;
            _ratingString = $"rating-icons/{_rating}.png";
            _borderColor = MatchQualityToColor(_rating!);
        }
    }
    public string? RatingLink
    {
        get
        {
            return _ratingString;
        }
    }

    public string? BorderColor
    {
        get
        {
            return _borderColor;
        }
    }

    public static string MatchQualityToColor(string rating)
    {
        switch (rating) { 

            case "S":
                return "orange";
            case "A":
                return "red";
            case "B":
                return "green";
            case "C":
                return "DarkTurquoise";
            case "D":
                return "SaddleBrown";
            default:
                return "grey";

        }
    }
}
