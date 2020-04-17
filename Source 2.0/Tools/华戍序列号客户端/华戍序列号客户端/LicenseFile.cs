using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
namespace jiami

{
	// Token: 0x0200096F RID: 2415
	public sealed class LicenseFile
	{
        //intro: shifting the passcode into password matrix using Guass method.
        static readonly string passwordMatrix = "-sakjfINLiljhiom;amlsd,mflojkld-asmdklf=askfjklajasdasdfasdf";
        public static string passcode = "AWIKSDFOPLKLPJIOKMKLJKLJNKLN,MNMBN+ASKDJFKAJD-AJHDJKFHKystuyqbebjoihuyytyWERNKWNERJKLFHAOEFNANDKL";
        //no use
        public static string pt;

        // Token: 0x06003B6F RID: 15215 RVA: 0x00125A40 File Offset: 0x00123C40
        public static void Parse()
		{
			if (!File.Exists("CommandXLicA.dat"))
			{
				Environment.Exit(0);
			}
			try
			{
                //ZSP 加密

                //StreamReader streamReaderPassSet = new StreamReader("D:\\SourceO 2.0\\PassSet\\PassSet.xml");
                //string cipherTextPassSet;
                //using (streamReaderPassSet)
                //{
                //    cipherTextPassSet = streamReaderPassSet.ReadToEnd();
                //}
                //string PassSetData = LicenseFile.EncryptComX(cipherTextPassSet);
                //StreamWriter streamWriter = File.CreateText("D:\\SourceO 2.0\\PassSet\\CommandXLicA.dat");
                //streamWriter.WriteLine(PassSetData);
                //streamWriter.Close();

                //解密
                StreamReader streamReader = new StreamReader("CommandXLicA.dat");
				string cipherText;
				using (streamReader)
				{
					cipherText = streamReader.ReadToEnd();
				}
                //string xml = LicenseFile.Decrypt(cipherText, DBCryptoService.string_1);        
                
                //ZSP 解密
                string xml = LicenseFile.DecryptComX(cipherText);

                XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(xml);

				XmlNode xmlNode = xmlDocument.SelectSingleNode("/License");
                
                IEnumerator enumerator = xmlNode.ChildNodes.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						XmlNode xmlNode2 = (XmlNode)enumerator.Current;
						string name = xmlNode2.Name;
						if (Operators.CompareString(name, "CustomerName", false) != 0)
						{
							if (Operators.CompareString(name, "MachineGUID", false) != 0)
							{
								if (Operators.CompareString(name, "LicenseStart", false) != 0)
								{
									if (Operators.CompareString(name, "LicenseEnd", false) != 0)
									{
										if (Operators.CompareString(name, "LicenseVersion", false) != 0)
										{
											if (Operators.CompareString(name, "Extensions", false) != 0)
											{
												continue;
											}
											XmlNode xmlNode3 = xmlDocument.SelectSingleNode("/License/Extensions");
											IEnumerator enumerator2 = xmlNode3.ChildNodes.GetEnumerator();
											try
											{
												while (enumerator2.MoveNext())
												{
													string innerText = ((XmlNode)enumerator2.Current).InnerText;

                                                    if (Operators.CompareString(innerText, "CreateSlimDB", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.CreateSlimDB);
                                                    }
                                                    else if (Operators.CompareString(innerText, "MonteCarlo", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.MonteCarlo);
                                                    }
                                                    else if (Operators.CompareString(innerText, "CommercialOverlay", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.CommercialOverlay);
                                                    }
                                                    else if( Operators.CompareString(innerText, "TestScripts", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.TestScripts);
                                                    }
                                                    else if (Operators.CompareString(innerText, "XMLImportExport", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.XMLImportExport);
                                                    }
                                                    else if (Operators.CompareString(innerText, "EventExport", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.EventExport);
                                                    }
                                                    else if( Operators.CompareString(innerText, "UnregisteredDB", false) == 0)
                                                    {
                                                        LicenseFile.ProFeatures.Add(LicenseFile.ProFeature.UnregisteredDB);
                                                    }
               													
												}
												continue;
											}
											finally
											{
												if (enumerator2 is IDisposable)
												{
													(enumerator2 as IDisposable).Dispose();
												}
											}
										}
										string innerText2 = xmlNode2.InnerText;
										if (Operators.CompareString(innerText2, "Evaluation", false) == 0)
										{
											LicenseFile.LicenseVersion = LicenseFile._LicenseVersion.Evaluation;
										}
										if (Operators.CompareString(innerText2, "Commercial", false) == 0)
										{
											LicenseFile.LicenseVersion = LicenseFile._LicenseVersion.Commercial;
										}
										if (Operators.CompareString(innerText2, "Professional", false) == 0)
										{
											LicenseFile.LicenseVersion = LicenseFile._LicenseVersion.Professional;
                                        }

                                    }
									else
									{
										LicenseFile.LicenseEnd = DateTime.Parse(xmlNode2.InnerText);
									}
								}
								else
								{
									LicenseFile.LicenseStart = DateTime.Parse(xmlNode2.InnerText);
								}
							}
							else
							{
								LicenseFile.LicenseMachineGUID = xmlNode2.InnerText;

                                xmlNode2.InnerText = LicenseFile.GetMachineGUID();

							}
						}
						else
						{
                            //ZSP License LicenseFile.CustomerName = xmlNode2.InnerText;
                            LicenseFile.CustomerName = "用户A";
                        }
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
                if (LicenseFile.LicenseMachineGUID != LicenseFile.ActualMachineGUID)
                {
                    LicenseFile.LicenseMachineGUID = LicenseFile.ActualMachineGUID;
                }
                else
                {
                    //wb
                    xml = xmlDocument.InnerXml;


                    string PassSetData = LicenseFile.EncryptComX(xml);

                    if (File.Exists("CommandXLicA.dat"))
                        File.Delete("CommandXlicA.dat");

                    StreamWriter streamWriter = File.CreateText(".\\CommandXLicA.dat");
                    streamWriter.WriteLine(PassSetData);
                    streamWriter.Close();
                }

            }
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("找不到您的许可证文件!请联系华戍防务，错误信息: " + ex2.Message + "\r\n\r\n程序将退出...", MsgBoxStyle.OkOnly, null);
				Environment.Exit(0);
				ProjectData.ClearProjectError();
			}
		}

