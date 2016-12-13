using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string aes = "CiyLU1Aw2KjvrjMdj8YKliAjtP4gsMZM" +
    "QmRzooG2xrDcvSnxIMXFufNstNGTyaGS" +
    "9uT5geRa0W4oTOb1WT7fJlAC+oNPdbB+" +
    "3hVbJSRgv+4lGOETKUQz6OYStslQ142d" +
    "NCuabNPGBzlooOmB231qMM85d2/fV6Ch" +
    "evvXvQP8Hkue1poOFtnEtpyxVLW1zAo6" +
    "/1Xx1COxFvrc2d7UL/lmHInNlxuacJXw" +
    "u0fjpXfz/YqYzBIBzD6WUfTIF9GRHpOn" +
    "/Hz7saL8xz+W//FRAUid1OksQaQx4CMs" +
    "8LOddcQhULW4ucetDf96JcR3g0gfRK4P" +
    "C7E/r7Z6xNrXd2UIeorGj5Ef7b1pJAYB" +
    "6Y5anaHqZ9J6nKEBvB4DnNLIVWSgARns" +
    "/8wR2SiRS7MNACwTyrGvt9ts8p12PKFd" +
    "lqYTopNHR1Vf7XjfhQlVsAJdNiKdYmYV" +
    "oKlaRv85IfVunYzO0IKXsyl7JCUjCpoG" +
    "20f0a04COwfneQAGGwd5oa+T8yO5hzuy" +
    "Db/XcxxmK01EpqOyuxINew==";

            Console.WriteLine(AES_decrypt(aes, "tiihtNczf5v6AKRyjwEUhQ==", "r7BXXKkLb8qrSNn05n0qiA=="));
            Console.ReadKey();
        }

        public static string AES_decrypt(string encryptedDataStr, string key, string iv)
        {


            RijndaelManaged rijalg = new RijndaelManaged();

            //-----------------    

            //设置 cipher 格式 AES-128-CBC    

            rijalg.KeySize = 128;

            rijalg.Padding = PaddingMode.PKCS7;

            rijalg.Mode = CipherMode.CBC;

            rijalg.Key = Convert.FromBase64String(key);

            rijalg.IV = Convert.FromBase64String(iv);

            byte[] encryptedData = Convert.FromBase64String(encryptedDataStr);

            //解密    

            ICryptoTransform decryptor = rijalg.CreateDecryptor(rijalg.Key, rijalg.IV);

            string result;

            using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
            {

                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {

                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        result = srDecrypt.ReadToEnd();

                    }

                }

            }

            return result;

        }
    }
}
