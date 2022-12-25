using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //Generic olarak bir T tanımladık ve bu T'ye class olma ve new'lenebilme özelliklerini atadık.
    public interface IRepository<T> where T : class,new()
    {
        //Listeleme metodunu list olarak tanımladık.
        List<T> List();
        //Insert olarak ekleme islemini yapacagimiz metodu tanimladik.
        void Insert(T p);
        //Update olarak guncelleme islemini yapacagimiz metodu tanimladik.
        void Update(T p);
        //Delete olarak silme islemini yapacagimiz metodu tanimladik.
        void Delete(T p);
        //GetById kullanarak id degerimizle eleman çekme islemini gerceklestirecek islemi tanımladık.
        T GetById(int id);
    }
}
