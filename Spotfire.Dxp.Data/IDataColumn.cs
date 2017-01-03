namespace Spotfire.Dxp.Data
{
    public interface IDataColumn
    {
        DataColumnProperties Properties { get; }
        DataHierarchy Hierarchy { get; }
        DataValueCollection RowValues { get; }
    }
}