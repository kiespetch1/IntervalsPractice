namespace IntervalsPractice.BaseClasses
{
    public class Interval {
        private string Title { get; }
        private byte Pitches { get; }
        private short Halfsteps { get; }
    
        public Interval(string title, byte pitches, short halfsteps) {
            Title = title;
            Pitches = pitches;
            Halfsteps = halfsteps;
        }
    
        public string GetTitle() {
            return Title;
        }
    
        public byte GetPitches() {
            return Pitches;
        }
    
        public short GetHalfsteps() {
            return Halfsteps;
        }
    
        public string Print() {
            return $"{Title}, {Pitches} pitches, {Halfsteps} halfsteps";
        }
    }
}