        //THIS FUNCITON IS TO VERIFY THE PASSWORD
        public static bool VerifyPass(string input)
        {
            Random r = new Random();
            int i = r.Next(1, passwordMatrix.Length);
            int j = r.Next(1, passwordMatrix.Length);

            try
            {
                string si = input;
                foreach (var uu in passwordMatrix)
                    si += passwordMatrix[uu];
            }
            catch
            {
                for (int jj = 0; jj < 100; jj++)
                {
                    passcode = ((jj + i + j)/j).ToString();
                }
            }
            return passwordMatrix[i - 1] == passwordMatrix[j - 1];
        }

        public static bool p()
        {
            pt = LicenseFile.EncryptComX(LicenseFile.GetDiskVolumeSerialNumber()).ToLower().Substring(0, 8);
            return true;
        }

        //ZSP 加密 
        //加密
        public static string EncryptComX(string input)
        {
            // 盐值
            //string saltValue = “saltValue”;
            // 密码值
            string pwdValue = string_1;
            byte[] data = System.Text.UTF8Encoding.UTF8.GetBytes(input);
            byte[] salt = LicenseFile.saltBytes;
            // AesManaged – 高级加密标准(AES) 对称算法的管理类
            System.Security.Cryptography.AesManaged aes = new System.Security.Cryptography.AesManaged();
            // Rfc2898DeriveBytes – 通过使用基于 HMACSHA1 的伪随机数生成器，实现基于密码的密钥派生功能 (PBKDF2 – 一种基于密码的密钥派生函数)
            // 通过 密码 和 salt 派生密钥
            System.Security.Cryptography.Rfc2898DeriveBytes rfc = new System.Security.Cryptography.Rfc2898DeriveBytes(pwdValue, salt);
            /**/
            /*
         * AesManaged.BlockSize – 加密操作的块大小（单位：bit）
         * AesManaged.LegalBlockSizes – 对称算法支持的块大小（单位：bit）
         * AesManaged.KeySize – 对称算法的密钥大小（单位：bit）
         * AesManaged.LegalKeySizes – 对称算法支持的密钥大小（单位：bit）
         * AesManaged.Key – 对称算法的密钥
         * AesManaged.IV – 对称算法的密钥大小
         * Rfc2898DeriveBytes.GetBytes(int 需要生成的伪随机密钥字节数) – 生成密钥
         */
            //aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
            //aes.KeySize = aes.LegalKeySizes[0].MaxSize;
            aes.Key = rfc.GetBytes((int)Math.Round((double)aes.KeySize / 8));
            aes.IV = rfc.GetBytes((int)Math.Round((double)aes.BlockSize / 8));
            // 用当前的 Key 属性和初始化向量 IV 创建对称加密器对象 
            System.Security.Cryptography.ICryptoTransform encryptTransform = aes.CreateEncryptor();
            // 加密后的输出流
            System.IO.MemoryStream encryptStream = new System.IO.MemoryStream();
            // 将加密后的目标流（encryptStream）与加密转换（encryptTransform）相连接
            System.Security.Cryptography.CryptoStream encryptor = new System.Security.Cryptography.CryptoStream
                (encryptStream, encryptTransform, System.Security.Cryptography.CryptoStreamMode.Write);
            // 将一个字节序列写入当前 CryptoStream （完成加密的过程）
            encryptor.Write(data, 0, data.Length);
            encryptor.Close();
            // 将加密后所得到的流转换成字节数组，再用Base64编码将其转换为字符串
            string encryptedString = Convert.ToBase64String(encryptStream.ToArray());
            return encryptedString;
        }


