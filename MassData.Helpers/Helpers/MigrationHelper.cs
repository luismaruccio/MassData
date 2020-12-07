namespace MassData.Helpers.Helpers
{
    internal class MigrationHelper
    {
        internal static string GetSQLCreateMigrationTable()
        {
            return "CREATE TABLE migrations (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "key VARCHAR(60) NOT NULL, " +
                        "date DATETIME NOT NULL " +
                    ");" +
                    "CREATE INDEX idx_key " +
                        "ON migrations(key);" ;
        }

    }
}
