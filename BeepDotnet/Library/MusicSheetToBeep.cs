using System.Linq;

namespace Library {
    public class MusicSheetToBeep{
        public List<MusicSheetTempo>? musicSheetTempos {get;set;}
        public void pathFileToMusicSheetTempo(string pathFile) {
            using (StreamReader reader = new StreamReader(pathFile)) {
                string? line;
                while ((line = reader!.ReadLine()) != null){
                    var liningku = line.Replace("(","")
                                    .Replace(")","")
                                    .Split(",");
                    liningku[0] = liningku[0].Trim().ToLower();
                    liningku[1] = liningku[1].Trim();
                    var musicSheetEach = new MusicSheetTempo(liningku[0],Convert.ToInt32(liningku[1]));

                    if (this.musicSheetTempos == null) {
                        this.musicSheetTempos = new List<MusicSheetTempo>();
                    }

                    this.musicSheetTempos.Add(musicSheetEach);
                }
            }
        }
        public MusicSheetToBeep (string pathFile) {
            this.pathFileToMusicSheetTempo(pathFile);
        }

        public void beep(){
            if(this.musicSheetTempos != null){
                foreach(var beepku in this.musicSheetTempos) {
                    beepku.beep();
                }
            }
        }
    }
}