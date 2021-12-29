using Data.Abstract;

namespace Data
{
    public sealed class Creator : IBuilderFactory
    {
        public IBuilder CreateBuild(int height, int floors, int apartments, int entrances)
        {
            return new Building() { Height = height, FloorCount = floors, ApartmentCount = apartments, EntranceCount = entrances };
        }
    }
}
