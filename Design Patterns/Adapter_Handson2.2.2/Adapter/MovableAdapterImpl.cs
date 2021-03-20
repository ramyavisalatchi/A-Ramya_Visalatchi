using System;

namespace Adapter
{
    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable _luxuryCar;

        public MovableAdapterImpl(Movable luxuryCar)
        {
            _luxuryCar = luxuryCar;
        }

        public double GetSpeed()
        {
            return ConvertMPHtoKPH(_luxuryCar.GetSpeed());
        }

        private double ConvertMPHtoKPH(double mph)
        {
            return mph * 1.60934;
        }
    }
}
