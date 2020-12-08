namespace MassData.Models.Models
{
    class LayoutModel
    {
        internal int Id;
        internal string Name;
        internal string Obs;

        internal static string GetSqlSelect()
        {
            return "SELECT " +
                    "* " +
                    "FROM layouts";
        }
    }
}
