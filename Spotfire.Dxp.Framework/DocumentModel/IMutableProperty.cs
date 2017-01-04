namespace Spotfire.Dxp.Framework.DocumentModel
{
    public interface IMutableProperty
    {
        void ActivateAndUnfoldMutablePropertyTriggers();
        void FoldAndInactivateMutablePropertyTriggers();
        void ValidateThatTriggerManagerIsEmpty();
    }

    public interface IMutableProperty<T> : IMutableProperty
    {
        /// <summary>
        /// Gets the value constained in the value field with validations and read-transactions.
        /// </summary>
        /// <returns></returns>
        T GetValue();
    }
}