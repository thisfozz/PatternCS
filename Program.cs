using BuilderGameChapterNamespace;
using BuilderHouseExampleNamespace;

BuilderHouseExample();
//BuilderCharacterGameExample();

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
    var builder = new ConcreteBuilder();
    var director = new Director(builder);

    Console.WriteLine("Деревянный дом");
    director.BuildWoodenHouse();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Кирпичный дом: ");
    director.BuildBrickHouse();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Кастомный дом с бассейном: ");
    builder.BuildFoundation("каменный");
    builder.BuildPartWallOne("каменный");
    builder.BuildPartWallTwo("каменный");
    builder.BuildPartWallThree("каменный");
    builder.BuildPartWallFour("каменный");
    builder.BuildPartRoof("каменный");
    builder.BuildPool();
    Console.WriteLine(builder.GetProduct().ListParts());

    Console.WriteLine("-------------------------------\n");

    Console.WriteLine("Кастомный дом с бассейном и гаражом: ");
    builder.BuildFoundation("каменный");
    builder.BuildPartWallOne("каменный");
    builder.BuildPartWallTwo("каменный");
    builder.BuildPartWallThree("каменный");
    builder.BuildPartWallFour("каменный");
    builder.BuildPartRoof("каменный");
    builder.BuildPool();
    builder.BuildGarage();
    Console.WriteLine(builder.GetProduct().ListParts());
}