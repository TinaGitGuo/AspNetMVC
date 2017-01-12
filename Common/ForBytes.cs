using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


public static class ForBytes
{
    /// <summary>
    /// Get file data
    /// </summary>
    /// <param name="Path">file path</param>
    /// <returns></returns>
    public static byte[] GetByteData(string Path)
    {
        FileStream fs = new FileStream(Path, FileMode.Open);
        byte[] byteData = new byte[fs.Length];
        fs.Read(byteData, 0, byteData.Length);
        fs.Close();
        return byteData;
    }
    public static byte[] GetByteFromString(string str)
    {
      return  System.Text.Encoding.Default.GetBytes(str);    
    }
    public static Stream GetStreamFromBytes(byte[] bytes)
    {
        return new MemoryStream(bytes);
    }
   

}
