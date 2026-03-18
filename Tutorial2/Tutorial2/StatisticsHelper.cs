using System.Runtime.CompilerServices;

namespace Tutorial2;

public class StatisticsHelper
{
    private List<int> Database;


    public StatisticsHelper()
    {
        Database = new List<int>();
    }

    public void addValue(int value)
    {
        Database.Add(value);
    }

    public void validation(int value)
    {
        if (value < 0 || value > 100)
            throw new ArgumentException("Number have to be between 0 and 100");
        
        Database.Add(value);
        
    }
}