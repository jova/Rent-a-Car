﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILastKmService
    {
        List<LastKm> GetVehicleKms(int vehicleId);
        List<LastKm> GetAll();
        void Add(LastKm lastKm);
    }
}
