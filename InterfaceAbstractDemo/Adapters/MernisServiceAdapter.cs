using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter:ICustomerCheckService
    {
        public async Task<bool> CheckIfRealPerson(Customer customer) 
        {
            try
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

                var result = await client.TCKimlikNoDogrulaAsync(
                    Convert.ToInt64(customer.NationalityId),
                    customer.FirstName,
                    customer.LastName,
                    customer.DateOfBirth.Year
                    );
            }
            catch (Exception ex)
            {

                Console.WriteLine("Mernis Servis Hatası: " + ex.Message);
                return false;
            }
           
        }
    }
}
