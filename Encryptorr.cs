using System.IO;

namespace WindowsFormsApp1
{


	class Encryptorr
	{

		byte[] fileData= { };
		string filePath = "None";
		public byte[] ReadFile(string FilePath)
		{
			filePath = FilePath;
			byte[] result = { };
			if (File.Exists(FilePath))
			{
				result = File.ReadAllBytes(FilePath);
			}

			fileData = result;
			return result;
		}
		public void WriteEncryptedFile(string FilePathdat)
        {
            string fileName = FilePathdat + "2";
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                // Write the data to the file, byte by byte.
                for (int i = 0; i < fileData.Length; i++)
                {
                    fileStream.WriteByte((byte)(fileData[i] ^80));
                }            
              
            }
        }
	}
	

}


