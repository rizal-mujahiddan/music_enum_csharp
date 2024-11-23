using System;
using Extensions;

namespace Library
{
    public class MusicNote {
        public string noteString {get; set;} = "";
        public int noteFreq {get; set;}
        public void setStringtoNote() {
            var panjang = this.noteString.Length;
            if((string.IsNullOrEmpty(this.noteString)) || (panjang > 3) || (panjang < 2)) {
                this.noteString = "a0";
            } 
            var char1 = this.noteString.Substring(0,panjang-1);
            var char2 = this.noteString[panjang-1].ToString();
            const int a4_std = 48;
            const double a4_freq = 440;
            
            EnumCharMusic note_val = char1.GetEnumValueFromDescription<EnumCharMusic>();
            var note1 = (int) note_val;
            var note2 = Convert.ToInt32(char2);
            var noting = note1 + note2 * 12 - 9 - a4_std;
            this.noteFreq = Convert.ToInt32(Math.Round(Math.Pow(2,(noting) / 12.0) * a4_freq));
        }
        public MusicNote(string NoteString){
            this.noteString = NoteString;
            this.setStringtoNote();
        }    
    }
}