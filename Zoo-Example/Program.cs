using Zoo_Example;

Animal giraffe = new("Billie", "Zürafa");
Animal elephant = new("Ellie", "Fil");
Animal panda = new("Buba", "Panda");

Carer carer1 = new("Aytap");
Carer carer2 = new("Tahsin");
Carer carer3 = new("Sertap");

Animal[] animals = { giraffe, elephant, panda };
Carer[] carers = { carer1, carer2, carer3 };

foreach (Animal animal in animals)
{
    Animal.Register(animal);
    Console.WriteLine();
}

foreach (Carer carer in carers)
{
    Carer.Register(carer);
    Console.WriteLine();
}

carer1.FeedAnimal(giraffe);
elephant.Play(carer2);
carer3.Clean(panda);