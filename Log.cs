using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SafeBroadcast
{
    public class Log
    {
        static public StringBuilder _log = new StringBuilder();
        static FileIO fio;
        static public int min = 0;
        static public int max = 10;
        //
        static Log()
        {
            fio = new FileIO();
            fio.OpenWriteFile("aqbcjs.log");
        }
        static public void error(object str)
        {
            log("Erorr:" + str, 10);
        }
        static object syn = new object();
        static public void log(string str, int level)
        {
            if (str == null)
            {
                str = "null";
            }
            fio.WriteLine(DateTime.Now.ToLocalTime() + "->" + str);
        }
        public static void log(object p, int level)
        {
            log(p.ToString(), level);
        }
        static public void log(object str)
        {
            log(str, 0);
        }
    }
    public class FileIO
    {
        private FileStream fsr;
        private FileStream fsw;
        private StreamWriter sw;
        private StreamReader sr;
        // 创建用于读取文件行的文件流和StreamWriter对象
        public void OpenReadFile(string file)
        {
            if (!File.Exists(file))
                File.Create(file).Close();
            fsr = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            sr = new StreamReader(fsr);
        }
        public void Clear()
        {
            CloseWriteFile();
        }
        // 关闭读文件流
        public void CloseReadFile()
        {
            if (fsr != null)
                fsr.Close();
        }
        // 创建用于向文件中追加行的文件流和StreamWriter对象
        public void OpenWriteFile(string file)
        {
            if (!File.Exists(file))  // 如果文件不存在，先创建这个文件
                File.Create(file).Close();
            // 以追加模式打开这个文件
            fsw = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            // 根据创建的FileStream对象来创建StreamWriter对象
            sw = new StreamWriter(fsw, Encoding.Default);
        }
        // 关闭写文件流
        public void CloseWriteFile()
        {
            if (fsw != null)
                fsw.Close();
        }
        // 从文件中读取一行
        public string ReadLine()
        {
            if (sr.EndOfStream)  // 如果文件流指针已经指向文件尾部，返回null
                return null;
            return sr.ReadLine();
        }
        // 向文件中追加一行字符串
        public void WriteLine(string s)
        {
            lock (sw)
            {
                sw.WriteLine(s);
                sw.Flush(); // 刷新写入缓冲区，使这一行对于读文件流可见
            }
        }
        // 用于判断文件流指针是否位于文件尾部
        public bool IsEof()
        {
            return sr.EndOfStream;
        }
    }
}
