using System.Windows;
using System.Windows.Documents;

namespace MilBD;

internal class MilBase
{
    public List<MilBaseInfo> info = new List<MilBaseInfo>();

    public static MilBaseInfo AddMil(string City, string Street, string Number, string FirstName, string LastName, string Fatherly)
    {
        MilBaseInfo info = new MilBaseInfo();

        info.city = City;
        info.street = Street;
        info.number = Number;
        info.firstname = FirstName;
        info.lastname = LastName;
        info.fatherly = Fatherly;

        return info;
    }

    public void Add(MilBaseInfo addInfo)
    {
        info.Add(addInfo);
    }

    public MilBaseInfo Search(string street)
    {
        return info.Find((s => s.street == street));
    }

    public void FindByStreet(string street)
    {
        MilBaseInfo search = Search()
    }
}