        public static string DecryptComX(string input)
        {
            // 盐值（与加密时设置的值一致）
            //string saltValue = “saltValue”;
            // 密码值（与加密时设置的值一致）
            //string result = null;

            string pwdValue = string_1;
            byte[] encryptBytes = Convert.FromBase64String(input);
            byte[] salt = LicenseFile.saltBytes;
            System.Security.Cryptography.AesManaged aes = new System.Security.Cryptography.AesManaged();
            System.Security.Cryptography.Rfc2898DeriveBytes rfc = new System.Security.Cryptography.Rfc2898DeriveBytes(pwdValue, salt);
            //aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
            //aes.KeySize = aes.LegalKeySizes[0].MaxSize;
            aes.Key = rfc.GetBytes((int)Math.Round((double)aes.KeySize / 8));
            aes.IV = rfc.GetBytes((int)Math.Round((double)aes.BlockSize / 8));
            // 用当前的 Key 属性和初始化向量 IV 创建对称解密器对象
            System.Security.Cryptography.ICryptoTransform decryptTransform = aes.CreateDecryptor();
            // 解密后的输出流
            MemoryStream decryptStream = new MemoryStream();
            // 将解密后的目标流（decryptStream）与解密转换（decryptTransform）相连接
            System.Security.Cryptography.CryptoStream decryptor = new System.Security.Cryptography.CryptoStream(
                decryptStream, decryptTransform, System.Security.Cryptography.CryptoStreamMode.Write);
            // 将一个字节序列写入当前 CryptoStream （完成解密的过程）
            decryptor.Write(encryptBytes, 0, encryptBytes.Length);
            decryptor.Close();
            // 将解密后所得到的流转换为字符串
            byte[] decryptBytes = decryptStream.ToArray();
            string decryptedString = UTF8Encoding.UTF8.GetString(decryptBytes, 0, decryptBytes.Length);
            return decryptedString;
        }
        

