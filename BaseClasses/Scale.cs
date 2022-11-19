namespace IntervalsPractice.BaseClasses
{
    public static class Scale {
        private static readonly char[] OctavePitches = {'C', 'D', 'E', 'F', 'G', 'A', 'B'};
        
        public static Pitch CreatePitch() {
            var rnd = new Random();
            var name = OctavePitches[rnd.Next(7)];
            bool sharp = false, flat = false;
            var temp = rnd.Next();
            switch (temp % 3) {
                case 0:
                    sharp = true; break;
                case 1:
                    flat = true; break;
            }
    
            var pitch = new Pitch(name, sharp, flat);
            return pitch;
        }
    }
}


