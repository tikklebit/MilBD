using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace MilBD;

public class MilBase
{  
    private List<MilBaseInfo> _info = new List<MilBaseInfo>();

    // Додає новий запис у вигляді об'єкта MilBaseInfo
    public MilBaseInfo AddMil(string city, string street, string number, string firstName, string lastName, string fatherly)
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
    
    // Додає інформацію до списку та зберігає її у файл.
    public void AddInfo(MilBaseInfo addInfo)
    {
        // Читає існуючі дані з файлу, якщо такі існують
        if (File.Exists("milBase.json"))
        {
            string json = File.ReadAllText("milBase.json");
            if (!string.IsNullOrEmpty(json))
            {
                _info = JsonConvert.DeserializeObject<List<MilBaseInfo>>(json) ?? new List<MilBaseInfo>();
            }
        }
        
        // Додає нову інформацію та зберігає її у файл
        _info.Add(addInfo);
        File.WriteAllText("milBase.json", JsonConvert.SerializeObject(_info));
    }

    // Серіалізує список та записує його у файл
    public void Ser()
    {
        File.WriteAllText("milBase.json", JsonConvert.SerializeObject(_info));
    }

    // Відображає інформацію про об'єкт за вулицею або помилку, якщо об'єкт не знайдено
    public void ShowInfo(string street)
    {
        if (File.Exists("milBase.json"))
        {
            string json = File.ReadAllText("milBase.json");
            List<MilBaseInfo> milBaseJson = string.IsNullOrEmpty(json) 
                ? new List<MilBaseInfo>() 
                : JsonConvert.DeserializeObject<List<MilBaseInfo>>(json) ?? new List<MilBaseInfo>();

            // Пошук об'єкта за вулицею
            var milBase = milBaseJson.Find(mil => mil.Street.Equals(street, StringComparison.OrdinalIgnoreCase));
            
            if (milBase != null)
            {
                MessageBox.Show($"Місто: {milBase.City}\nВулиця: {milBase.Street}\nБудинок: {milBase.Number}\nІм'я: {milBase.Firstname} {milBase.Fatherly} {milBase.Lastname}",
                    "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Об'єкт не знайдено!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        else
        {
            MessageBox.Show("Файл бази даних не знайдено!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // Видалення зі списку об'єкта, вулиця якого була вказана у стрічуі пошуку
    public void DelInfo(string street)
{
    if (File.Exists("milBase.json"))
    {
        string json = File.ReadAllText("milBase.json");
        List<MilBaseInfo> milBaseJson = string.IsNullOrEmpty(json) 
            ? new List<MilBaseInfo>() 
            : JsonConvert.DeserializeObject<List<MilBaseInfo>>(json) ?? new List<MilBaseInfo>();

        var milBase = milBaseJson.Find(mil => mil.Street.Equals(street, StringComparison.OrdinalIgnoreCase));

        if (milBase != null)
        {
            milBaseJson.Remove(milBase);
            File.WriteAllText("milBase.json", JsonConvert.SerializeObject(milBaseJson));
        }
        else
        {
            MessageBox.Show("Об'єкт не знайдено!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    else
    {
        MessageBox.Show("Файл бази даних не знайдено!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
}