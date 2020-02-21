using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LeftOverFeast.Model;
using SQLite;
namespace LeftOverFeast
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<FoodStore>().Wait();
        }

        //Insert and Update new record
        public Task<int> SaveItemAsync(FoodStore fs)
        {
            if (fs.FSId != 0)
            {
                return db.UpdateAsync(fs);
            }
            else
            {
                return db.InsertAsync(fs);
            }
        }

        //Delete
        public Task<int> DeleteItemAsync(FoodStore fs)
        {
            return db.DeleteAsync(fs);
        }

        //Read All Items
        //public Task<List<FoodStore>> GetItemsAsync()
        //{
        //    return db.Table<FoodStore>().ToListAsync();
        //}
        public List<FoodStore> GetItemsAsync()
        {
            FoodStore fs=null;
            List<FoodStore> FSList = new List<FoodStore>();
            try
            {
                var data = db.Table<FoodStore>().ToListAsync();
                var res = data.Result;
                for (int i = 0; i <= res.Count; i++)
                {try
                    {
                        fs = new FoodStore();
                        fs.FCategoryid = res[i].FCategoryid;
                        fs.FCategoryName = res[i].FCategoryName;
                        fs.Qty = "Qty : " + res[i].Qty +" "+ res[i].Units;
                        fs.DateStored = "Date Stored : " + res[i].DateStored;
                        fs.ConsumeByDate = "Consumed By Date : " + res[i].ConsumeByDate;
                        fs.DiscardAfterDate = "Discard After Date : " + res[i].DiscardAfterDate;
                        fs.FSId = res[i].FSId;
                        FSList.Add(fs);
                    }
                    catch(Exception ex)
                    {

                    }
                }
               
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return FSList;
        }


        //Read Item
        public Task<FoodStore> GetItemAsync(int FSId)
        {
            return db.Table<FoodStore>().Where(i => i.FSId == FSId).FirstOrDefaultAsync();
        }
    }
}
