namespace Poc.WinApp.LinkedList
{
    public enum E_OrderStatuses
    {
        Available,
        Producing,
        Complete,
        Cancel
    }
    public class ProductionDataModel
    {
        public Guid GUID { get; set; }
        public string OrderNo { get; set; }
        public E_OrderStatuses OrderStatus { get; set; }
    }
}
