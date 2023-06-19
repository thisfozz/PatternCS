namespace BuilderHouseExampleNamespace
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder _builder)
        {
            this._builder = _builder;
        }
        public void BuildWoodenHouse()
        {
            _builder.BuildFoundation("деревянный");
            _builder.BuildPartWallOne("деревянный");
            _builder.BuildPartWallTwo("деревянный");
            _builder.BuildPartWallThree("деревянный");
            _builder.BuildPartWallFour("деревянный");
            _builder.BuildPartRoof("деревянный");
        }
        public void BuildBrickHouse()
        {
            _builder.BuildFoundation("кирпичный");
            _builder.BuildPartWallOne("кирпичный");
            _builder.BuildPartWallTwo("кирпичный");
            _builder.BuildPartWallThree("кирпичный");
            _builder.BuildPartWallFour("кирпичный");
            _builder.BuildPartRoof("кирпичный");
        }
    }
}
