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
            return _context.medicines.ToList();
        }

    }
}
