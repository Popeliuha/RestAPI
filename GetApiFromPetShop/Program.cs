using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetApiFromPetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new PetStoreClient();
            var getValidByOrderId = client.GetByOrderId(2);
            Console.WriteLine(getValidByOrderId);
            var getInvalidByOrderId = client.GetByOrderId(12);//id should be 1 to 10
            Console.WriteLine(getInvalidByOrderId);//order will be not found
            var postPet = client.PostPet();
            Console.WriteLine(postPet);
            Console.Read();
        }
    }
}
//прочитати про патерни, апі
