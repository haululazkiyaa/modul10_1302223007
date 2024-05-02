namespace modul10_1302223007
{
    public class Mahasiswa
    {
        public string name { set; get; }
        public string nim { set; get; }
        public List<string> course { set; get; }
        public int year { set; get; }

        public Mahasiswa(string name, string nim, List<string> course, int year)
        {
            this.name = name;
            this.nim = nim;
            this.course = course;
            this.year = year;
        }
    }
}
