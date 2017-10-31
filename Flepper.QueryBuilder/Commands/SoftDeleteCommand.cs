namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISoftDeleteCommand
    {
        public ISoftDeleteCommand SoftDeleteCommand(string schema, string table)
        {
            Command.Append($"UPDATE [{schema}].[{table}] ");
            return this;
        }

        public ISoftDeleteCommand SoftDeleteCommand(string table)
        {
            Command.Append($"UPDATE [{table}] ");
            return this;
        }

        public ISoftDeleteCommand SoftDeleteCommand()
        {
            Command.Append("UPDATE ");
            return this;
        }
        
    }
}