using System;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using ns17;

namespace ns19
{
	// Token: 0x02000447 RID: 1095
	public sealed class Class1984 : IDisposable
	{
		// Token: 0x06001C02 RID: 7170 RVA: 0x000118CF File Offset: 0x0000FACF
		public void method_0(IWebProxy iwebProxy_1)
		{
			this.iwebProxy_0 = iwebProxy_1;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x000118D8 File Offset: 0x0000FAD8
		public Class1984(string string_8)
		{
			this.string_4 = string_8;
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000118FD File Offset: 0x0000FAFD
		public Class1984()
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0001191B File Offset: 0x0000FB1B
		public bool method_1()
		{
			return this.thread_0 != null && this.thread_0.IsAlive;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x000B3AD8 File Offset: 0x000B1CD8
		public Exception method_2()
		{
			return this.exception_0;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000B3AF0 File Offset: 0x000B1CF0
		public void method_3(bool bool_7)
		{
			if (bool_7)
			{
				if (this.delegate37_2 == null)
				{
					throw new ArgumentException("No download complete callback specified.");
				}
				this.thread_0 = Class920.smethod_0(new ThreadStart(this.method_9));
				this.thread_0.Name = "WebDownload.dlThread";
				this.thread_0.IsBackground = true;
				this.thread_0.CurrentUICulture = Thread.CurrentThread.CurrentUICulture;
				this.thread_0.Start();
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public void method_4()
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00011933 File Offset: 0x0000FB33
		public void method_5()
		{
			this.bool_5 = true;
			this.method_9();
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00011942 File Offset: 0x0000FB42
		public void method_6(string string_8)
		{
			this.string_5 = string_8;
			this.method_9();
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000B3B6C File Offset: 0x000B1D6C
		public void method_7()
		{
			this.delegate37_2 = null;
			this.delegate36_0 = null;
			if (this.thread_0 != null && this.thread_0 != Thread.CurrentThread)
			{
				if (this.thread_0.IsAlive)
				{
					Log.smethod_2(Log.Levels.int_3, "WebDownload.Cancel() : stopping download thread...");
					this.bool_6 = true;
					if (!this.thread_0.Join(500))
					{
						Log.smethod_2(Log.Levels.int_1, "WebDownload.Cancel() : download thread refuses to die");
					}
				}
				this.thread_0 = null;
			}
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00011951 File Offset: 0x0000FB51
		private void method_8(int int_2, int int_3)
		{
			if (this.delegate36_0 != null)
			{
				this.delegate36_0(int_2, int_3);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0001196B File Offset: 0x0000FB6B
		private static void smethod_0(Class1984 class1984_0)
		{
			if (Class1984.delegate37_0 != null)
			{
				Class1984.delegate37_0(class1984_0);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00011982 File Offset: 0x0000FB82
		private static void smethod_1(Class1984 class1984_0)
		{
			if (Class1984.delegate37_1 != null)
			{
				Class1984.delegate37_1(class1984_0);
			}
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000B3BF0 File Offset: 0x000B1DF0
		public static IWebProxy smethod_2(string string_8)
		{
			return Class1983.smethod_4(string_8, Class1984.bool_1, Class1984.bool_2, Class1984.string_0, Class1984.string_1, Class1984.string_2);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000B3C20 File Offset: 0x000B1E20
		protected void method_9()
		{
			Log.smethod_2(Log.Levels.int_2, "Starting download thread for {0}");
			if (this.string_4.StartsWith("http://"))
			{
				this.dateTime_0 = DateTime.Now;
				try
				{
					try
					{
						this.method_8(0, 1);
						Class1984.smethod_0(this);
						if (this.bool_6)
						{
							this.bool_3 = true;
							return;
						}
						if (this.bool_5 && this.stream_0 == null)
						{
							this.stream_0 = new MemoryStream();
						}
						else
						{
							string directoryName = Path.GetDirectoryName(this.string_5);
							FileMode mode = FileMode.Create;
							if (directoryName.Length > 0)
							{
								Directory.CreateDirectory(directoryName);
							}
							if (File.Exists(this.string_5))
							{
								mode = FileMode.Truncate;
							}
							this.stream_0 = new FileStream(this.string_5, mode);
						}
						this.httpWebRequest_0 = (HttpWebRequest)WebRequest.Create(this.string_4);
						this.httpWebRequest_0.UserAgent = Class1984.string_3;
						if (this.bool_4)
						{
							this.httpWebRequest_0.Headers.Add("Accept-Encoding", "gzip,deflate");
						}
						if (this.bool_6)
						{
							this.bool_3 = true;
							return;
						}
						if (this.iwebProxy_0 == null)
						{
							this.httpWebRequest_0.Proxy = Class1984.smethod_2(this.string_4);
						}
						else
						{
							this.httpWebRequest_0.Proxy = this.iwebProxy_0;
						}
						this.httpWebRequest_0.ReadWriteTimeout = 50000;
						using (this.httpWebResponse_0 = (this.httpWebRequest_0.GetResponse() as HttpWebResponse))
						{
							if (this.httpWebResponse_0.StatusCode == HttpStatusCode.OK)
							{
								this.string_6 = this.httpWebResponse_0.ContentType;
								this.string_7 = this.httpWebResponse_0.ContentEncoding;
								string text = this.httpWebResponse_0.Headers["Content-Length"];
								if (text != null)
								{
									this.int_1 = int.Parse(text, CultureInfo.InvariantCulture);
								}
								byte[] array = new byte[1500];
								using (Stream responseStream = this.httpWebResponse_0.GetResponseStream())
								{
									while (!this.bool_6)
									{
										int num = responseStream.Read(array, 0, array.Length);
										if (num <= 0)
										{
											goto IL_283;
										}
										this.stream_0.Write(array, 0, num);
										this.int_0 += num;
										this.method_8(this.int_0, this.int_1);
										Class1984.smethod_0(this);
									}
									this.bool_3 = true;
									return;
								}
							}
							IL_283:;
						}
						this.method_10();
					}
					catch (ThreadAbortException)
					{
						Log.smethod_2(Log.Levels.int_3, "Re-throwing ThreadAbortException.");
						throw;
					}
					catch (ConfigurationException)
					{
						throw;
					}
					catch (Exception exception_)
					{
						try
						{
							if (this.stream_0 != null)
							{
								this.stream_0.Close();
								this.stream_0 = null;
							}
							if (this.string_5 != null && this.string_5.Length > 0)
							{
								File.Delete(this.string_5);
							}
						}
						catch (Exception)
						{
						}
						this.method_12(exception_);
					}
					if (this.bool_6)
					{
						this.bool_3 = true;
						return;
					}
					if (this.int_1 == 0)
					{
						this.int_1 = this.int_0;
						this.method_8(this.int_0, this.int_1);
					}
					if (this.stream_0 is MemoryStream)
					{
						this.stream_0.Seek(0L, SeekOrigin.Begin);
					}
					else if (this.stream_0 != null)
					{
						this.stream_0.Close();
						this.stream_0 = null;
					}
					Class1984.smethod_0(this);
					if (this.delegate37_2 == null)
					{
						this.method_11();
					}
					else
					{
						this.delegate37_2(this);
					}
				}
				catch (ThreadAbortException)
				{
					Log.smethod_2(Log.Levels.int_3, "Download aborted.");
				}
				finally
				{
					if (this.stream_0 != null)
					{
						this.stream_0.Close();
					}
					this.bool_3 = true;
				}
				Class1984.smethod_1(this);
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000B40E4 File Offset: 0x000B22E4
		private void method_10()
		{
			if (this.stream_0.Length == 15L)
			{
				Exception exception_ = new FileNotFoundException("The remote server returned an error: (404) Not Found.", this.string_5);
				this.method_12(exception_);
			}
			if (this.enum151_0 == Enum151.const_1 && (this.string_6.StartsWith("text/xml") || this.string_6.StartsWith("application/vnd.ogc.se")))
			{
				this.method_13();
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00011999 File Offset: 0x0000FB99
		public void method_11()
		{
			if (this.method_2() != null)
			{
				throw this.method_2();
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000B4160 File Offset: 0x000B2360
		private void method_12(Exception exception_1)
		{
			this.exception_0 = exception_1;
			if (!(this.method_2() is ThreadAbortException) && Class1984.bool_0)
			{
				Log.Write(Log.Levels.Error, "HTTP", "URL: " + this.string_4);
				Log.Write(Log.Levels.Error, "HTTP", "     : " + exception_1.Message);
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000B41D0 File Offset: 0x000B23D0
		private void method_13()
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				this.stream_0.Seek(0L, SeekOrigin.Begin);
				xmlDocument.Load(this.stream_0);
				string text = "";
				foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("ServiceException"))
				{
					text = text + xmlNode.InnerText.Trim() + Environment.NewLine;
				}
				this.method_12(new WebException(text.Trim()));
			}
			catch (XmlException)
			{
				this.method_12(new WebException("An error occurred while trying to download " + this.httpWebRequest_0.RequestUri.ToString() + "."));
			}
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000B42C0 File Offset: 0x000B24C0
		public void Dispose()
		{
			if (this.thread_0 != null && this.thread_0 != Thread.CurrentThread)
			{
				if (this.thread_0.IsAlive)
				{
					Log.smethod_2(Log.Levels.int_3, "WebDownload.Dispose() : stopping download thread...");
					this.bool_6 = true;
					if (!this.thread_0.Join(500))
					{
						Log.smethod_2(Log.Levels.int_1, "WebDownload.Dispose() : download thread refuses to die, forcing Abort()");
						this.thread_0.Abort();
					}
				}
				this.thread_0 = null;
			}
			if (this.httpWebRequest_0 != null)
			{
				this.httpWebRequest_0.Abort();
				this.httpWebRequest_0 = null;
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0 = null;
			}
			if (this.dateTime_0 != DateTime.MinValue)
			{
				Class1984.smethod_0(this);
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000C24 RID: 3108
		public static bool bool_0 = false;

		// Token: 0x04000C25 RID: 3109
		public static bool bool_1 = true;

		// Token: 0x04000C26 RID: 3110
		public static string string_0 = "";

		// Token: 0x04000C27 RID: 3111
		public static bool bool_2 = false;

		// Token: 0x04000C28 RID: 3112
		public static string string_1 = "";

		// Token: 0x04000C29 RID: 3113
		public static string string_2 = "";

		// Token: 0x04000C2A RID: 3114
		public static string string_3 = string.Format(CultureInfo.InvariantCulture, "World Wind v{0} ({1}, {2})", new object[]
		{
			Application.ProductVersion,
			Environment.OSVersion.ToString(),
			CultureInfo.CurrentCulture.Name
		});

		// Token: 0x04000C2B RID: 3115
		public string string_4 = "";

		// Token: 0x04000C2C RID: 3116
		public Stream stream_0;

		// Token: 0x04000C2D RID: 3117
		public string string_5;

		// Token: 0x04000C2E RID: 3118
		public bool bool_3;

		// Token: 0x04000C2F RID: 3119
		public Delegate36 delegate36_0;

		// Token: 0x04000C30 RID: 3120
		public static Delegate37 delegate37_0;

		// Token: 0x04000C31 RID: 3121
		public static Delegate37 delegate37_1;

		// Token: 0x04000C32 RID: 3122
		public Delegate37 delegate37_2;

		// Token: 0x04000C33 RID: 3123
		public Enum151 enum151_0;

		// Token: 0x04000C34 RID: 3124
		public string string_6;

		// Token: 0x04000C35 RID: 3125
		public int int_0;

		// Token: 0x04000C36 RID: 3126
		public int int_1;

		// Token: 0x04000C37 RID: 3127
		public bool bool_4;

		// Token: 0x04000C38 RID: 3128
		public string string_7;

		// Token: 0x04000C39 RID: 3129
		public DateTime dateTime_0 = DateTime.MinValue;

		// Token: 0x04000C3A RID: 3130
		internal HttpWebRequest httpWebRequest_0;

		// Token: 0x04000C3B RID: 3131
		internal HttpWebResponse httpWebResponse_0;

		// Token: 0x04000C3C RID: 3132
		protected Exception exception_0;

		// Token: 0x04000C3D RID: 3133
		protected bool bool_5;

		// Token: 0x04000C3E RID: 3134
		private bool bool_6;

		// Token: 0x04000C3F RID: 3135
		protected Thread thread_0;

		// Token: 0x04000C40 RID: 3136
		private IWebProxy iwebProxy_0;
	}
}
