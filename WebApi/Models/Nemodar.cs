namespace WebApi.Models
{
    public class Nemodar : PointLine
    {
        public string OnALine(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Point dot1 = new Point()
            {
                x = x1,
                y = y1,
            };
            Point dot2 = new Point()
            {
                x = x2,
                y = y2,
            };
            Point dot3 = new Point()
            {
                x = x3,
                y = y3,
            };
            double m1 = (dot2.y - dot1.y) / (dot2.x - dot1.x);
            double m2 = (dot3.y - dot2.y) / (dot3.x - dot2.x);
            if (m1 == m2)
            {
                string result = "is on the line";

                return result;
            }
            else
            {
                string result = "is not on the line";
                return result;
            }
        }


    }

}

   

