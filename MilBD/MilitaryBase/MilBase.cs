using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace MilBD;

public class MilBase
{  
    public static List<MilBaseInfo> info = new List<MilBaseInfo>();

    public static MilBaseInfo AddMil(string city, string street, string number, string firstName, string lastName, string fatherly)
    {
        return new MilBaseInfo
        {
            City = city,
            Street = street,
            Number = number,
            Firstname = firstName,
            Lastname = lastName,
            Fatherly = fatherly
        };
    }
    
    public static void Ad(MilBaseInfo addInfo)
    {
        info.Add(addInfo);
    }

    public static void Ser()
    {
        string serialized = JsonConvert.SerializeObject(info);
        
        File.WriteAllText("milBase.json", serialized);
    }

    public static MilBaseInfo SearchByStreet(string street)
    {
        return info.Find((s => s.Street == street));
    }

    public static void ShowInfo(string street)
    {
        MilBaseInfo? milBase = null;
        List<MilBaseInfo> milBaseJson =
            JsonConvert.DeserializeObject<List<MilBaseInfo>>(File.ReadAllText("milBase.json"));

        foreach (var milbase in milBaseJson)
        {
            if(milbase.Street == street) milBase = milbase;
        }
        if (milBase != null)
         {
             MessageBox.Show(
                 $"Місто: {milBase.City}\nВулиця: {milBase.Street}\nБудинок: {milBase.Number}\nІм'я: {milBase.Firstname} {milBase.Fatherly} {milBase.Lastname}",
                 "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
         }
         else
         {
             MessageBox.Show("Об'єкт не знайдено!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
         }
    }
}