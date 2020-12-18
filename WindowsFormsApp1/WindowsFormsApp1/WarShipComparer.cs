using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya
{
   public class WarShipComparer: IComparer<Ship>
    {
        public int Compare (Ship x,  Ship y )
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().Name.CompareTo(y.GetType().Name);
            }
            if (x is WarShip)
            {
                return ComparerWarShip(x as WarShip, y as WarShip);
            }
            if (x is AircraftCarrier)
            {
                return ComparerAircraftCarrier(x as AircraftCarrier, y as AircraftCarrier);
            }
            return 0;
        }

        private int ComparerWarShip(WarShip x, WarShip y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerAircraftCarrier(AircraftCarrier x, AircraftCarrier y)
        {
            var res = ComparerWarShip(x, y);
            if (res != 0)
            {
                return res;
            }    
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.HasPlane != y.HasPlane)
            {
                return x.HasPlane.CompareTo(y.HasPlane);
            }    
            if (x.HasRadar != y.HasRadar)
            {
                return x.HasRadar.CompareTo(y.HasRadar);
            }
            if (x.HasRunWay != y.HasRunWay)
            {
                return x.HasRunWay.CompareTo(y.HasRunWay);
            }
            return 0;
        }
    }
}