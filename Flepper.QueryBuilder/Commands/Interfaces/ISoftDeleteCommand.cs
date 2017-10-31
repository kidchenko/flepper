namespace Flepper.QueryBuilder
{
    /// <summary>
    /// SoftDelete Command Interface.
    /// </summary>
    public interface ISoftDeleteCommand : IQueryCommand
    {
        /// <summary>
        /// SoftDelete Command Interface.
        /// </summary>
        /// <returns></returns>
        ISoftDeleteCommand SoftDeleteCommand(string table);

        /// <summary>
        /// Softs the delete command.
        /// </summary>
        /// <returns>The delete command.</returns>
        /// <param name="scheam">Scheam.</param>
        /// <param name="table">Table.</param>
        ISoftDeleteCommand SoftDeleteCommand(string scheam, string table);
    }
}
