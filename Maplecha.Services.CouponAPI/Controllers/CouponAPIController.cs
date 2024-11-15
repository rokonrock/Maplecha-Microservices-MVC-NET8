using Maplecha.Services.CouponAPI.Data;
using Maplecha.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Maplecha.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public CouponAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try 
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;
            }
            catch (Exception ex) 
            { 

            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object Get(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u=>u.CouponId==id);
                return obj;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
