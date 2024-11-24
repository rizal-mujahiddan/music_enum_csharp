using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Library {
    public class MusicSheetTempo {
        public MusicNote musicNote {get;set;}
        public TempoConvert tempoConvert {get;set;}
        public MusicSheetTempo(string musicNoteku, int bpm){
            this.musicNote = new MusicNote(musicNoteku);
            this.tempoConvert = new TempoConvert(bpm);
        }
        public void beep(){
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                Console.Beep(this.musicNote.noteFreq,this.tempoConvert.period);
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)){
                var stringArgument = $"-f {this.musicNote.noteFreq} -l {this.tempoConvert.period}";
                Process.Start("beep",stringArgument);
            }
        }
    }
}