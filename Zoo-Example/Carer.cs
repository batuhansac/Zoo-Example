using System.Xml.Linq;

namespace Zoo_Example;

public class Carer
{
    internal string name;

    public Carer(string name)
    {
        this.name = name;
    }

    public static void Register(Carer carer)
    {
        if (string.IsNullOrWhiteSpace(carer.name))
        {
            Console.WriteLine("Bakıcı adını boş bırakamazsınız.");
        }
        else
        {
            Console.WriteLine($"Bakıcı başarıyla oluşturuldu.\nBakıcı Adı: {carer.name}");
        }
    }

    public void FeedAnimal(Animal animal)
    {
        Console.WriteLine($"{name} bakıcısı olduğu {animal.species} {animal.name} besliyor.");
        animal.Eat();
    }

    public void Clean(Animal animal)
    {
        Console.WriteLine($"{name} bakıcısı olduğu {animal.species} {animal.name} temizliyor.");
        animal.GetDirty();
    }
}
