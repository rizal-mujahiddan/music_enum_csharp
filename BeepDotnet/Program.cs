using System;
using System.Runtime.InteropServices;
using Library;

public class Program
{
    public static int StringNoteToFloat(string note)
    {
        var noting = new MusicNote(note);
        return noting.noteFreq;
    }

    public static int BpmToPeriodku(int bpmku){
        var periodku = new TempoConvert(bpmku);
        return periodku.period;
    }

    public static void Main(string[] args)
    {
        var bpmGlobal = 120;
        var periodGlobal = BpmToPeriodku(bpmGlobal);

        var hasil = new MusicSheetToBeep("MusicSheet/laMaritza.txt");
        hasil.beep();
    }
}