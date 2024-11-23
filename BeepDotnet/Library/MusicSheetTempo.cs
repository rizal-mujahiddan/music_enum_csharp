using System;
using System.Runtime.InteropServices;


namespace Library {
    public class MusicSheetTempo {
        public MusicNote musicNote {get;set;}
        public TempoConvert tempoConvert {get;set;}
        public MusicSheetTempo(string musicNoteku, int bpm){
            this.musicNote = new MusicNote(musicNoteku);
            this.tempoConvert = new TempoConvert(bpm);
        }
        public void beep(){
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) Console.Beep(this.musicNote.noteFreq,this.tempoConvert.period);
        }
    }
}