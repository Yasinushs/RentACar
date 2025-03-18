using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BLL
{
    public class CarsManager
    {

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

                //Save car to database
                return "Car created";

            }
            catch (Exception ex)
            {
                return "Error creating car:"+ex.Message;
            }
        }
    }
}
