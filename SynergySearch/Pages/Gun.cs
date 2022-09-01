public class Gun
{
    public string? Name { get; set; }
    public string? Link { get; set; }
    public string? Quote { get; set; }
    public string? Description { get; set; }
    public string? Rating { get; set; }

    public string? RatingLink
    {
        get
        {
            return $"rating-icons/{this.Rating}.png";
        }
    }

    public string BorderColor
    {
        get
        {
            switch (this.Rating) { 

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
}
