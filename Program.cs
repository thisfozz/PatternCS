using BuilderGameChapterNamespace;
using BuilderHouseExampleNamespace;

//BuilderHouseExample();
BuilderCharacterGameExample();

void BuilderCharacterGameExample()
{
    var builder = new CharacterBuilder();
    var director = new CharacterDirector(builder);

    Console.WriteLine("Создание варвара");
    director.ConstructBarbarian();
    Character barbarian = builder.GetCharacter();
    barbarian.DisplayInfo();

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Создание волшебницы");
    director.ConstructSorceress();
    Character sorceress = builder.GetCharacter();
    sorceress.DisplayInfo();

    Console.WriteLine("Создание друида");
    director.ConstructDruid();
    Character druid = builder.GetCharacter();
    druid.DisplayInfo();

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Создание кастомного персонажа");
    builder.SetClass("Охотник");
    builder.SetHealth(700);
    builder.SetAttackPower(90);
    Character customCharacter = builder.GetCharacter();
    customCharacter.DisplayInfo();
}
void BuilderHouseExample()
{
    var director = new Director();
    var builder = new ConcreteBuilder();
    director.Builder = builder;

    Console.WriteLine("Минимальная базовая часть дома");
    director.BuildMinimalViableProduct();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Построенный дом состоит из: ");
    director.BuildFullFeaturedProduct();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Кастомный дом: ");
    builder.BuildFoundation();
    builder.BuildPartWallOne();
    builder.BuildPartWallTwo();
    Console.Write(builder.GetProduct().ListParts());
}