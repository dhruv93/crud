using System;
using SQLite;

namespace dhruvWeek4
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ItemID
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public int ItemPoints
        {
            get;
            set;
        }

    }
}
