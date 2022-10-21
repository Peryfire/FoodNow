﻿using SQLite;
using FoodNow.Model;
using System.Collections.ObjectModel;
using Android.OS;

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
            //controlla se ha eseguito la connessione con il database
            if (Database is null)
                Database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, Constants.DatabaseFilename), Constants.Flags);
            //controlla se il database esiste
            if (!File.Exists(Path.Combine(FileSystem.AppDataDirectory, Constants.DatabaseFilename)))
            {
                await Database.CreateTableAsync<Food>();
                await Database.InsertAsync(new Food() { Nome = "Mela", Descrizione = "Mela rossa del Trentino", Tipo = "Frutto", Immagine = "mela.png", Prezzo = 0.4 });
                await Database.InsertAsync(new Food() { Nome = "Pera", Descrizione = "Pera del Piemonte", Tipo = "Frutto", Immagine = "pera.png", Prezzo = 0.2 });
                await Database.InsertAsync(new Food() { Nome = "Lasagna", Descrizione = "Al ragù", Tipo = "Pasta", Immagine = "lasagna.png", Prezzo = 8.0 });
                await Database.InsertAsync(new Food() { Nome = "Anguria", Descrizione = "Anguria della Sicilia", Tipo = "Frutto", Immagine = "anguria.png", Prezzo = 12.0 });
                await Database.InsertAsync(new Food() { Nome = "Roastbeef", Descrizione = "Roastbeef di vitello", Tipo = "Carne", Immagine = "roastbeef.png", Prezzo = 10.0 });
            }

            //var stream = await FileSystem.OpenAppPackageFileAsync(Path.Combine(FileSystem.AppDataDirectory, Constants.DatabaseFilename));
            //System.Diagnostics.Debug.Print(Convert.ToString(File.Exists(Path.Combine(FileSystem.AppDataDirectory, Constants.DatabaseFilename))));
            //string path = @"foodnow.db3";
            //Database = new SQLiteAsyncConnection(path, Constants.Flags);
        }
        public async Task<ObservableCollection<Food>> GetItemsAsync()
        {
            await Init();
            return new ObservableCollection<Food>(await Database.Table<Food>().ToListAsync());
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
