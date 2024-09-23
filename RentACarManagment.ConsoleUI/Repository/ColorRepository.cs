

using RentACarManagement.ConsoleUI.Model;

namespace RentACarManagement.ConsoleUI.Repository;

public class ColorRepository
{
    List<Color> colors = new List<Color>()
        {
            new Color(1,"White"),
            new Color(2,"Black"),
            new Color(3,"Blue"),
            new Color(4,"Red"),
            new Color(5,"Green")

        };

    public Color Add(Color created)
    {
        colors.Add(created);
        return created;
    }
}
