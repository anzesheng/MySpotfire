using Spotfire.Dxp.Framework.DocumentModel.State;

namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface INotPersistedProperty : IDocumentNodeChild, ISharedComponent
    {
        PropertyName PropertyName { get; }
    }
}