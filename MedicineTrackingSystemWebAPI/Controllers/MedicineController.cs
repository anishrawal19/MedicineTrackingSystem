using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicineTrackingSystemWebAPI.Data;
using MedicineTrackingSystemWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicineTrackingSystemWebAPI.Controllers
{
    [Route("api/[Controller]")]
    public class MedicineController : Controller
    {
        private Context _context;

        public MedicineController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Medicine> Get()
        {
            var medicines = _context.medicines.ToList();
            //seeding data if no data in DB
            if (medicines.Count == 0)
            {
                medicines.Add(new Medicine() { Name = "Med1", Brand = "Cipla", ExpiryDate = DateTime.Now, Notes = "cipla med", Price = 100, Quantity = 5, Id = 10 });
                medicines.Add(new Medicine() { Name = "Med2", Brand = "Cipla", ExpiryDate = DateTime.Now, Notes = "cipla med", Price = 100, Quantity = 5, Id = 11 });
                medicines.Add(new Medicine() { Name = "Med3", Brand = "Cipla", ExpiryDate = DateTime.Now, Notes = "cipla med", Price = 100, Quantity = 5, Id = 12 });
            }

            return medicines;
        }

    }
}
