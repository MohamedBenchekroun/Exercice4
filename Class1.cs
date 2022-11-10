using System;

public class Class1
{
    public class cercle : Point
    {
        Point centre;
        double rayon;
        public cercle()
        {
            centre = new Point();
            rayon = 0;
        }
        public void setCentre(float x, float y)
        {
            centre.x = x;
            centre.y = y;
        }
        public void setRayon(double d)
        {
            rayon = d;
        }

        public bool Egalite(cercle c1)
        {
            if ((c1.centre == centre) && (c1.rayon == rayon)) return true;
            else
            {
                return false;
            }
        }

        public double calculcir()
        {
            double c = 0;
            c = 2 * Math.PI * rayon;
            return c;
        }

        public double air()
        {
            double air = 0;
            air = Math.PI * rayon * rayon;
            return air;
        }

        public class droite : Point
        {
            Point p1;
            Point p2;
            public droite(Point a, Point b)
            {
                a = p1;
                b = p2;

            }
            public void setpoints()
            {

            }

        }

        public bool egalite(droite d1)
        {
            if (d1.p1 == p1 && d1.p2 == p2) return true;
            else return false;

        }
    }
