using CRUDMongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUDMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpPut]
        public ActionResult<Employee> CreateEmployee(Employee employee)
        {
            //[HttpPost]
            //public object Addemployee(Employee objVM)
            //{
            //    try
            //    {   ///Insert Emoloyeee  
            //        #region InsertDetails  
            //        if (objVM.Id == null)
            //        {
            //            string constr = ConfigurationManager.AppSettings["connectionString"];
            //            var Client = new MongoClient(constr);
            //            var DB = Client.GetDatabase("Employee");
            //            var collection = DB.GetCollection<Employee>("EmployeeDetails");
            //            collection.InsertOne(objVM);
            //            return new Status
            //            { Result = "Success", Message = "Employee Details Insert Successfully" };
            //        }
            //        #endregion
            //        ///Update Emoloyeee  
            //        #region updateDetails  
            //        else
            //        {
            //            string constr = ConfigurationManager.AppSettings["connectionString"];
            //            var Client = new MongoClient(constr);
            //            var Db = Client.GetDatabase("Employee");
            //            var collection = Db.GetCollection<Employee>("EmployeeDetails");

            //            var update = collection.FindOneAndUpdateAsync(Builders<Employee>.Filter.Eq("Id", objVM.Id), Builders<Employee>.Update.Set("Name", objVM.Name).Set("Department", objVM.Department).Set("Address", objVM.Address).Set("City", objVM.City).Set("Country", objVM.Country));

            //            return new Status
            //            { Result = "Success", Message = "Employee Details Update Successfully" };
            //        }
            //        #endregion
            //    }

            //    catch (Exception ex)
            //    {
            //        return new Status
            //        { Result = "Error", Message = ex.Message.ToString() };
            //    }
            return NoContent();
        }
    }
}
