using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LastKmManager : ILastKmService
    {
        ILastKmDal lastKmDal;

        public LastKmManager(ILastKmDal lastKmDal)
        {
            this.lastKmDal = lastKmDal;
        }

        public List<LastKm> GetAll()
        {
            return lastKmDal.GetList();
        }

        public List<LastKm> GetVehicleKms(int vehicleId)
        {
            return lastKmDal.GetList(x => x.vehicleId == vehicleId);
        }
    }
}
