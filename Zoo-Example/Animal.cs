namespace Zoo_Example;

public class Animal
{
    internal string name;
    internal string species;

    public Animal(string name, string species)
    {
        this.name = name;
        this.species = species;
    }

    public static void Register(Animal animal)
    {
        if (string.IsNullOrWhiteSpace(animal.name) || string.IsNullOrWhiteSpace(animal.species))
        {
            Console.WriteLine("Hayvan adını ve cinsini boş bırakamazsınız.");
        }
        else
        {
            Console.WriteLine($"Hayvan başarıyla oluşturuldu.\nHayvan Adı: {animal.name}\nHayvan Cinsi: {animal.species}");
        }
    }
    public void Eat()
    {
        Console.WriteLine($"{species} {name} yemek yiyor.");
    }

    public void Play(Carer carer)
    {
        Console.WriteLine($"{species} {name} bakıcısı {carer.name} ile oyun oynuyor.");
    }

    public void GetDirty()
    {
        Console.WriteLine($"{species} {name} tekrar kirlendi.");
    }
}
