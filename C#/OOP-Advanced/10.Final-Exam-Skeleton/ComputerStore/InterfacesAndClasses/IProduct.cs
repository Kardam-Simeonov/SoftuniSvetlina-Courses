namespace ComputerStore.InterfacesAndClasses
{
    public interface IProduct
    {
        int Id { get; }

        string Model { get; }

        decimal Price { get; }

        double OverallPerformance { get; }

    }
}
