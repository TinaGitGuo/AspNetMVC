using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


public static class ForBytes
{
    /// <summary>
    /// Get file Bytes
    /// 读取文件
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
    /// <summary>
    /// byte[]转string类型
    /// </summary>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public static string GetStringFromByte(byte[] bytes)
    {
        return System.Text.Encoding.Default.GetString(bytes);
    }
 
    /// <summary>
    /// Get Bytes
    /// string类型转成byte[]：
    /// </summary>
    /// <param name="str">strings</param>
    /// <returns></returns>
    public static byte[] GetByteFromString(string str)
    {
      return  System.Text.Encoding.Default.GetBytes(str);    
    }
    public static Stream GetStreamFromBytes(byte[] bytes)
    {
        return new MemoryStream(bytes);
    }
    /// <summary>
    /// 字符串保存到文档中
    /// </summary>
    /// <param name="str"></param>
    /// <param name="path"></param>
    public static void SaveFile(string str, string path)
    {
        System.IO.StreamWriter _StreamWriter = new System.IO.StreamWriter(path);
        _StreamWriter.Write(str);
        _StreamWriter.Close();
    }
    //public static string GetPath(string path) {

    //    return Server.MapPath("~/Content/JOSN1.json");
    //}

}
