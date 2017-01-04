namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface IUndoableZombieCrossReference
    {
    }

    public interface IUndoableZombieCrossReference<TNode, TZombie>
        : IUndoableZombieCrossReference, IUndoableBaseCrossReference
    {
    }
}