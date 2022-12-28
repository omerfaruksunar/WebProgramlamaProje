using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BusinessLayer.Abstract
{
    //IRepository interface sınıfında tanımladıgımız metodlari GenericRepository kullanarak Generic islemlerine yaptıracak fonksiyonları yaziyoruz.
    public class GenericRepository<T>:IRepository<T> where T : class,new()
    {
        //DataContext'e referans alarak ulasiyoruz ve ardından db isminde bir nesne olusturarak kullaniyoruz.
        DataContext db = null;
        DbSet<T> data=null;

        public GenericRepository()
        {
            this.db=new DataContext();
            data=db.Set<T>();

        }

        public GenericRepository(DataContext db)
        {
            this.db=db;
            data=db.Set<T>();
        }




        //Silme islemi icin gerekli fonksiyonu yazip DataBase'deki degisikligi kaydediyoruz.
         public void Delete(T p) 
         { 
             data.Remove(p);
             db.SaveChanges();

         }
        //public void Delete(T p)
        //{
        //    T existing = data.Find(p);
        //    data.Remove(existing);
        //}

        //Ekleme islemi icin gerekli fonksiyonu yazip DataBase'deki degisikligi kaydediyoruz.
        public void Insert(T p)
        {
            data.Add(p);
            db.SaveChanges();   
        }
        //Guncelleme islemi icin gerekli fonksiyonu yazip DataBase'deki degisikligi kaydediyoruz.
        public void Update(T p)
        {
            db.Entry<T>(p).State= EntityState.Modified;
            db.SaveChanges();
        }
        //Database den eleman getirme islemi icin gerekli fonksiyonu yaziyoruz.
        public T GetById(int id) 
        {
            return data.Find(id);
        }
        //Liste getirme islemi icin gerekli fonksiyonu yaziyoruz.
        public List<T> List()
        {
            return data.ToList();
        }
    }
}
