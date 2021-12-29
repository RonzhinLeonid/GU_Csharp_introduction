namespace Data.Abstract
{
    public interface IBuilder
    {
        long ID { get; }
        int Height { get; }
        int FloorCount { get; }
        int ApartmentCount { get; }
        int EntranceCount { get; }
        void ChangeHeight(int newHeight);
        void ChangeFloorCount(int newCount);
        void ChangeApartmentCount(int newCount);
        void ChangeEntranceCount(int newCount);
        double GetFloorHeight();
        int GetApartmentCountInEntrance();
        int GetApartmentCountInFloor();
    }
}
