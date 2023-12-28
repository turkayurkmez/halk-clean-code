using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{

    //Bir excel dosyasındaki verileri PDF tipinde rapora dönüştüren sınıf:
    public class ReportGenerator
    {
        private string excelFilePath;

        public ReportGenerator(string excelFilePath)
        {
            try
            {
                validateFile(excelFilePath);
            }
            catch (FileInvalidException ex)
            {

                throw ex;
            }

            //bool isFormatOK = true;
            //if (!isFormatOK)
            //{
            //    throw new ArgumentException();
            //}


        }

        bool isFileExists(string path) => File.Exists(path);

        bool isFormatAvailable(string path)
        {
            return true;
        }

        bool isValidatedFile(string path) => !isFileExists(excelFilePath) && !isFormatAvailable(excelFilePath);

        void validateFile(string path)
        {
            if (!isValidatedFile(path))
            {
                throw new FileInvalidException();
            }
        }

    }
}
