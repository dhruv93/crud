using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
namespace dhruvWeek4
{
	public class ItemDatabase
	{
		readonly SQLiteAsyncConnection database;
		public ItemDatabase(string dbPath)
		{
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Item>().Wait();
		}
		public Task<List<Item>> RetrieveItems()
		{
			return database.Table<Item>().ToListAsync();
		}
		public Task<Item> RetrieveSpecificItem(int id)
		{
			return database.Table<Item>().Where(i => i.ItemID == id).FirstOrDefaultAsync();
		}
		public Task<int> InsertItem(Item item)
		{
            if (item.ItemID != 0) //Updating Item
                return database.UpdateAsync(item);
            
            return database.InsertAsync(item);
		}
		
		public Task<int> deleteItem(Item item)
		{
			return database.DeleteAsync(item);
		}
	}
}
