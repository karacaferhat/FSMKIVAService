using FSMKivaService.Entities;
using FSMKivaService.Entities.Requests;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace FSMKivaService.Data
{
    public class BasicDataContext : DbContext
    {
        public BasicDataContext(DbContextOptions<BasicDataContext> options) : base(options) { }

        private DbSet<SerialState> serialStates { get; set; }
        private DbSet<SerialInfo> serialInfos { get; set; }
        private DbSet<DeliveryInfo> deliveryInfos { get; set; }


        public SerialState GetSerialState(GetSerialStateRequest request)
        {
            SqlParameter parameter = new SqlParameter("serial_no", request.SerialNo);
            SerialState result = null;

            try { 
                var query = this.serialStates.FromSqlRaw(@"Z_KIVA_SERIAL_STATE @serial_no", parameter).AsEnumerable();
                result = query.FirstOrDefault();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;

        }


        public SerialInfo GetSerialInfo(GetSerialInfoRequest request)
        {
            SqlParameter parameter = new SqlParameter("serial_no", request.SerialNo);
            SerialInfo result = null;


            try
            {
                var query = this.serialInfos.FromSqlRaw(@"Z_KIVA_SERIAL_INFO @serial_no", parameter).AsEnumerable();
                result = query.FirstOrDefault();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;

        }


        public List<DeliveryInfo> GetDeliveryInfos(GetDeliveryInfoRequest request)
        {
            SqlParameter parameter = new SqlParameter("delivery", request.Delivery);
            List<DeliveryInfo> result = new List<DeliveryInfo>();

            try { 
                var query = this.deliveryInfos.FromSqlRaw(@"Z_KIVA_SERIAL_DELIVERY @delivery", parameter).AsEnumerable();
                result = query.ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return result;

        }
    }
}
