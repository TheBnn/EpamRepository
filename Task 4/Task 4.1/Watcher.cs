using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task_4._1
{
	class Watcher
	{

        string logFilePath = @"C:\Program Files (x86)\uWindsor\FileManagementSystem\Log.txt";
        string trackFilePathDirectory = @"C:\Program Files (x86)\uWindsor\FileManagementSystem\";


        public static void Watch()
		{
			
		}
        private string ReadDirectory()
        {
            FileStream fs = new FileStream(trackFilePathDirectory, FileMode.OpenOrCreate, FileAccess.Read);
            string trackDirectoryName = "";

            using (StreamReader sr = new StreamReader(fs))
            {
                trackDirectoryName = sr.ReadLine();
            }

            return trackDirectoryName;
        }

    }
}
