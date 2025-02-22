using System.Windows;
using System.Windows.Documents;

namespace MilBD;

public class MilBase
{
    public static List<MilBaseInfo> info;

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
    
    public static void Add(MilBaseInfo addInfo)
    {
        info = new List<MilBaseInfo>();
        info.Add(addInfo);
    }

    public static MilBaseInfo SearchByStreet(string street)
    {
        return info.Find((s => s.Street == street));
    }
    
    public static void ShowInfo(string street)
    {
        MilBaseInfo found = SearchByStreet(street);
        if (found != null)
        {
            MessageBox.Show($"Город: {found.City}\nУлица: {found.Street}\nНомер: {found.Number}\nИмя: {found.Firstname} {found.Fatherly} {found.Lastname}",
                "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show("Объект не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

}