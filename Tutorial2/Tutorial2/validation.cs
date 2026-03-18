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
    

}