using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {


        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            //İş komutları(koşullar vb.)
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            //İş komutları(koşullar vb.)
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            //İş komutları(koşullar vb.)
            return _carDal.GetAll();
        }

        public Car GetById(int Id)
        {
            //İş komutları(koşullar vb.)
            return _carDal.GetById(Id);
        }

        public void Update(Car car)
        {
            //İş komutları(koşullar vb.)
            _carDal.Update(car);
        }
    }
}
