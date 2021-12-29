namespace Data.Abstract
{
    public interface IBuilderFactory
    {
        IBuilder CreateBuild(int height, int floors, int apartments, int entrances);
    }
}
