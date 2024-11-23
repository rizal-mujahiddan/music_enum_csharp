namespace Library {
    public class TempoConvert {
        public int period {get;set;}
        public int bpmToPeriod(int bpm){
            var valueBPM = 1/(bpm / 60.0) * 1000.0;
            return Convert.ToInt32(valueBPM);
        }
        public TempoConvert(int bpm) {
            this.period = bpmToPeriod(bpm);
        }
    }
}