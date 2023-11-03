using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

using Microsoft.AspNetCore.Http.HttpResults;



namespace WebApi.Controllers
{
    public class DController : ControllerBase
    {
        PointLine Pointline;
        public DController(PointLine PointLine)
        {
            this.Pointline = PointLine;
        }

        public IActionResult Index()
        {
            return Ok("please enter coordinates at the order below:" +
                "\n x1, y1, x2, y2, x3, y3" +
                "\n request example: http://localhost:5285/Point/OnALine/?x1=3&y1=11&x2=2&y2=9&x3=0&y3=5");
        }
        public IActionResult onALine(string x1, string y1, string x2, string y2, string x3, string y3)
        {
            try
            {
                double X1 = Convert.ToDouble(x1);
                double Y1 = Convert.ToDouble(y1);
                double X2 = Convert.ToDouble(x2);
                double Y2 = Convert.ToDouble(y2);
                double X3 = Convert.ToDouble(x3);
                double Y3 = Convert.ToDouble(y3);
                return Ok(Pointline.OnALine(X1, Y1, X2, Y2, X3, Y3));
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }
        }
    }
}


    