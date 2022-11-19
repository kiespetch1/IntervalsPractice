namespace IntervalsPractice.BaseClasses
{
    public class Pitch {
        private char Name { get; }
    
        private bool Augmented { get; set; }
    
        private bool Diminished { get; set; }
    
        public Pitch(char name, bool augmented, bool diminished) {
            Name = name;
            Augmented = augmented;
            Diminished = diminished;
        }
    
        public char GetName() {
            return Name;
        }
    
        public bool GetAug() {
            return Augmented;
        }
    
        public bool GetDim() {
            return Diminished;
        }
    
        public void SetAug(bool change) {
            Augmented = change;
        }
    
        public void SetDim(bool change) {
            Diminished = change;
        }
        
        public string Print()
        {
            string pitchPrint;
            if (Augmented) 
                pitchPrint = $"{Name}#";
            else if (Diminished) 
                pitchPrint = $"{Name}b";
            else 
                pitchPrint = $"{Name}";
            return pitchPrint;
        }
    }
}

