using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarot_Test
{
    public class Card
    {
        public FaceMinor FaceMinor { get; set; }
        public Minor Minor { get; set; }
        public FaceMajor FaceMajor { get; set; }
        public Major Major { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", FaceMinor, Minor);

            return string.Format("{0}: {1}", FaceMajor, Major);

            if (isReverse = "true")
            {
                return " in reverse";
            }
        }

        public enum Minor
        {
            Cups,
            Charms,
            Swords,
            Wands
        }

        public enum FaceMinor
        {
            Page,
            Knight,
            Queen,
            King,
            Ace,
            II,
            III,
            IV,
            V,
            VI,
            VII,
            VIII,
            IX,
            X
        }

        public enum Major
        {
            Fool,
            Magician,
            Priestess,
            Empress,
            Emperor,
            Hierophant,
            Lovers,
            Chariot,
            Justice,
            Hermit,
            Wheel,
            Strength,
            Gallows,
            Death,
            Temperance,
            Devil,
            Tower,
            Star,
            Moon,
            Sun,
            Judgment,
            World
        }

        public enum FaceMajor
        {
            Zero,
            I,
            II,
            III,
            IV,
            V,
            VI,
            VII,
            VIII,
            IX,
            X,
            XI,
            XII,
            XIII,
            XIV,
            XV,
            XVI,
            XVII,
            XVIII,
            XIX,
            XX,
            XXI
        }
    }

}