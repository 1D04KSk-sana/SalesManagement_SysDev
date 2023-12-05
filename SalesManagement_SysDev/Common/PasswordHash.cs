using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    class PasswordHash
    {
        // 初期化ベクトル"<半角16文字（1byte=8bit, 8bit*16=128bit>"
        private static string AES_IV_256 = @"pf69DL6GrWFyZcMK";
        // 暗号化鍵<半角32文字（8bit*32文字=256bit）>
        private static string AES_Key_256 = @"5TGB&YHN7UJM(IK<5TGB&YHN7UJM(IK<";

        ///////////////////////////////
        //メソッド名：CreatePasswordHash()
        //引　数   ：テキスト、鍵、
        //戻り値   ：ハッシュ化されたパスワード
        //機　能   ：パスワードをハッシュ化
        ///////////////////////////////
        public static string CreatePasswordHash(string text)
        {
            using (RijndaelManaged myRijndael = new RijndaelManaged())
            {
                // ブロックサイズ（何文字単位で処理するか）
                myRijndael.BlockSize = 128;
                // 暗号化方式はAES-256を採用
                myRijndael.KeySize = 256;
                // 暗号利用モード
                myRijndael.Mode = CipherMode.CBC;
                // パディング
                myRijndael.Padding = PaddingMode.PKCS7;

                myRijndael.IV = Encoding.UTF8.GetBytes(AES_IV_256);
                myRijndael.Key = Encoding.UTF8.GetBytes(AES_Key_256);

                // 暗号化
                ICryptoTransform encryptor = myRijndael.CreateEncryptor(myRijndael.Key, myRijndael.IV);

                byte[] encrypted;
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream ctStream = new CryptoStream(mStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(ctStream))
                        {
                            sw.Write(text);
                        }
                        encrypted = mStream.ToArray();
                    }
                }
                // Base64形式（64種類の英数字で表現）で返す
                return (System.Convert.ToBase64String(encrypted));
            }
        }

        ///////////////////////////////
        //メソッド名：ReversePasswordHash()
        //引　数   ：暗号化テキスト、鍵、
        //戻り値   ：復元されたパスワード
        //機　能   ：パスワードの復元
        ///////////////////////////////
        public static string ReversePasswordHash(string cipher)
        {
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                // ブロックサイズ（何文字単位で処理するか）
                rijndael.BlockSize = 128;
                // 暗号化方式はAES-256を採用
                rijndael.KeySize = 256;
                // 暗号利用モード
                rijndael.Mode = CipherMode.CBC;
                // パディング
                rijndael.Padding = PaddingMode.PKCS7;

                rijndael.IV = Encoding.UTF8.GetBytes(AES_IV_256);
                rijndael.Key = Encoding.UTF8.GetBytes(AES_Key_256);

                ICryptoTransform decryptor = rijndael.CreateDecryptor(rijndael.Key, rijndael.IV);

                string plain = string.Empty;
                using (MemoryStream mStream = new MemoryStream(System.Convert.FromBase64String(cipher)))
                {
                    using (CryptoStream ctStream = new CryptoStream(mStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(ctStream))
                        {
                            plain = sr.ReadLine();
                        }
                    }
                }
                return plain;
            }
        }
    }
}
