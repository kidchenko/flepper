using System;
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Soft delete command extensions.
    /// </summary>
    public static class SoftDeleteCommandExtensions
    {
        /// <summary>
        /// From the specified softDeleteCommand and table.
        /// </summary>
        /// <returns>The from.</returns>
        /// <param name="softDeleteCommand">Soft delete command.</param>
        /// <param name="column">Table.</param>
        public static IWhereFilter Where(this ISoftDeleteCommand softDeleteCommand, string column) 
        => softDeleteCommand is IWhereFilter command ? command.Where(column) : null; 


        public static IFromCommand From(this IDeleteCommand softDeleteCommand, string table)
            => softDeleteCommand is IFromCommand command ? command.FromCommand(table) : null;

    }
}
