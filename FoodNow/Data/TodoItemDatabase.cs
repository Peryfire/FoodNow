using SQLite;
using FoodNow.Model;

namespace FoodNow.Data
{
    public class TodoItemDatabase
    {
        SQLiteAsyncConnection Database;
        public TodoItemDatabase()
        {

        }

        async Task Init()
        {
            if (Database is not null)
                return;
            string path = @"foodnow.db3";
            //Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            Database = new SQLiteAsyncConnection(path, Constants.Flags);
            var result = await Database.CreateTableAsync<Food>();
        }
        public async Task<List<Food>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<Food>().ToListAsync();
        }

        //public async Task<List<Food>> GetItemsNomeAsync()
        //{
        //    await Init();
        //    return await Database.Table<Food>().Where(t => t.Nome).ToListAsync();

        //    // SQL queries are also possible
        //    //return await Database.QueryAsync<Food>("SELECT * FROM [Food] WHERE [Done] = 0");
        //}

        public async Task<Food> GetItemAsync(string nome)
        {
            await Init();
            return await Database.Table<Food>().Where(i => i.Nome == nome).FirstOrDefaultAsync();
        }


        public async Task<int> SaveItemAsync(Food item)
        {
            await Init();
            //if (item.Nome != "")
            //    return await Database.UpdateAsync(item);
            //else
            return await Database.InsertAsync(item);
        }


        // Elimina l'oggetto dal database utilizando la primary key fornita
        // restituisce un intero (il numero della riga eliminata)
        public async Task<int> DeleteItemAsync(Food item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }
    }
}
