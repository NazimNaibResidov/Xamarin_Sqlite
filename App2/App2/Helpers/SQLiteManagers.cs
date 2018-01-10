using System.Linq;
using App2.Model;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite.Net;

namespace App2.Helpers
{
  
   public class SQLiteManagers
    {  SQLiteConnection _sqlConnection;
        public SQLiteManagers()
        {
            _sqlConnection = DependencyService.Get<ISqlConnection>().GetConnection();
            _sqlConnection.CreateTable<Student>();
        }
        #region
        public bool insert(Student s)
        {
            try
            {
 return _sqlConnection.Insert(s)>0;

            }
            catch (Exception)
            {
                return false;
               
            }
          
        }
        public bool UpDate(Student s)
        {
         
            try
            {
                return _sqlConnection.Insert(s) > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
               return _sqlConnection.Delete<Student>(id)>0;

            }
            catch (Exception)
            {

                return false;
            }
         
        }
        public IList<Student> GetAll()
        {
          return  _sqlConnection.Table<Student>().ToList();
        }
        public Student Get(int id)
        {
          return  _sqlConnection.Table<Student>().FirstOrDefault<Student>(x => x.id == id);
        }
        #endregion
    }
}
