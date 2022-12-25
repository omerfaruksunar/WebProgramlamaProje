using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Abstract
{
    //IRepository interface sınıfında tanımladıgımız metodlari GenericRepository kullanarak Generic islemlerine yaptıracak fonksiyonları yaziyoruz.
    public class GenericRepository<T>:IRepository<T> where T : class,new()
    {
        //DataContext'e referans alarak ulasiyoruz ve ardından db isminde bir nesne olusturarak kullaniyoruz.
        DataContext db= new DataContext();
        DbSet<T> data;

        //Silme islemi icin gerekli fonksiyonu yazip DataBase'deki degisikligi kaydediyoruz.
        public void Delete(T p) 
        { 
            data.Remove(p);
            db.SaveChanges();
            
        }
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
