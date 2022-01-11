using System;
using System.Collections.Generic;
using System.Text;

namespace static_esimerkki
{
    static class Muuntaja
    {
        public static float KMtoMiles(float km)
        {
            float mailiArvo = 0.62137f;
            return km * mailiArvo;
        }
    }
}
