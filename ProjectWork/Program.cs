using ProjectWork;

internal class Program
{
    private static void Main(string[] args)

    {
        AddAnimal animal = new AddAnimal();


        animal.Genus = "Sea Creature";
        animal.Name = "Whale";
        animal.Habitat = "Sea";
        animal.Age = 46;
        animal.Lenght = 5;
        animal.Weight = 123;

        Console.WriteLine("Balinanın cinsi : " + animal.Genus + "\n" + "Balinanın adı : " + animal.Name + "\n" + "Balinanın yaşam alanı : " + animal.Habitat + "\n" + " Balinanın yaşı : " + animal.Age + "\n" + "Balinanın boyu : " + animal.Lenght + "\n" + "Balinanın ağırlığı : " + animal.Weight + "\n");
    }





















}




