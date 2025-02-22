using System.Windows;

namespace MilBD;

public class ClassMain
{
    public List<string> list = new List<string>();

    public void WriteToList(string a)
    {
        list.Add(a);
    }

    public bool ReadList(string a)
    {
        bool tf = false;
        foreach (var name in list)
        {
            if (name == a)
            {
                tf = true;
            }
        }

        return tf;
    }
}