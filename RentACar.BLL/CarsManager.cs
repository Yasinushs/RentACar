using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentACar.DAL;

namespace RentACar.BLL
{
    public class CarsManager
    {
        RentACarDBEntities db = new RentACarDBEntities();

        public string  CreateCar(string carName,string carModel,string motorPower)
        {

            try
            {
                if (string.IsNullOrEmpty(carName))
                {
                    throw new Exception("Car name is required");
                }
                if (string.IsNullOrEmpty(carModel))
                {
                    throw new Exception("Car model is required");
                }
                if (string.IsNullOrEmpty(motorPower))
                {
                    throw new Exception("Motor power is required");
                }

                Cars car = new Cars();
                car.Name = carName;
                car.Power = motorPower;
                car.Model = carModel;

                db.Cars.Add(car);
                int saveResult= db.SaveChanges();
                if (saveResult>0)
                {

                    return "Success ";
                }

                //Save car to database
                return "Car no added";

            }
            catch (Exception ex)
            {
                return "Error creating car:"+ex.Message;
            }
        }


        public List<Cars> CarList()
        {
            return db.Cars.ToList();
        }
    }
}
