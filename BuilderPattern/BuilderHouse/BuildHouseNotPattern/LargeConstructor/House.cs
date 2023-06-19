
namespace Builder.BuilderPattern.BuilderHouse.BuildHouseNotPattern.LargeConstructor
{
    public class House
    {
        private ProductNotTwo _product = new ProductNotTwo();
        public House
            (
                string materialFoundation, 
                string materialWallOne, 
                string materialWallTwo, 
                string materialWallThree,
                string materialWallFour, 
                string materialRoof
            )
            {
                _product.Add(materialFoundation);
                _product.Add(materialWallOne);
                _product.Add(materialWallTwo);
                _product.Add(materialWallThree);
                _product.Add(materialWallFour);
                _product.Add(materialRoof);
            }

        public override string ToString()
        {
            string str = string.Empty;
            foreach ( var item in _product )
            {
                str += item.ToString() + "\n";
            }
            return str;
        }
    }
}
