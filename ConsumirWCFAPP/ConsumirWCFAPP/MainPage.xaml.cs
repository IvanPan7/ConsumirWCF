using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ActividadWCF;
using System.ServiceModel;

namespace ConsumirWCFAPP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetData();
        }
        private void GetData()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress EndPoint = new EndpointAddress("http://192.168.60.157:88/booking");
            //Reservation r = new Reservation
            //{
            //    HotelName = "HotelA"
            //};
            //HotelBookingServiceClient Cliente = new HotelBookingServiceClient(binding, EndPoint);
            //BookingResponse Result = Cliente.BookHotel(r);
            //lblResult.Text = Result.BookingReference.ToString();
        }
    }
}
