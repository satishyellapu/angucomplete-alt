using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using LeftOverFeast;
using LeftOverFeast.Model;

namespace LeftOverFeast
{
    public class TodoItemDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public TodoItemDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(FoodStore).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(FoodStore)).ConfigureAwait(false);
                    initialized = true;


                }
                //if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(FoodStorage).Name))
                //{
                //    await Database.CreateTablesAsync(CreateFlags.None, typeof(FoodStorage)).ConfigureAwait(false);
                //    initialized = true;


                //}
            }
        }

        public Task<List<FoodStore>> GetItemsAsync()
        {
            return Database.Table<FoodStore>().ToListAsync();
        }

        public Task<List<FoodStore>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<FoodStore>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<FoodStore> GetItemAsync(int id)
        {
            return Database.Table<FoodStore>().Where(i => i.FSId == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(FoodStore item)
        {
            if (item.FSId != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(FoodStore item)
        {
            return Database.DeleteAsync(item);
        }
    }
}