        // Token: 0x06003B70 RID: 15216 RVA: 0x00125F7C File Offset: 0x0012417C
        public static string Decrypt(string cipherText, string sharedKey = "")
		{
			if (string.IsNullOrEmpty(cipherText))
			{
				throw new ArgumentNullException("cipherText");
			}
			if (string.IsNullOrEmpty(sharedKey) && string.IsNullOrEmpty(sharedKey))
			{
				sharedKey = LicenseFile.DefaultSharedKey;
			}
			RijndaelManaged rijndaelManaged = null;
			string result = null;
			try
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedKey, LicenseFile.saltBytes);
				byte[] byte_ = Convert.FromBase64String(cipherText);
				using (Stream1 stream = new Stream1(byte_))
				{
					rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read))
					{
						using (StreamReader streamReader = new StreamReader(cryptoStream))
						{
							result = streamReader.ReadToEnd();
						}
					}
				}
			}
			finally
			{
				if (rijndaelManaged != null)
				{
					rijndaelManaged.Clear();
				}
			}
			return result;
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x001260D4 File Offset: 0x001242D4
		public static string GetDiskVolumeSerialNumber()
		{
			new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"");
			managementObject.Get();
			return managementObject.GetPropertyValue("VolumeSerialNumber").ToString();
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00126114 File Offset: 0x00124314
		public static string GetCPU()
		{
			string result = null;
			ManagementClass managementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					result = managementObject.Properties["Processorid"].Value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00126194 File Offset: 0x00124394
		public static string GetMachineGUID()
		{
			string text = LicenseFile.GetCPU() + LicenseFile.GetDiskVolumeSerialNumber();
			string text2 = text.Substring(0, 24);
			StreamWriter streamWriter = File.CreateText(".\\CommandXGUID.dat");
			streamWriter.WriteLine(text2);
			streamWriter.Close();
			return text2;
		}

		// Token: 0x04001B17 RID: 6935
		public static List<LicenseFile.ProFeature> ProFeatures = new List<LicenseFile.ProFeature>();

		// Token: 0x04001B18 RID: 6936
		public static string CustomerName;

		// Token: 0x04001B19 RID: 6937
		public static string LicenseMachineGUID;

		// Token: 0x04001B1A RID: 6938
		public static string ActualMachineGUID = LicenseFile.GetMachineGUID();

		// Token: 0x04001B1B RID: 6939
		public static DateTime LicenseStart;

		// Token: 0x04001B1C RID: 6940
		public static DateTime LicenseEnd;

		// Token: 0x04001B1D RID: 6941
		public static LicenseFile._LicenseVersion LicenseVersion = LicenseFile._LicenseVersion.Evaluation;

		// Token: 0x04001B1E RID: 6942
		private static byte[] saltBytes = Encoding.ASCII.GetBytes("o6806642kbM7c5");

		// Token: 0x04001B1F RID: 6943
		private static string DefaultSharedKey = "6b887c5ac993e7ae98c4c08e19f56429fdeb440755a4701b-7e80-4e57-9b96-3e9bee544da1942448a6-3112-4975-a68c-68782c80c0af";

		// Token: 0x04001B20 RID: 6944
		public static string string_1 = "4EE0E860AE-410C-410D-8E7E-0AC92423D79F8F-8CD3-4BC7C54842BD8CC4DF32-BAAC-4C5F-8120-FD02B6131532";

		// 专业版特性，专业版才有的功能
		public enum ProFeature
		{
			// Token: 0x04001B22 RID: 6946
			TestScripts,
			// Token: 0x04001B23 RID: 6947
			UnregisteredDB,
			// Token: 0x04001B24 RID: 6948
			CommercialOverlay,
			// Token: 0x04001B25 RID: 6949
			XMLImportExport,
			// Token: 0x04001B26 RID: 6950
			CreateSlimDB,
			// Token: 0x04001B27 RID: 6951
			EventExport,
			// Token: 0x04001B28 RID: 6952
			MonteCarlo
		}

		// 许可版本
		public enum _LicenseVersion
		{
			// 试用版
			Evaluation,
			// 商业版
			Commercial,
			// 专业版
			Professional
		}
	}
}
