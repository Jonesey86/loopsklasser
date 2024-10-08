public class View

public class Movies
{
    public string Title { get; set;}
    public int Year { get; set;}
    public string Genre { get; set;}
    
}

public class Model
{
    public List<movie> Movies { get; set;}

    public Model()
    {
        Movies = new List<movie>
    }
}

