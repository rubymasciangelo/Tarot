using System;
using System.Collections.Generic;
using System.Linq;

namespace tarot.Models
{
    public class  Card
    {
        public FaceMinor FaceMinor { get; set; }
        public Minor Minor { get; set; }
        public FaceMajor FaceMajor { get; set; }
        public Major Major { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", FaceMinor, Minor ^ FaceMajor, Major);

            if(isReverse = "true")
            {
                return " in reverse";
            }
        }
    }

}