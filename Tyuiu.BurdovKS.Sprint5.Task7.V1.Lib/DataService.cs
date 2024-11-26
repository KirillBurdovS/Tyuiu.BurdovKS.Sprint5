



using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BurdovKS.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {

            string str = File.ReadAllText(path);
            str = string.Concat(str.Where(c => !Char.IsNumber(c)));

            string outpath = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V1.txt";
            FileInfo fileinfo = new FileInfo(outpath);
            if (fileinfo.Exists)
                File.Delete(outpath);
            
            File.WriteAllText(outpath, str);
            return outpath;
        }
    }
}