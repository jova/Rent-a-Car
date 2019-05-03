using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.RentServiceReference;
using Desktop.VehicleServiceReference;
using Desktop.LoginServiceReference;
using Desktop.MusteriServiceReference;
using Service;

namespace Desktop
{
    public partial class MusteriIstekleri : MetroFramework.Forms.MetroForm
    {
        private VehicleServiceServiceSoapClient vehicleService;
        private LoginServiceSoapClient loginService;
        private CustomerServiceSoapClient CustomerService;
        private RentServiceSoapClient rentService;

        public MusteriIstekleri()
        {
            InitializeComponent();

            loginService = new LoginServiceSoapClient();
            vehicleService = new VehicleServiceServiceSoapClient();
            CustomerService = new CustomerServiceSoapClient();
            rentService = new RentServiceSoapClient();

            List<VehicleInformation> vehicles = vehicleService.GetAll().ToList();
            List<RentServiceReference.Rentalinformation> rents = rentService.GetAll().ToList();

            List<Models.RentRequestViewModel> requests = new List<Models.RentRequestViewModel>();//musteriistekleri icin
            List<Models.RentRequestViewModel> renteds = new List<Models.RentRequestViewModel>();//kiralanan araclaricin

            foreach (var rent in rents)
            { //customer get eklemis
                MusteriServiceReference.Customer cust = CustomerService.Get(rent.CustomerID);
                VehicleServiceReference.VehicleInformation vehicle = vehicleService.Get(rent.CustomerID);

                Models.RentRequestViewModel req = new Models.RentRequestViewModel();
                req.Id = rent.Id;
                req.CustomerName = cust.Name + " " + cust.Surname;
                req.TCNumber = cust.TCNumber;
                req.HowManyDays = rent.HowManyDays;
                req.VehicleName = vehicle.Name + " " + vehicle.Model;

                if (rent.IsActive) renteds.Add(req);
                else requests.Add(req);
            }


            dataGridMusteri.DataSource = (object)requests;
        }
    }
}
