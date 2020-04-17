using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace SmartAssembly.Zip
{
	// Token: 0x02001285 RID: 4741
	public sealed class SimpleZip
	{
		// Token: 0x0600A6EE RID: 42734 RVA: 0x004DF3A8 File Offset: 0x004DD5A8
		private static bool PublicKeysMatch(Assembly executingAssembly, Assembly callingAssembly)
		{
			byte[] publicKey = executingAssembly.GetName().GetPublicKey();
			byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
			if (publicKey2 == null != (publicKey == null))
			{
				return false;
			}
			if (publicKey2 != null)
			{
				for (int i = 0; i < publicKey2.Length; i++)
				{
					if (publicKey2[i] != publicKey[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x004DF3FC File Offset: 0x004DD5FC
		public static byte[] Unzip(byte[] buffer)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (callingAssembly != executingAssembly && !SimpleZip.PublicKeysMatch(executingAssembly, callingAssembly))
			{
				return null;
			}
			SimpleZip.ZipStream zipStream = new SimpleZip.ZipStream(buffer);
			byte[] array = new byte[0];
			int num = zipStream.ReadInt();
			if (num == 67324752)
			{
				short num2 = (short)zipStream.ReadShort();
				int num3 = zipStream.ReadShort();
				int num4 = zipStream.ReadShort();
				if (num == 67324752 && num2 == 20 && num3 == 0)
				{
					if (num4 == 8)
					{
						zipStream.ReadInt();
						zipStream.ReadInt();
						zipStream.ReadInt();
						int num5 = zipStream.ReadInt();
						int num6 = zipStream.ReadShort();
						int num7 = zipStream.ReadShort();
						if (num6 > 0)
						{
							byte[] buffer2 = new byte[num6];
							zipStream.Read(buffer2, 0, num6);
						}
						if (num7 > 0)
						{
							byte[] buffer3 = new byte[num7];
							zipStream.Read(buffer3, 0, num7);
						}
						byte[] array2 = new byte[zipStream.Length - zipStream.Position];
						zipStream.Read(array2, 0, array2.Length);
						SimpleZip.Inflater inflater = new SimpleZip.Inflater(array2);
						array = new byte[num5];
						inflater.Inflate(array, 0, array.Length);
						goto IL_2A7;
					}
				}
				throw new FormatException("Wrong Header Signature");
			}
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num == 8223355)
			{
				if (num8 == 1)
				{
					int num9 = zipStream.ReadInt();
					array = new byte[num9];
					int num11;
					for (int i = 0; i < num9; i += num11)
					{
						int num10 = zipStream.ReadInt();
						num11 = zipStream.ReadInt();
						byte[] array3 = new byte[num10];
						zipStream.Read(array3, 0, array3.Length);
						SimpleZip.Inflater inflater2 = new SimpleZip.Inflater(array3);
						inflater2.Inflate(array, i, num11);
					}
				}
				if (num8 == 2)
				{
					byte[] key = new byte[]
					{
						226,
						62,
						9,
						201,
						236,
						211,
						2,
						208
					};
					byte[] iv = new byte[]
					{
						166,
						39,
						238,
						21,
						112,
						219,
						100,
						63
					};
					using (DESCryptoIndirector dESCryptoIndirector = new DESCryptoIndirector())
					{
						using (ICryptoTransform dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(key, iv, true))
						{
							byte[] buffer4 = dESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
							array = SimpleZip.Unzip(buffer4);
						}
					}
				}
				if (num8 != 3)
				{
					goto IL_2A7;
				}
				byte[] key2 = new byte[]
				{
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1
				};
				byte[] iv2 = new byte[]
				{
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2
				};
				using (AESCryptoIndirector aESCryptoIndirector = new AESCryptoIndirector())
				{
					using (ICryptoTransform aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(key2, iv2, true))
					{
						byte[] buffer5 = aESCryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
						array = SimpleZip.Unzip(buffer5);
					}
					goto IL_2A7;
				}
			}
			throw new FormatException("Unknown Header");
			IL_2A7:
			zipStream.Close();
			zipStream = null;
			return array;
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x0004F712 File Offset: 0x0004D912
		public static byte[] Zip(byte[] buffer)
		{
			return SimpleZip.Zip(buffer, 1, null, null);
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x0004F71D File Offset: 0x0004D91D
		public static byte[] ZipAndEncrypt(byte[] buffer, byte[] key, byte[] iv)
		{
			return SimpleZip.Zip(buffer, 2, key, iv);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x0004F728 File Offset: 0x0004D928
		public static byte[] ZipAndAES(byte[] buffer, byte[] key, byte[] iv)
		{
			return SimpleZip.Zip(buffer, 3, key, iv);
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x004DF6F0 File Offset: 0x004DD8F0
		private static byte[] Zip(byte[] buffer, int version, byte[] key, byte[] iv)
		{
			byte[] result;
			try
			{
				SimpleZip.ZipStream zipStream = new SimpleZip.ZipStream();
				if (version == 0)
				{
					SimpleZip.Deflater deflater = new SimpleZip.Deflater();
					DateTime now = DateTime.Now;
					long num = (long)((ulong)((now.Year - 1980 & 127) << 25 | now.Month << 21 | now.Day << 16 | now.Hour << 11 | now.Minute << 5 | (int)((uint)now.Second >> 1)));
					uint[] array = new uint[]
					{
						0u,
						1996959894u,
						3993919788u,
						2567524794u,
						124634137u,
						1886057615u,
						3915621685u,
						2657392035u,
						249268274u,
						2044508324u,
						3772115230u,
						2547177864u,
						162941995u,
						2125561021u,
						3887607047u,
						2428444049u,
						498536548u,
						1789927666u,
						4089016648u,
						2227061214u,
						450548861u,
						1843258603u,
						4107580753u,
						2211677639u,
						325883990u,
						1684777152u,
						4251122042u,
						2321926636u,
						335633487u,
						1661365465u,
						4195302755u,
						2366115317u,
						997073096u,
						1281953886u,
						3579855332u,
						2724688242u,
						1006888145u,
						1258607687u,
						3524101629u,
						2768942443u,
						901097722u,
						1119000684u,
						3686517206u,
						2898065728u,
						853044451u,
						1172266101u,
						3705015759u,
						2882616665u,
						651767980u,
						1373503546u,
						3369554304u,
						3218104598u,
						565507253u,
						1454621731u,
						3485111705u,
						3099436303u,
						671266974u,
						1594198024u,
						3322730930u,
						2970347812u,
						795835527u,
						1483230225u,
						3244367275u,
						3060149565u,
						1994146192u,
						31158534u,
						2563907772u,
						4023717930u,
						1907459465u,
						112637215u,
						2680153253u,
						3904427059u,
						2013776290u,
						251722036u,
						2517215374u,
						3775830040u,
						2137656763u,
						141376813u,
						2439277719u,
						3865271297u,
						1802195444u,
						476864866u,
						2238001368u,
						4066508878u,
						1812370925u,
						453092731u,
						2181625025u,
						4111451223u,
						1706088902u,
						314042704u,
						2344532202u,
						4240017532u,
						1658658271u,
						366619977u,
						2362670323u,
						4224994405u,
						1303535960u,
						984961486u,
						2747007092u,
						3569037538u,
						1256170817u,
						1037604311u,
						2765210733u,
						3554079995u,
						1131014506u,
						879679996u,
						2909243462u,
						3663771856u,
						1141124467u,
						855842277u,
						2852801631u,
						3708648649u,
						1342533948u,
						654459306u,
						3188396048u,
						3373015174u,
						1466479909u,
						544179635u,
						3110523913u,
						3462522015u,
						1591671054u,
						702138776u,
						2966460450u,
						3352799412u,
						1504918807u,
						783551873u,
						3082640443u,
						3233442989u,
						3988292384u,
						2596254646u,
						62317068u,
						1957810842u,
						3939845945u,
						2647816111u,
						81470997u,
						1943803523u,
						3814918930u,
						2489596804u,
						225274430u,
						2053790376u,
						3826175755u,
						2466906013u,
						167816743u,
						2097651377u,
						4027552580u,
						2265490386u,
						503444072u,
						1762050814u,
						4150417245u,
						2154129355u,
						426522225u,
						1852507879u,
						4275313526u,
						2312317920u,
						282753626u,
						1742555852u,
						4189708143u,
						2394877945u,
						397917763u,
						1622183637u,
						3604390888u,
						2714866558u,
						953729732u,
						1340076626u,
						3518719985u,
						2797360999u,
						1068828381u,
						1219638859u,
						3624741850u,
						2936675148u,
						906185462u,
						1090812512u,
						3747672003u,
						2825379669u,
						829329135u,
						1181335161u,
						3412177804u,
						3160834842u,
						628085408u,
						1382605366u,
						3423369109u,
						3138078467u,
						570562233u,
						1426400815u,
						3317316542u,
						2998733608u,
						733239954u,
						1555261956u,
						3268935591u,
						3050360625u,
						752459403u,
						1541320221u,
						2607071920u,
						3965973030u,
						1969922972u,
						40735498u,
						2617837225u,
						3943577151u,
						1913087877u,
						83908371u,
						2512341634u,
						3803740692u,
						2075208622u,
						213261112u,
						2463272603u,
						3855990285u,
						2094854071u,
						198958881u,
						2262029012u,
						4057260610u,
						1759359992u,
						534414190u,
						2176718541u,
						4139329115u,
						1873836001u,
						414664567u,
						2282248934u,
						4279200368u,
						1711684554u,
						285281116u,
						2405801727u,
						4167216745u,
						1634467795u,
						376229701u,
						2685067896u,
						3608007406u,
						1308918612u,
						956543938u,
						2808555105u,
						3495958263u,
						1231636301u,
						1047427035u,
						2932959818u,
						3654703836u,
						1088359270u,
						936918000u,
						2847714899u,
						3736837829u,
						1202900863u,
						817233897u,
						3183342108u,
						3401237130u,
						1404277552u,
						615818150u,
						3134207493u,
						3453421203u,
						1423857449u,
						601450431u,
						3009837614u,
						3294710456u,
						1567103746u,
						711928724u,
						3020668471u,
						3272380065u,
						1510334235u,
						755167117u
					};
					uint num2 = 4294967295u;
					uint num3 = 4294967295u;
					int num4 = 0;
					int num5 = buffer.Length;
					while (--num5 >= 0)
					{
						num3 = (array[(int)((UIntPtr)((num3 ^ (uint)buffer[num4++]) & 255u))] ^ num3 >> 8);
					}
					num3 ^= num2;
					zipStream.WriteInt(67324752);
					zipStream.WriteShort(20);
					zipStream.WriteShort(0);
					zipStream.WriteShort(8);
					zipStream.WriteInt((int)num);
					zipStream.WriteInt((int)num3);
					long position = zipStream.Position;
					zipStream.WriteInt(0);
					zipStream.WriteInt(buffer.Length);
					byte[] bytes = Encoding.UTF8.GetBytes("{data}");
					zipStream.WriteShort(bytes.Length);
					zipStream.WriteShort(0);
					zipStream.Write(bytes, 0, bytes.Length);
					deflater.SetInput(buffer);
					while (!deflater.IsNeedingInput)
					{
						byte[] array2 = new byte[512];
						int num6 = deflater.Deflate(array2);
						if (num6 <= 0)
						{
							break;
						}
						zipStream.Write(array2, 0, num6);
					}
					deflater.Finish();
					while (!deflater.IsFinished)
					{
						byte[] array3 = new byte[512];
						int num7 = deflater.Deflate(array3);
						if (num7 <= 0)
						{
							break;
						}
						zipStream.Write(array3, 0, num7);
					}
					long totalOut = deflater.TotalOut;
					zipStream.WriteInt(33639248);
					zipStream.WriteShort(20);
					zipStream.WriteShort(20);
					zipStream.WriteShort(0);
					zipStream.WriteShort(8);
					zipStream.WriteInt((int)num);
					zipStream.WriteInt((int)num3);
					zipStream.WriteInt((int)totalOut);
					zipStream.WriteInt(buffer.Length);
					zipStream.WriteShort(bytes.Length);
					zipStream.WriteShort(0);
					zipStream.WriteShort(0);
					zipStream.WriteShort(0);
					zipStream.WriteShort(0);
					zipStream.WriteInt(0);
					zipStream.WriteInt(0);
					zipStream.Write(bytes, 0, bytes.Length);
					zipStream.WriteInt(101010256);
					zipStream.WriteShort(0);
					zipStream.WriteShort(0);
					zipStream.WriteShort(1);
					zipStream.WriteShort(1);
					zipStream.WriteInt(46 + bytes.Length);
					zipStream.WriteInt((int)((long)(30 + bytes.Length) + totalOut));
					zipStream.WriteShort(0);
					zipStream.Seek(position, SeekOrigin.Begin);
					zipStream.WriteInt((int)totalOut);
				}
				else if (version == 1)
				{
					zipStream.WriteInt(25000571);
					zipStream.WriteInt(buffer.Length);
					byte[] array4;
					for (int i = 0; i < buffer.Length; i += array4.Length)
					{
						array4 = new byte[Math.Min(2097151, buffer.Length - i)];
						Buffer.BlockCopy(buffer, i, array4, 0, array4.Length);
						long position2 = zipStream.Position;
						zipStream.WriteInt(0);
						zipStream.WriteInt(array4.Length);
						SimpleZip.Deflater deflater2 = new SimpleZip.Deflater();
						deflater2.SetInput(array4);
						while (!deflater2.IsNeedingInput)
						{
							byte[] array5 = new byte[512];
							int num8 = deflater2.Deflate(array5);
							if (num8 <= 0)
							{
								break;
							}
							zipStream.Write(array5, 0, num8);
						}
						deflater2.Finish();
						while (!deflater2.IsFinished)
						{
							byte[] array6 = new byte[512];
							int num9 = deflater2.Deflate(array6);
							if (num9 <= 0)
							{
								break;
							}
							zipStream.Write(array6, 0, num9);
						}
						long position3 = zipStream.Position;
						zipStream.Position = position2;
						zipStream.WriteInt((int)deflater2.TotalOut);
						zipStream.Position = position3;
					}
				}
				else
				{
					if (version == 2)
					{
						zipStream.WriteInt(41777787);
						byte[] array7 = SimpleZip.Zip(buffer, 1, null, null);
						using (DESCryptoIndirector dESCryptoIndirector = new DESCryptoIndirector())
						{
							using (ICryptoTransform dESCryptoTransform = dESCryptoIndirector.GetDESCryptoTransform(key, iv, false))
							{
								byte[] array8 = dESCryptoTransform.TransformFinalBlock(array7, 0, array7.Length);
								zipStream.Write(array8, 0, array8.Length);
							}
							goto IL_47C;
						}
					}
					if (version == 3)
					{
						zipStream.WriteInt(58555003);
						byte[] array9 = SimpleZip.Zip(buffer, 1, null, null);
						using (AESCryptoIndirector aESCryptoIndirector = new AESCryptoIndirector())
						{
							using (ICryptoTransform aESCryptoTransform = aESCryptoIndirector.GetAESCryptoTransform(key, iv, false))
							{
								byte[] array10 = aESCryptoTransform.TransformFinalBlock(array9, 0, array9.Length);
								zipStream.Write(array10, 0, array10.Length);
							}
						}
					}
				}
				IL_47C:
				zipStream.Flush();
				zipStream.Close();
				result = zipStream.ToArray();
			}
			catch (Exception ex)
			{
				SimpleZip.ExceptionMessage = "ERR 2003: " + ex.Message;
				throw;
			}
			return result;
		}

		// Token: 0x0400565D RID: 22109
		public static string ExceptionMessage;

		// Token: 0x02001286 RID: 4742
		internal sealed class Inflater
		{
			// Token: 0x0600A6F5 RID: 42741 RVA: 0x0004F733 File Offset: 0x0004D933
			public Inflater(byte[] bytes)
			{
				this.input = new SimpleZip.StreamManipulator();
				this.outputWindow = new SimpleZip.OutputWindow();
				this.mode = 2;
				this.input.SetInput(bytes, 0, bytes.Length);
			}

			// Token: 0x0600A6F6 RID: 42742 RVA: 0x004DFC28 File Offset: 0x004DDE28
			private bool DecodeHuffman()
			{
				int i = this.outputWindow.GetFreeSpace();
				while (i >= 258)
				{
					int symbol;
					switch (this.mode)
					{
					case 7:
						while (((symbol = this.litlenTree.GetSymbol(this.input)) & -256) == 0)
						{
							this.outputWindow.Write(symbol);
							if (--i < 258)
							{
								return true;
							}
						}
						if (symbol >= 257)
						{
							this.repLength = SimpleZip.Inflater.CPLENS[symbol - 257];
							this.neededBits = SimpleZip.Inflater.CPLEXT[symbol - 257];
							goto IL_9E;
						}
						if (symbol < 0)
						{
							return false;
						}
						this.distTree = null;
						this.litlenTree = null;
						this.mode = 2;
						return true;
					case 8:
						goto IL_9E;
					case 9:
						goto IL_EE;
					case 10:
						break;
					default:
						continue;
					}
					IL_121:
					if (this.neededBits > 0)
					{
						this.mode = 10;
						int num = this.input.PeekBits(this.neededBits);
						if (num < 0)
						{
							return false;
						}
						this.input.DropBits(this.neededBits);
						this.repDist += num;
					}
					this.outputWindow.Repeat(this.repLength, this.repDist);
					i -= this.repLength;
					this.mode = 7;
					continue;
					IL_EE:
					symbol = this.distTree.GetSymbol(this.input);
					if (symbol >= 0)
					{
						this.repDist = SimpleZip.Inflater.CPDIST[symbol];
						this.neededBits = SimpleZip.Inflater.CPDEXT[symbol];
						goto IL_121;
					}
					return false;
					IL_9E:
					if (this.neededBits > 0)
					{
						this.mode = 8;
						int num2 = this.input.PeekBits(this.neededBits);
						if (num2 < 0)
						{
							return false;
						}
						this.input.DropBits(this.neededBits);
						this.repLength += num2;
					}
					this.mode = 9;
					goto IL_EE;
				}
				return true;
			}

			// Token: 0x0600A6F7 RID: 42743 RVA: 0x004DFDF4 File Offset: 0x004DDFF4
			private bool Decode()
			{
				switch (this.mode)
				{
				case 2:
				{
					if (this.isLastBlock)
					{
						this.mode = 12;
						return false;
					}
					int num = this.input.PeekBits(3);
					if (num < 0)
					{
						return false;
					}
					this.input.DropBits(3);
					if ((num & 1) != 0)
					{
						this.isLastBlock = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.input.SkipToByteBoundary();
						this.mode = 3;
						break;
					case 1:
						this.litlenTree = SimpleZip.InflaterHuffmanTree.defLitLenTree;
						this.distTree = SimpleZip.InflaterHuffmanTree.defDistTree;
						this.mode = 7;
						break;
					case 2:
						this.dynHeader = new SimpleZip.InflaterDynHeader();
						this.mode = 6;
						break;
					}
					return true;
				}
				case 3:
					if ((this.uncomprLen = this.input.PeekBits(16)) < 0)
					{
						return false;
					}
					this.input.DropBits(16);
					this.mode = 4;
					break;
				case 4:
					break;
				case 5:
					goto IL_133;
				case 6:
					if (!this.dynHeader.Decode(this.input))
					{
						return false;
					}
					this.litlenTree = this.dynHeader.BuildLitLenTree();
					this.distTree = this.dynHeader.BuildDistTree();
					this.mode = 7;
					goto IL_1B7;
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_1B7;
				case 11:
					return false;
				case 12:
					return false;
				default:
					return false;
				}
				int num2 = this.input.PeekBits(16);
				if (num2 < 0)
				{
					return false;
				}
				this.input.DropBits(16);
				this.mode = 5;
				IL_133:
				int num3 = this.outputWindow.CopyStored(this.input, this.uncomprLen);
				this.uncomprLen -= num3;
				if (this.uncomprLen == 0)
				{
					this.mode = 2;
					return true;
				}
				return !this.input.IsNeedingInput;
				IL_1B7:
				return this.DecodeHuffman();
			}

			// Token: 0x0600A6F8 RID: 42744 RVA: 0x004DFFC4 File Offset: 0x004DE1C4
			public int Inflate(byte[] buf, int offset, int len)
			{
				int num = 0;
				while (true)
				{
					if (this.mode != 11)
					{
						int num2 = this.outputWindow.CopyOutput(buf, offset, len);
						offset += num2;
						num += num2;
						len -= num2;
						if (len == 0)
						{
							return num;
						}
					}
					if (!this.Decode())
					{
						if (this.outputWindow.GetAvailable() <= 0)
						{
							break;
						}
						if (this.mode == 11)
						{
							break;
						}
					}
				}
				return num;
			}

			// Token: 0x0400565E RID: 22110
			private const int DECODE_HEADER = 0;

			// Token: 0x0400565F RID: 22111
			private const int DECODE_DICT = 1;

			// Token: 0x04005660 RID: 22112
			private const int DECODE_BLOCKS = 2;

			// Token: 0x04005661 RID: 22113
			private const int DECODE_STORED_LEN1 = 3;

			// Token: 0x04005662 RID: 22114
			private const int DECODE_STORED_LEN2 = 4;

			// Token: 0x04005663 RID: 22115
			private const int DECODE_STORED = 5;

			// Token: 0x04005664 RID: 22116
			private const int DECODE_DYN_HEADER = 6;

			// Token: 0x04005665 RID: 22117
			private const int DECODE_HUFFMAN = 7;

			// Token: 0x04005666 RID: 22118
			private const int DECODE_HUFFMAN_LENBITS = 8;

			// Token: 0x04005667 RID: 22119
			private const int DECODE_HUFFMAN_DIST = 9;

			// Token: 0x04005668 RID: 22120
			private const int DECODE_HUFFMAN_DISTBITS = 10;

			// Token: 0x04005669 RID: 22121
			private const int DECODE_CHKSUM = 11;

			// Token: 0x0400566A RID: 22122
			private const int FINISHED = 12;

			// Token: 0x0400566B RID: 22123
			private static readonly int[] CPLENS = new int[]
			{
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				13,
				15,
				17,
				19,
				23,
				27,
				31,
				35,
				43,
				51,
				59,
				67,
				83,
				99,
				115,
				131,
				163,
				195,
				227,
				258
			};

			// Token: 0x0400566C RID: 22124
			private static readonly int[] CPLEXT = new int[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				1,
				1,
				1,
				2,
				2,
				2,
				2,
				3,
				3,
				3,
				3,
				4,
				4,
				4,
				4,
				5,
				5,
				5,
				5,
				0
			};

			// Token: 0x0400566D RID: 22125
			private static readonly int[] CPDIST = new int[]
			{
				1,
				2,
				3,
				4,
				5,
				7,
				9,
				13,
				17,
				25,
				33,
				49,
				65,
				97,
				129,
				193,
				257,
				385,
				513,
				769,
				1025,
				1537,
				2049,
				3073,
				4097,
				6145,
				8193,
				12289,
				16385,
				24577
			};

			// Token: 0x0400566E RID: 22126
			private static readonly int[] CPDEXT = new int[]
			{
				0,
				0,
				0,
				0,
				1,
				1,
				2,
				2,
				3,
				3,
				4,
				4,
				5,
				5,
				6,
				6,
				7,
				7,
				8,
				8,
				9,
				9,
				10,
				10,
				11,
				11,
				12,
				12,
				13,
				13
			};

			// Token: 0x0400566F RID: 22127
			private int mode;

			// Token: 0x04005670 RID: 22128
			private int neededBits;

			// Token: 0x04005671 RID: 22129
			private int repLength;

			// Token: 0x04005672 RID: 22130
			private int repDist;

			// Token: 0x04005673 RID: 22131
			private int uncomprLen;

			// Token: 0x04005674 RID: 22132
			private bool isLastBlock;

			// Token: 0x04005675 RID: 22133
			private SimpleZip.StreamManipulator input;

			// Token: 0x04005676 RID: 22134
			private SimpleZip.OutputWindow outputWindow;

			// Token: 0x04005677 RID: 22135
			private SimpleZip.InflaterDynHeader dynHeader;

			// Token: 0x04005678 RID: 22136
			private SimpleZip.InflaterHuffmanTree litlenTree;

			// Token: 0x04005679 RID: 22137
			private SimpleZip.InflaterHuffmanTree distTree;
		}

		// Token: 0x02001287 RID: 4743
		internal sealed class StreamManipulator
		{
			// Token: 0x0600A6FA RID: 42746 RVA: 0x004E0094 File Offset: 0x004DE294
			public int PeekBits(int n)
			{
				if (this.bits_in_buffer < n)
				{
					if (this.window_start == this.window_end)
					{
						return -1;
					}
					this.buffer |= (uint)((uint)((int)(this.window[this.window_start++] & 255) | (int)(this.window[this.window_start++] & 255) << 8) << this.bits_in_buffer);
					this.bits_in_buffer += 16;
				}
				return (int)((ulong)this.buffer & (ulong)((long)((1 << n) - 1)));
			}

			// Token: 0x0600A6FB RID: 42747 RVA: 0x0004F768 File Offset: 0x0004D968
			public void DropBits(int n)
			{
				this.buffer >>= n;
				this.bits_in_buffer -= n;
			}

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x0600A6FC RID: 42748 RVA: 0x0004F789 File Offset: 0x0004D989
			public int AvailableBits
			{
				get
				{
					return this.bits_in_buffer;
				}
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x0600A6FD RID: 42749 RVA: 0x0004F791 File Offset: 0x0004D991
			public int AvailableBytes
			{
				get
				{
					return this.window_end - this.window_start + (this.bits_in_buffer >> 3);
				}
			}

			// Token: 0x0600A6FE RID: 42750 RVA: 0x0004F7A9 File Offset: 0x0004D9A9
			public void SkipToByteBoundary()
			{
				this.buffer >>= (this.bits_in_buffer & 7);
				this.bits_in_buffer &= -8;
			}

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x0600A6FF RID: 42751 RVA: 0x0004F7D2 File Offset: 0x0004D9D2
			public bool IsNeedingInput
			{
				get
				{
					return this.window_start == this.window_end;
				}
			}

			// Token: 0x0600A700 RID: 42752 RVA: 0x004E0134 File Offset: 0x004DE334
			public int CopyBytes(byte[] output, int offset, int length)
			{
				int num = 0;
				while (this.bits_in_buffer > 0 && length > 0)
				{
					output[offset++] = (byte)this.buffer;
					this.buffer >>= 8;
					this.bits_in_buffer -= 8;
					length--;
					num++;
				}
				if (length == 0)
				{
					return num;
				}
				int num2 = this.window_end - this.window_start;
				if (length > num2)
				{
					length = num2;
				}
				Array.Copy(this.window, this.window_start, output, offset, length);
				this.window_start += length;
				if ((this.window_start - this.window_end & 1) != 0)
				{
					this.buffer = (uint)(this.window[this.window_start++] & 255);
					this.bits_in_buffer = 8;
				}
				return num + length;
			}

			// Token: 0x0600A702 RID: 42754 RVA: 0x0004F806 File Offset: 0x0004DA06
			public void Reset()
			{
				this.bits_in_buffer = 0;
				this.window_end = 0;
				this.window_start = 0;
				this.buffer = 0u;
			}

			// Token: 0x0600A703 RID: 42755 RVA: 0x004E0204 File Offset: 0x004DE404
			public void SetInput(byte[] buf, int off, int len)
			{
				if (this.window_start < this.window_end)
				{
					throw new InvalidOperationException();
				}
				int num = off + len;
				if (0 <= off && off <= num && num <= buf.Length)
				{
					if ((len & 1) != 0)
					{
						this.buffer |= (uint)((uint)(buf[off++] & 255) << this.bits_in_buffer);
						this.bits_in_buffer += 8;
					}
					this.window = buf;
					this.window_start = off;
					this.window_end = num;
					return;
				}
				throw new ArgumentOutOfRangeException();
			}

			// Token: 0x0400567A RID: 22138
			private byte[] window;

			// Token: 0x0400567B RID: 22139
			private int window_start = 0;

			// Token: 0x0400567C RID: 22140
			private int window_end = 0;

			// Token: 0x0400567D RID: 22141
			private uint buffer = 0u;

			// Token: 0x0400567E RID: 22142
			private int bits_in_buffer = 0;
		}

		// Token: 0x02001288 RID: 4744
		internal sealed class OutputWindow
		{
			// Token: 0x0600A704 RID: 42756 RVA: 0x004E028C File Offset: 0x004DE48C
			public void Write(int abyte)
			{
				if (this.windowFilled++ == 32768)
				{
					throw new InvalidOperationException();
				}
				this.window[this.windowEnd++] = (byte)abyte;
				this.windowEnd &= 32767;
			}

			// Token: 0x0600A705 RID: 42757 RVA: 0x004E02E4 File Offset: 0x004DE4E4
			private void SlowRepeat(int repStart, int len, int dist)
			{
				while (len-- > 0)
				{
					this.window[this.windowEnd++] = this.window[repStart++];
					this.windowEnd &= 32767;
					repStart &= 32767;
				}
			}

			// Token: 0x0600A706 RID: 42758 RVA: 0x004E0340 File Offset: 0x004DE540
			public void Repeat(int len, int dist)
			{
				if ((this.windowFilled += len) > 32768)
				{
					throw new InvalidOperationException();
				}
				int num = this.windowEnd - dist & 32767;
				int num2 = 32768 - len;
				if (num > num2 || this.windowEnd >= num2)
				{
					this.SlowRepeat(num, len, dist);
					return;
				}
				if (len <= dist)
				{
					Array.Copy(this.window, num, this.window, this.windowEnd, len);
					this.windowEnd += len;
					return;
				}
				while (len-- > 0)
				{
					this.window[this.windowEnd++] = this.window[num++];
				}
			}

			// Token: 0x0600A707 RID: 42759 RVA: 0x004E03F4 File Offset: 0x004DE5F4
			public int CopyStored(SimpleZip.StreamManipulator input, int len)
			{
				len = Math.Min(Math.Min(len, 32768 - this.windowFilled), input.AvailableBytes);
				int num = 32768 - this.windowEnd;
				int num2;
				if (len > num)
				{
					num2 = input.CopyBytes(this.window, this.windowEnd, num);
					if (num2 == num)
					{
						num2 += input.CopyBytes(this.window, 0, len - num);
					}
				}
				else
				{
					num2 = input.CopyBytes(this.window, this.windowEnd, len);
				}
				this.windowEnd = (this.windowEnd + num2 & 32767);
				this.windowFilled += num2;
				return num2;
			}

			// Token: 0x0600A708 RID: 42760 RVA: 0x004E0498 File Offset: 0x004DE698
			public void CopyDict(byte[] dict, int offset, int len)
			{
				if (this.windowFilled > 0)
				{
					throw new InvalidOperationException();
				}
				if (len > 32768)
				{
					offset += len - 32768;
					len = 32768;
				}
				Array.Copy(dict, offset, this.window, 0, len);
				this.windowEnd = (len & 32767);
			}

			// Token: 0x0600A709 RID: 42761 RVA: 0x0004F824 File Offset: 0x0004DA24
			public int GetFreeSpace()
			{
				return 32768 - this.windowFilled;
			}

			// Token: 0x0600A70A RID: 42762 RVA: 0x0004F832 File Offset: 0x0004DA32
			public int GetAvailable()
			{
				return this.windowFilled;
			}

			// Token: 0x0600A70B RID: 42763 RVA: 0x004E04EC File Offset: 0x004DE6EC
			public int CopyOutput(byte[] output, int offset, int len)
			{
				int num = this.windowEnd;
				if (len > this.windowFilled)
				{
					len = this.windowFilled;
				}
				else
				{
					num = (this.windowEnd - this.windowFilled + len & 32767);
				}
				int num2 = len;
				int num3 = len - num;
				if (num3 > 0)
				{
					Array.Copy(this.window, 32768 - num3, output, offset, num3);
					offset += num3;
					len = num;
				}
				Array.Copy(this.window, num - len, output, offset, len);
				this.windowFilled -= num2;
				if (this.windowFilled < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}

			// Token: 0x0600A70C RID: 42764 RVA: 0x0004F83A File Offset: 0x0004DA3A
			public void Reset()
			{
				this.windowEnd = 0;
				this.windowFilled = 0;
			}

			// Token: 0x0400567F RID: 22143
			private const int WINDOW_SIZE = 32768;

			// Token: 0x04005680 RID: 22144
			private const int WINDOW_MASK = 32767;

			// Token: 0x04005681 RID: 22145
			private byte[] window = new byte[32768];

			// Token: 0x04005682 RID: 22146
			private int windowEnd = 0;

			// Token: 0x04005683 RID: 22147
			private int windowFilled = 0;
		}

		// Token: 0x02001289 RID: 4745
		internal sealed class InflaterHuffmanTree
		{
			// Token: 0x0600A70E RID: 42766 RVA: 0x004E0580 File Offset: 0x004DE780
			static InflaterHuffmanTree()
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				SimpleZip.InflaterHuffmanTree.defLitLenTree = new SimpleZip.InflaterHuffmanTree(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				SimpleZip.InflaterHuffmanTree.defDistTree = new SimpleZip.InflaterHuffmanTree(array);
			}

			// Token: 0x0600A70F RID: 42767 RVA: 0x0004F870 File Offset: 0x0004DA70
			public InflaterHuffmanTree(byte[] codeLengths)
			{
				this.BuildTree(codeLengths);
			}

			// Token: 0x0600A710 RID: 42768 RVA: 0x004E0614 File Offset: 0x004DE814
			private void BuildTree(byte[] codeLengths)
			{
				int[] array = new int[16];
				int[] array2 = new int[16];
				for (int i = 0; i < codeLengths.Length; i++)
				{
					int num = (int)codeLengths[i];
					if (num > 0)
					{
						int[] array3;
						IntPtr intPtr;
						(array3 = array)[(int)(intPtr = (IntPtr)num)] = array3[(int)intPtr] + 1;
					}
				}
				int num2 = 0;
				int num3 = 512;
				for (int j = 1; j <= 15; j++)
				{
					array2[j] = num2;
					num2 += array[j] << 16 - j;
					if (j >= 10)
					{
						int num4 = array2[j] & 130944;
						int num5 = num2 & 130944;
						num3 += num5 - num4 >> 16 - j;
					}
				}
				this.tree = new short[num3];
				int num6 = 512;
				for (int k = 15; k >= 10; k--)
				{
					int num7 = num2 & 130944;
					num2 -= array[k] << 16 - k;
					int num8 = num2 & 130944;
					for (int l = num8; l < num7; l += 128)
					{
						this.tree[(int)SimpleZip.DeflaterHuffman.BitReverse(l)] = (short)(-num6 << 4 | k);
						num6 += 1 << k - 9;
					}
				}
				for (int m = 0; m < codeLengths.Length; m++)
				{
					int num9 = (int)codeLengths[m];
					if (num9 != 0)
					{
						num2 = array2[num9];
						int num10 = (int)SimpleZip.DeflaterHuffman.BitReverse(num2);
						if (num9 <= 9)
						{
							do
							{
								this.tree[num10] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < 512);
						}
						else
						{
							int num11 = (int)this.tree[num10 & 511];
							int num12 = 1 << (num11 & 15);
							num11 = -(num11 >> 4);
							do
							{
								this.tree[num11 | num10 >> 9] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < num12);
						}
						array2[num9] = num2 + (1 << 16 - num9);
					}
				}
			}

			// Token: 0x0600A711 RID: 42769 RVA: 0x004E0804 File Offset: 0x004DEA04
			public int GetSymbol(SimpleZip.StreamManipulator input)
			{
				int num;
				if ((num = input.PeekBits(9)) >= 0)
				{
					int num2;
					if ((num2 = (int)this.tree[num]) >= 0)
					{
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					int num3 = -(num2 >> 4);
					int n = num2 & 15;
					if ((num = input.PeekBits(n)) >= 0)
					{
						num2 = (int)this.tree[num3 | num >> 9];
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					int availableBits = input.AvailableBits;
					num = input.PeekBits(availableBits);
					num2 = (int)this.tree[num3 | num >> 9];
					if ((num2 & 15) <= availableBits)
					{
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
				else
				{
					int availableBits2 = input.AvailableBits;
					num = input.PeekBits(availableBits2);
					int num2 = (int)this.tree[num];
					if (num2 >= 0 && (num2 & 15) <= availableBits2)
					{
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
			}

			// Token: 0x04005684 RID: 22148
			private const int MAX_BITLEN = 15;

			// Token: 0x04005685 RID: 22149
			private short[] tree;

			// Token: 0x04005686 RID: 22150
			public static readonly SimpleZip.InflaterHuffmanTree defLitLenTree;

			// Token: 0x04005687 RID: 22151
			public static readonly SimpleZip.InflaterHuffmanTree defDistTree;
		}

		// Token: 0x0200128A RID: 4746
		internal sealed class InflaterDynHeader
		{
			// Token: 0x0600A713 RID: 42771 RVA: 0x004E08DC File Offset: 0x004DEADC
			public bool Decode(SimpleZip.StreamManipulator input)
			{
				while (true)
				{
					switch (this.mode)
					{
					case 0:
						this.lnum = input.PeekBits(5);
						if (this.lnum >= 0)
						{
							this.lnum += 257;
							input.DropBits(5);
							this.mode = 1;
							goto IL_1DD;
						}
						return false;
					case 1:
						goto IL_1DD;
					case 2:
						goto IL_18F;
					case 3:
						goto IL_156;
					case 4:
						break;
					case 5:
						goto IL_2C;
					default:
						continue;
					}
					IL_E1:
					int symbol;
					while (((symbol = this.blTree.GetSymbol(input)) & -16) == 0)
					{
						this.litdistLens[this.ptr++] = (this.lastLen = (byte)symbol);
						if (this.ptr == this.num)
						{
							return true;
						}
					}
					if (symbol >= 0)
					{
						if (symbol >= 17)
						{
							this.lastLen = 0;
						}
						this.repSymbol = symbol - 16;
						this.mode = 5;
						goto IL_2C;
					}
					return false;
					IL_156:
					while (this.ptr < this.blnum)
					{
						int num = input.PeekBits(3);
						if (num < 0)
						{
							return false;
						}
						input.DropBits(3);
						this.blLens[SimpleZip.InflaterDynHeader.BL_ORDER[this.ptr]] = (byte)num;
						this.ptr++;
					}
					this.blTree = new SimpleZip.InflaterHuffmanTree(this.blLens);
					this.blLens = null;
					this.ptr = 0;
					this.mode = 4;
					goto IL_E1;
					IL_2C:
					int n = SimpleZip.InflaterDynHeader.repBits[this.repSymbol];
					int num2 = input.PeekBits(n);
					if (num2 < 0)
					{
						return false;
					}
					input.DropBits(n);
					num2 += SimpleZip.InflaterDynHeader.repMin[this.repSymbol];
					while (num2-- > 0)
					{
						this.litdistLens[this.ptr++] = this.lastLen;
					}
					if (this.ptr == this.num)
					{
						break;
					}
					this.mode = 4;
					continue;
					IL_18F:
					this.blnum = input.PeekBits(4);
					if (this.blnum >= 0)
					{
						this.blnum += 4;
						input.DropBits(4);
						this.blLens = new byte[19];
						this.ptr = 0;
						this.mode = 3;
						goto IL_156;
					}
					return false;
					IL_1DD:
					this.dnum = input.PeekBits(5);
					if (this.dnum >= 0)
					{
						this.dnum++;
						input.DropBits(5);
						this.num = this.lnum + this.dnum;
						this.litdistLens = new byte[this.num];
						this.mode = 2;
						goto IL_18F;
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600A714 RID: 42772 RVA: 0x004E0B74 File Offset: 0x004DED74
			public SimpleZip.InflaterHuffmanTree BuildLitLenTree()
			{
				byte[] array = new byte[this.lnum];
				Array.Copy(this.litdistLens, 0, array, 0, this.lnum);
				return new SimpleZip.InflaterHuffmanTree(array);
			}

			// Token: 0x0600A715 RID: 42773 RVA: 0x004E0BA8 File Offset: 0x004DEDA8
			public SimpleZip.InflaterHuffmanTree BuildDistTree()
			{
				byte[] array = new byte[this.dnum];
				Array.Copy(this.litdistLens, this.lnum, array, 0, this.dnum);
				return new SimpleZip.InflaterHuffmanTree(array);
			}

			// Token: 0x04005688 RID: 22152
			private const int LNUM = 0;

			// Token: 0x04005689 RID: 22153
			private const int DNUM = 1;

			// Token: 0x0400568A RID: 22154
			private const int BLNUM = 2;

			// Token: 0x0400568B RID: 22155
			private const int BLLENS = 3;

			// Token: 0x0400568C RID: 22156
			private const int LENS = 4;

			// Token: 0x0400568D RID: 22157
			private const int REPS = 5;

			// Token: 0x0400568E RID: 22158
			private static readonly int[] repMin = new int[]
			{
				3,
				3,
				11
			};

			// Token: 0x0400568F RID: 22159
			private static readonly int[] repBits = new int[]
			{
				2,
				3,
				7
			};

			// Token: 0x04005690 RID: 22160
			private byte[] blLens;

			// Token: 0x04005691 RID: 22161
			private byte[] litdistLens;

			// Token: 0x04005692 RID: 22162
			private SimpleZip.InflaterHuffmanTree blTree;

			// Token: 0x04005693 RID: 22163
			private int mode;

			// Token: 0x04005694 RID: 22164
			private int lnum;

			// Token: 0x04005695 RID: 22165
			private int dnum;

			// Token: 0x04005696 RID: 22166
			private int blnum;

			// Token: 0x04005697 RID: 22167
			private int num;

			// Token: 0x04005698 RID: 22168
			private int repSymbol;

			// Token: 0x04005699 RID: 22169
			private byte lastLen;

			// Token: 0x0400569A RID: 22170
			private int ptr;

			// Token: 0x0400569B RID: 22171
			private static readonly int[] BL_ORDER = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};
		}

		// Token: 0x0200128B RID: 4747
		internal sealed class Deflater
		{
			// Token: 0x0600A717 RID: 42775 RVA: 0x0004F87F File Offset: 0x0004DA7F
			public Deflater()
			{
				this.pending = new SimpleZip.DeflaterPending();
				this.engine = new SimpleZip.DeflaterEngine(this.pending);
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x0600A718 RID: 42776 RVA: 0x0004F8BA File Offset: 0x0004DABA
			public long TotalOut
			{
				get
				{
					return this.totalOut;
				}
			}

			// Token: 0x0600A719 RID: 42777 RVA: 0x0004F8C2 File Offset: 0x0004DAC2
			public void Finish()
			{
				this.state |= 12;
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x0600A71A RID: 42778 RVA: 0x0004F8D3 File Offset: 0x0004DAD3
			public bool IsFinished
			{
				get
				{
					return this.state == 30 && this.pending.IsFlushed;
				}
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x0600A71B RID: 42779 RVA: 0x0004F8EC File Offset: 0x0004DAEC
			public bool IsNeedingInput
			{
				get
				{
					return this.engine.NeedsInput();
				}
			}

			// Token: 0x0600A71C RID: 42780 RVA: 0x0004F8F9 File Offset: 0x0004DAF9
			public void SetInput(byte[] buffer)
			{
				this.engine.SetInput(buffer);
			}

			// Token: 0x0600A71D RID: 42781 RVA: 0x004E0C30 File Offset: 0x004DEE30
			public int Deflate(byte[] output)
			{
				int num = 0;
				int num2 = output.Length;
				int num3 = num2;
				while (true)
				{
					int num4 = this.pending.Flush(output, num, num2);
					num += num4;
					this.totalOut += (long)num4;
					num2 -= num4;
					if (num2 == 0 || this.state == 30)
					{
						goto IL_E3;
					}
					if (!this.engine.Deflate((this.state & 4) != 0, (this.state & 8) != 0))
					{
						if (this.state == 16)
						{
							break;
						}
						if (this.state == 20)
						{
							for (int i = 8 + (-this.pending.BitCount & 7); i > 0; i -= 10)
							{
								this.pending.WriteBits(2, 10);
							}
							this.state = 16;
						}
						else if (this.state == 28)
						{
							this.pending.AlignToByte();
							this.state = 30;
						}
					}
				}
				return num3 - num2;
				IL_E3:
				return num3 - num2;
			}

			// Token: 0x0400569C RID: 22172
			private const int IS_FLUSHING = 4;

			// Token: 0x0400569D RID: 22173
			private const int IS_FINISHING = 8;

			// Token: 0x0400569E RID: 22174
			private const int BUSY_STATE = 16;

			// Token: 0x0400569F RID: 22175
			private const int FLUSHING_STATE = 20;

			// Token: 0x040056A0 RID: 22176
			private const int FINISHING_STATE = 28;

			// Token: 0x040056A1 RID: 22177
			private const int FINISHED_STATE = 30;

			// Token: 0x040056A2 RID: 22178
			private int state = 16;

			// Token: 0x040056A3 RID: 22179
			private long totalOut = 0L;

			// Token: 0x040056A4 RID: 22180
			private SimpleZip.DeflaterPending pending;

			// Token: 0x040056A5 RID: 22181
			private SimpleZip.DeflaterEngine engine;
		}

		// Token: 0x0200128C RID: 4748
		internal sealed class DeflaterHuffman
		{
			// Token: 0x0600A71E RID: 42782 RVA: 0x0004F907 File Offset: 0x0004DB07
			public static short BitReverse(int toReverse)
			{
				return (short)((int)SimpleZip.DeflaterHuffman.bit4Reverse[toReverse & 15] << 12 | (int)SimpleZip.DeflaterHuffman.bit4Reverse[toReverse >> 4 & 15] << 8 | (int)SimpleZip.DeflaterHuffman.bit4Reverse[toReverse >> 8 & 15] << 4 | (int)SimpleZip.DeflaterHuffman.bit4Reverse[toReverse >> 12]);
			}

			// Token: 0x0600A71F RID: 42783 RVA: 0x004E0D24 File Offset: 0x004DEF24
			static DeflaterHuffman()
			{
				int i = 0;
				while (i < 144)
				{
					SimpleZip.DeflaterHuffman.staticLCodes[i] = SimpleZip.DeflaterHuffman.BitReverse(48 + i << 8);
					SimpleZip.DeflaterHuffman.staticLLength[i++] = 8;
				}
				while (i < 256)
				{
					SimpleZip.DeflaterHuffman.staticLCodes[i] = SimpleZip.DeflaterHuffman.BitReverse(256 + i << 7);
					SimpleZip.DeflaterHuffman.staticLLength[i++] = 9;
				}
				while (i < 280)
				{
					SimpleZip.DeflaterHuffman.staticLCodes[i] = SimpleZip.DeflaterHuffman.BitReverse(-256 + i << 9);
					SimpleZip.DeflaterHuffman.staticLLength[i++] = 7;
				}
				while (i < 286)
				{
					SimpleZip.DeflaterHuffman.staticLCodes[i] = SimpleZip.DeflaterHuffman.BitReverse(-88 + i << 8);
					SimpleZip.DeflaterHuffman.staticLLength[i++] = 8;
				}
				SimpleZip.DeflaterHuffman.staticDCodes = new short[30];
				SimpleZip.DeflaterHuffman.staticDLength = new byte[30];
				for (i = 0; i < 30; i++)
				{
					SimpleZip.DeflaterHuffman.staticDCodes[i] = SimpleZip.DeflaterHuffman.BitReverse(i << 11);
					SimpleZip.DeflaterHuffman.staticDLength[i] = 5;
				}
			}

			// Token: 0x0600A720 RID: 42784 RVA: 0x004E0E64 File Offset: 0x004DF064
			public DeflaterHuffman(SimpleZip.DeflaterPending pending)
			{
				this.pending = pending;
				this.literalTree = new SimpleZip.DeflaterHuffman.Tree(this, 286, 257, 15);
				this.distTree = new SimpleZip.DeflaterHuffman.Tree(this, 30, 1, 15);
				this.blTree = new SimpleZip.DeflaterHuffman.Tree(this, 19, 4, 7);
				this.d_buf = new short[16384];
				this.l_buf = new byte[16384];
			}

			// Token: 0x0600A721 RID: 42785 RVA: 0x0004F940 File Offset: 0x0004DB40
			public void Init()
			{
				this.last_lit = 0;
				this.extra_bits = 0;
			}

			// Token: 0x0600A722 RID: 42786 RVA: 0x004E0ED8 File Offset: 0x004DF0D8
			private int Lcode(int len)
			{
				if (len == 255)
				{
					return 285;
				}
				int num = 257;
				while (len >= 8)
				{
					num += 4;
					len >>= 1;
				}
				return num + len;
			}

			// Token: 0x0600A723 RID: 42787 RVA: 0x004E0F0C File Offset: 0x004DF10C
			private int Dcode(int distance)
			{
				int num = 0;
				while (distance >= 4)
				{
					num += 2;
					distance >>= 1;
				}
				return num + distance;
			}

			// Token: 0x0600A724 RID: 42788 RVA: 0x004E0F30 File Offset: 0x004DF130
			public void SendAllTrees(int blTreeCodes)
			{
				this.blTree.BuildCodes();
				this.literalTree.BuildCodes();
				this.distTree.BuildCodes();
				this.pending.WriteBits(this.literalTree.numCodes - 257, 5);
				this.pending.WriteBits(this.distTree.numCodes - 1, 5);
				this.pending.WriteBits(blTreeCodes - 4, 4);
				for (int i = 0; i < blTreeCodes; i++)
				{
					this.pending.WriteBits((int)this.blTree.length[SimpleZip.DeflaterHuffman.BL_ORDER[i]], 3);
				}
				this.literalTree.WriteTree(this.blTree);
				this.distTree.WriteTree(this.blTree);
			}

			// Token: 0x0600A725 RID: 42789 RVA: 0x004E0FF0 File Offset: 0x004DF1F0
			public void CompressBlock()
			{
				for (int i = 0; i < this.last_lit; i++)
				{
					int num = (int)(this.l_buf[i] & 255);
					int num2 = (int)this.d_buf[i];
					if (num2-- != 0)
					{
						int num3 = this.Lcode(num);
						this.literalTree.WriteSymbol(num3);
						int num4 = (num3 - 261) / 4;
						if (num4 > 0 && num4 <= 5)
						{
							this.pending.WriteBits(num & (1 << num4) - 1, num4);
						}
						int num5 = this.Dcode(num2);
						this.distTree.WriteSymbol(num5);
						num4 = num5 / 2 - 1;
						if (num4 > 0)
						{
							this.pending.WriteBits(num2 & (1 << num4) - 1, num4);
						}
					}
					else
					{
						this.literalTree.WriteSymbol(num);
					}
				}
				this.literalTree.WriteSymbol(256);
			}

			// Token: 0x0600A726 RID: 42790 RVA: 0x004E10D0 File Offset: 0x004DF2D0
			public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
			{
				this.pending.WriteBits(lastBlock ? 1 : 0, 3);
				this.pending.AlignToByte();
				this.pending.WriteShort(storedLength);
				this.pending.WriteShort(~storedLength);
				this.pending.WriteBlock(stored, storedOffset, storedLength);
				this.Init();
			}

			// Token: 0x0600A727 RID: 42791 RVA: 0x004E112C File Offset: 0x004DF32C
			public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
			{
				short[] freqs;
				(freqs = this.literalTree.freqs)[256] =(short)( freqs[256] + 1);
				this.literalTree.BuildTree();
				this.distTree.BuildTree();
				this.literalTree.CalcBLFreq(this.blTree);
				this.distTree.CalcBLFreq(this.blTree);
				this.blTree.BuildTree();
				int num = 4;
				for (int i = 18; i > num; i--)
				{
					if (this.blTree.length[SimpleZip.DeflaterHuffman.BL_ORDER[i]] > 0)
					{
						num = i + 1;
					}
				}
				int num2 = 14 + num * 3 + this.blTree.GetEncodedLength() + this.literalTree.GetEncodedLength() + this.distTree.GetEncodedLength() + this.extra_bits;
				int num3 = this.extra_bits;
				for (int j = 0; j < 286; j++)
				{
					num3 += (int)(this.literalTree.freqs[j] * (short)SimpleZip.DeflaterHuffman.staticLLength[j]);
				}
				for (int k = 0; k < 30; k++)
				{
					num3 += (int)(this.distTree.freqs[k] * (short)SimpleZip.DeflaterHuffman.staticDLength[k]);
				}
				if (num2 >= num3)
				{
					num2 = num3;
				}
				if (storedOffset >= 0 && storedLength + 4 < num2 >> 3)
				{
					this.FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
					return;
				}
				if (num2 == num3)
				{
					this.pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
					this.literalTree.SetStaticCodes(SimpleZip.DeflaterHuffman.staticLCodes, SimpleZip.DeflaterHuffman.staticLLength);
					this.distTree.SetStaticCodes(SimpleZip.DeflaterHuffman.staticDCodes, SimpleZip.DeflaterHuffman.staticDLength);
					this.CompressBlock();
					this.Init();
					return;
				}
				this.pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
				this.SendAllTrees(num);
				this.CompressBlock();
				this.Init();
			}

			// Token: 0x0600A728 RID: 42792 RVA: 0x0004F950 File Offset: 0x0004DB50
			public bool IsFull()
			{
				return this.last_lit >= 16384;
			}

			// Token: 0x0600A729 RID: 42793 RVA: 0x004E12F0 File Offset: 0x004DF4F0
			public bool TallyLit(int lit)
			{
				this.d_buf[this.last_lit] = 0;
				this.l_buf[this.last_lit++] = (byte)lit;
				short[] freqs;
				(freqs = this.literalTree.freqs)[lit] = (short)(freqs[lit] + 1);
				return this.IsFull();
			}

			// Token: 0x0600A72A RID: 42794 RVA: 0x004E1344 File Offset: 0x004DF544
			public bool TallyDist(int dist, int len)
			{
				this.d_buf[this.last_lit] = (short)dist;
				this.l_buf[this.last_lit++] = (byte)(len - 3);
				int num = this.Lcode(len - 3);
				short[] freqs;
				IntPtr intPtr;
				(freqs = this.literalTree.freqs)[(int)(intPtr = (IntPtr)num)] = (short)(freqs[(int)intPtr] + 1);
				if (num >= 265 && num < 285)
				{
					this.extra_bits += (num - 261) / 4;
				}
				int num2 = this.Dcode(dist - 1);
				(freqs = this.distTree.freqs)[(int)(intPtr = (IntPtr)num2)] = (short)(freqs[(int)intPtr] + 1);
				if (num2 >= 4)
				{
					this.extra_bits += num2 / 2 - 1;
				}
				return this.IsFull();
			}

			// Token: 0x040056A6 RID: 22182
			private const int BUFSIZE = 16384;

			// Token: 0x040056A7 RID: 22183
			private const int LITERAL_NUM = 286;

			// Token: 0x040056A8 RID: 22184
			private const int DIST_NUM = 30;

			// Token: 0x040056A9 RID: 22185
			private const int BITLEN_NUM = 19;

			// Token: 0x040056AA RID: 22186
			private const int REP_3_6 = 16;

			// Token: 0x040056AB RID: 22187
			private const int REP_3_10 = 17;

			// Token: 0x040056AC RID: 22188
			private const int REP_11_138 = 18;

			// Token: 0x040056AD RID: 22189
			private const int EOF_SYMBOL = 256;

			// Token: 0x040056AE RID: 22190
			private static readonly int[] BL_ORDER = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};

			// Token: 0x040056AF RID: 22191
			private static readonly byte[] bit4Reverse = new byte[]
			{
				0,
				8,
				4,
				12,
				2,
				10,
				6,
				14,
				1,
				9,
				5,
				13,
				3,
				11,
				7,
				15
			};

			// Token: 0x040056B0 RID: 22192
			private SimpleZip.DeflaterPending pending;

			// Token: 0x040056B1 RID: 22193
			private SimpleZip.DeflaterHuffman.Tree literalTree;

			// Token: 0x040056B2 RID: 22194
			private SimpleZip.DeflaterHuffman.Tree distTree;

			// Token: 0x040056B3 RID: 22195
			private SimpleZip.DeflaterHuffman.Tree blTree;

			// Token: 0x040056B4 RID: 22196
			private short[] d_buf;

			// Token: 0x040056B5 RID: 22197
			private byte[] l_buf;

			// Token: 0x040056B6 RID: 22198
			private int last_lit;

			// Token: 0x040056B7 RID: 22199
			private int extra_bits;

			// Token: 0x040056B8 RID: 22200
			private static readonly short[] staticLCodes = new short[286];

			// Token: 0x040056B9 RID: 22201
			private static readonly byte[] staticLLength = new byte[286];

			// Token: 0x040056BA RID: 22202
			private static readonly short[] staticDCodes;

			// Token: 0x040056BB RID: 22203
			private static readonly byte[] staticDLength;

			// Token: 0x0200128D RID: 4749
			public sealed class Tree
			{
				// Token: 0x0600A72B RID: 42795 RVA: 0x0004F962 File Offset: 0x0004DB62
				public Tree(SimpleZip.DeflaterHuffman dh, int elems, int minCodes, int maxLength)
				{
					this.dh = dh;
					this.minNumCodes = minCodes;
					this.maxLength = maxLength;
					this.freqs = new short[elems];
					this.bl_counts = new int[maxLength];
				}

				// Token: 0x0600A72C RID: 42796 RVA: 0x0004F999 File Offset: 0x0004DB99
				public void WriteSymbol(int code)
				{
					this.dh.pending.WriteBits((int)this.codes[code] & 65535, (int)this.length[code]);
				}

				// Token: 0x0600A72D RID: 42797 RVA: 0x0004F9C1 File Offset: 0x0004DBC1
				public void SetStaticCodes(short[] stCodes, byte[] stLength)
				{
					this.codes = stCodes;
					this.length = stLength;
				}

				// Token: 0x0600A72E RID: 42798 RVA: 0x004E1404 File Offset: 0x004DF604
				public void BuildCodes()
				{
					int[] array = new int[this.maxLength];
					int num = 0;
					this.codes = new short[this.freqs.Length];
					for (int i = 0; i < this.maxLength; i++)
					{
						array[i] = num;
						num += this.bl_counts[i] << 15 - i;
					}
					for (int j = 0; j < this.numCodes; j++)
					{
						int num2 = (int)this.length[j];
						if (num2 > 0)
						{
							this.codes[j] = SimpleZip.DeflaterHuffman.BitReverse(array[num2 - 1]);
							int[] array2;
							IntPtr intPtr;
							(array2 = array)[(int)(intPtr = (IntPtr)(num2 - 1))] = array2[(int)intPtr] + (1 << 16 - num2);
						}
					}
				}

				// Token: 0x0600A72F RID: 42799 RVA: 0x004E14AC File Offset: 0x004DF6AC
				private void BuildLength(int[] childs)
				{
					this.length = new byte[this.freqs.Length];
					int num = childs.Length / 2;
					int num2 = (num + 1) / 2;
					int num3 = 0;
					for (int i = 0; i < this.maxLength; i++)
					{
						this.bl_counts[i] = 0;
					}
					int[] array = new int[num];
					array[num - 1] = 0;
					int[] array2;
					IntPtr intPtr;
					for (int j = num - 1; j >= 0; j--)
					{
						if (childs[2 * j + 1] != -1)
						{
							int num4 = array[j] + 1;
							if (num4 > this.maxLength)
							{
								num4 = this.maxLength;
								num3++;
							}
							array[childs[2 * j]] = (array[childs[2 * j + 1]] = num4);
						}
						else
						{
							int num5 = array[j];
							(array2 = this.bl_counts)[(int)(intPtr = (IntPtr)(num5 - 1))] = array2[(int)intPtr] + 1;
							this.length[childs[2 * j]] = (byte)array[j];
						}
					}
					if (num3 == 0)
					{
						return;
					}
					int num6 = this.maxLength - 1;
					while (true)
					{
						if (this.bl_counts[--num6] != 0)
						{
							do
							{
								(array2 = this.bl_counts)[(int)(intPtr = (IntPtr)num6)] = array2[(int)intPtr] - 1;
								(array2 = this.bl_counts)[(int)(intPtr = (IntPtr)(++num6))] = array2[(int)intPtr] + 1;
								num3 -= 1 << this.maxLength - 1 - num6;
							}
							while (num3 > 0 && num6 < this.maxLength - 1);
							if (num3 <= 0)
							{
								break;
							}
						}
					}
					(array2 = this.bl_counts)[(int)(intPtr = (IntPtr)(this.maxLength - 1))] = array2[(int)intPtr] + num3;
					(array2 = this.bl_counts)[(int)(intPtr = (IntPtr)(this.maxLength - 2))] = array2[(int)intPtr] - num3;
					int num7 = 2 * num2;
					for (int num8 = this.maxLength; num8 != 0; num8--)
					{
						int k = this.bl_counts[num8 - 1];
						while (k > 0)
						{
							int num9 = 2 * childs[num7++];
							if (childs[num9 + 1] == -1)
							{
								this.length[childs[num9]] = (byte)num8;
								k--;
							}
						}
					}
				}

				// Token: 0x0600A730 RID: 42800 RVA: 0x004E169C File Offset: 0x004DF89C
				public void BuildTree()
				{
					int num = this.freqs.Length;
					int[] array = new int[num];
					int i = 0;
					int num2 = 0;
					for (int j = 0; j < num; j++)
					{
						int num3 = (int)this.freqs[j];
						if (num3 != 0)
						{
							int num4 = i++;
							int num5;
							while (num4 > 0 && (int)this.freqs[array[num5 = (num4 - 1) / 2]] > num3)
							{
								array[num4] = array[num5];
								num4 = num5;
							}
							array[num4] = j;
							num2 = j;
						}
					}
					while (i < 2)
					{
						int num6 = (num2 < 2) ? (++num2) : 0;
						array[i++] = num6;
					}
					this.numCodes = Math.Max(num2 + 1, this.minNumCodes);
					int num7 = i;
					int[] array2 = new int[4 * i - 2];
					int[] array3 = new int[2 * i - 1];
					int num8 = num7;
					for (int k = 0; k < i; k++)
					{
						int num9 = array[k];
						array2[2 * k] = num9;
						array2[2 * k + 1] = -1;
						array3[k] = (int)this.freqs[num9] << 8;
						array[k] = k;
					}
					do
					{
						int num10 = array[0];
						int num11 = array[--i];
						int num12 = 0;
						int l;
						for (l = 1; l < i; l = l * 2 + 1)
						{
							if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
							{
								l++;
							}
							array[num12] = array[l];
							num12 = l;
						}
						int num13 = array3[num11];
						while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
						{
							array[l] = array[num12];
						}
						array[l] = num11;
						int num14 = array[0];
						num11 = num8++;
						array2[2 * num11] = num10;
						array2[2 * num11 + 1] = num14;
						int num15 = Math.Min(array3[num10] & 255, array3[num14] & 255);
						num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
						num12 = 0;
						for (l = 1; l < i; l = num12 * 2 + 1)
						{
							if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
							{
								l++;
							}
							array[num12] = array[l];
							num12 = l;
						}
						while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
						{
							array[l] = array[num12];
						}
						array[l] = num11;
					}
					while (i > 1);
					this.BuildLength(array2);
				}

				// Token: 0x0600A731 RID: 42801 RVA: 0x004E18F8 File Offset: 0x004DFAF8
				public int GetEncodedLength()
				{
					int num = 0;
					for (int i = 0; i < this.freqs.Length; i++)
					{
						num += (int)(this.freqs[i] * (short)this.length[i]);
					}
					return num;
				}

				// Token: 0x0600A732 RID: 42802 RVA: 0x004E1930 File Offset: 0x004DFB30
				public void CalcBLFreq(SimpleZip.DeflaterHuffman.Tree blTree)
				{
					int num = -1;
					int i = 0;
					while (i < this.numCodes)
					{
						int num2 = 1;
						int num3 = (int)this.length[i];
						int num4;
						int num5;
						if (num3 == 0)
						{
							num4 = 138;
							num5 = 3;
						}
						else
						{
							num4 = 6;
							num5 = 3;
							if (num != num3)
							{
								short[] array;
								IntPtr intPtr;
								(array = blTree.freqs)[(int)(intPtr = (IntPtr)num3)] = (short)(array[(int)intPtr] + 1);
								num2 = 0;
							}
						}
						num = num3;
						i++;
						while (i < this.numCodes)
						{
							if (num != (int)this.length[i])
							{
								break;
							}
							i++;
							if (++num2 >= num4)
							{
								break;
							}
						}
						if (num2 < num5)
						{
							short[] array;
							IntPtr intPtr;
							(array = blTree.freqs)[(int)(intPtr = (IntPtr)num)] = (short)(array[(int)intPtr] + (short)num2);
						}
						else if (num != 0)
						{
							short[] array;
							(array = blTree.freqs)[16] = (short)(array[16] + 1);
						}
						else if (num2 <= 10)
						{
							short[] array;
							(array = blTree.freqs)[17] = (short)(array[17] + 1);
						}
						else
						{
							short[] array;
							(array = blTree.freqs)[18] = (short)(array[18] + 1);
						}
					}
				}

				// Token: 0x0600A733 RID: 42803 RVA: 0x004E1A28 File Offset: 0x004DFC28
				public void WriteTree(SimpleZip.DeflaterHuffman.Tree blTree)
				{
					int num = -1;
					int i = 0;
					while (i < this.numCodes)
					{
						int num2 = 1;
						int num3 = (int)this.length[i];
						int num4;
						int num5;
						if (num3 == 0)
						{
							num4 = 138;
							num5 = 3;
						}
						else
						{
							num4 = 6;
							num5 = 3;
							if (num != num3)
							{
								blTree.WriteSymbol(num3);
								num2 = 0;
							}
						}
						num = num3;
						i++;
						while (i < this.numCodes)
						{
							if (num != (int)this.length[i])
							{
								break;
							}
							i++;
							if (++num2 >= num4)
							{
								break;
							}
						}
						if (num2 < num5)
						{
							while (num2-- > 0)
							{
								blTree.WriteSymbol(num);
							}
						}
						else if (num != 0)
						{
							blTree.WriteSymbol(16);
							this.dh.pending.WriteBits(num2 - 3, 2);
						}
						else if (num2 <= 10)
						{
							blTree.WriteSymbol(17);
							this.dh.pending.WriteBits(num2 - 3, 3);
						}
						else
						{
							blTree.WriteSymbol(18);
							this.dh.pending.WriteBits(num2 - 11, 7);
						}
					}
				}

				// Token: 0x040056BC RID: 22204
				public short[] freqs;

				// Token: 0x040056BD RID: 22205
				public byte[] length;

				// Token: 0x040056BE RID: 22206
				public int minNumCodes;

				// Token: 0x040056BF RID: 22207
				public int numCodes;

				// Token: 0x040056C0 RID: 22208
				private short[] codes;

				// Token: 0x040056C1 RID: 22209
				private int[] bl_counts;

				// Token: 0x040056C2 RID: 22210
				private int maxLength;

				// Token: 0x040056C3 RID: 22211
				private SimpleZip.DeflaterHuffman dh;
			}
		}

		// Token: 0x0200128E RID: 4750
		internal sealed class DeflaterEngine
		{
			// Token: 0x0600A734 RID: 42804 RVA: 0x004E1B24 File Offset: 0x004DFD24
			public DeflaterEngine(SimpleZip.DeflaterPending pending)
			{
				this.pending = pending;
				this.huffman = new SimpleZip.DeflaterHuffman(pending);
				this.window = new byte[65536];
				this.head = new short[32768];
				this.prev = new short[32768];
				this.strstart = 1;
				this.blockStart = 1;
			}

			// Token: 0x0600A735 RID: 42805 RVA: 0x0004F9D1 File Offset: 0x0004DBD1
			private void UpdateHash()
			{
				this.ins_h = ((int)this.window[this.strstart] << 5 ^ (int)this.window[this.strstart + 1]);
			}

			// Token: 0x0600A736 RID: 42806 RVA: 0x004E1B88 File Offset: 0x004DFD88
			private int InsertString()
			{
				int num = (this.ins_h << 5 ^ (int)this.window[this.strstart + 2]) & 32767;
				short num2 = this.prev[this.strstart & 32767] = this.head[num];
				this.head[num] = (short)this.strstart;
				this.ins_h = num;
				return (int)num2 & 65535;
			}

			// Token: 0x0600A737 RID: 42807 RVA: 0x004E1BF0 File Offset: 0x004DFDF0
			private void SlideWindow()
			{
				Array.Copy(this.window, 32768, this.window, 0, 32768);
				this.matchStart -= 32768;
				this.strstart -= 32768;
				this.blockStart -= 32768;
				for (int i = 0; i < 32768; i++)
				{
					int num = (int)this.head[i] & 65535;
					this.head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
				}
				for (int j = 0; j < 32768; j++)
				{
					int num2 = (int)this.prev[j] & 65535;
					this.prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
				}
			}

			// Token: 0x0600A738 RID: 42808 RVA: 0x004E1CC4 File Offset: 0x004DFEC4
			public void FillWindow()
			{
				if (this.strstart >= 65274)
				{
					this.SlideWindow();
				}
				while (this.lookahead < 262 && this.inputOff < this.inputEnd)
				{
					int num = 65536 - this.lookahead - this.strstart;
					if (num > this.inputEnd - this.inputOff)
					{
						num = this.inputEnd - this.inputOff;
					}
					Array.Copy(this.inputBuf, this.inputOff, this.window, this.strstart + this.lookahead, num);
					this.inputOff += num;
					this.totalIn += num;
					this.lookahead += num;
				}
				if (this.lookahead >= 3)
				{
					this.UpdateHash();
				}
			}

			// Token: 0x0600A739 RID: 42809 RVA: 0x004E1DA0 File Offset: 0x004DFFA0
			private bool FindLongestMatch(int curMatch)
			{
				int num = 128;
				int num2 = 128;
				short[] array = this.prev;
				int num3 = this.strstart;
				int num4 = this.strstart + this.matchLen;
				int num5 = Math.Max(this.matchLen, 2);
				int num6 = Math.Max(this.strstart - 32506, 0);
				int num7 = this.strstart + 258 - 1;
				byte b = this.window[num4 - 1];
				byte b2 = this.window[num4];
				if (num5 >= 8)
				{
					num >>= 2;
				}
				if (num2 > this.lookahead)
				{
					num2 = this.lookahead;
				}
				do
				{
					if (this.window[curMatch + num5] == b2 && this.window[curMatch + num5 - 1] == b && this.window[curMatch] == this.window[num3] && this.window[curMatch + 1] == this.window[num3 + 1])
					{
						int num8 = curMatch + 2;
						num3 += 2;
						while (this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && this.window[++num3] == this.window[++num8] && num3 < num7)
						{
						}
						if (num3 > num4)
						{
							this.matchStart = curMatch;
							num4 = num3;
							num5 = num3 - this.strstart;
							if (num5 >= num2)
							{
								break;
							}
							b = this.window[num4 - 1];
							b2 = this.window[num4];
						}
						num3 = this.strstart;
					}
					if ((curMatch = ((int)array[curMatch & 32767] & 65535)) <= num6)
					{
						break;
					}
				}
				while (--num != 0);
				this.matchLen = Math.Min(num5, this.lookahead);
				return this.matchLen >= 3;
			}

			// Token: 0x0600A73A RID: 42810 RVA: 0x004E201C File Offset: 0x004E021C
			private bool DeflateSlow(bool flush, bool finish)
			{
				if (this.lookahead < 262 && !flush)
				{
					return false;
				}
				while (this.lookahead >= 262 || flush)
				{
					if (this.lookahead == 0)
					{
						if (this.prevAvailable)
						{
							this.huffman.TallyLit((int)(this.window[this.strstart - 1] & 255));
						}
						this.prevAvailable = false;
						this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, finish);
						this.blockStart = this.strstart;
						return false;
					}
					if (this.strstart >= 65274)
					{
						this.SlideWindow();
					}
					int num = this.matchStart;
					int num2 = this.matchLen;
					if (this.lookahead >= 3)
					{
						int num3 = this.InsertString();
						if (num3 != 0 && this.strstart - num3 <= 32506 && this.FindLongestMatch(num3) && this.matchLen <= 5 && this.matchLen == 3 && this.strstart - this.matchStart > 4096)
						{
							this.matchLen = 2;
						}
					}
					if (num2 >= 3 && this.matchLen <= num2)
					{
						this.huffman.TallyDist(this.strstart - 1 - num, num2);
						num2 -= 2;
						do
						{
							this.strstart++;
							this.lookahead--;
							if (this.lookahead >= 3)
							{
								this.InsertString();
							}
						}
						while (--num2 > 0);
						this.strstart++;
						this.lookahead--;
						this.prevAvailable = false;
						this.matchLen = 2;
					}
					else
					{
						if (this.prevAvailable)
						{
							this.huffman.TallyLit((int)(this.window[this.strstart - 1] & 255));
						}
						this.prevAvailable = true;
						this.strstart++;
						this.lookahead--;
					}
					if (this.huffman.IsFull())
					{
						int num4 = this.strstart - this.blockStart;
						if (this.prevAvailable)
						{
							num4--;
						}
						bool flag = finish && this.lookahead == 0 && !this.prevAvailable;
						this.huffman.FlushBlock(this.window, this.blockStart, num4, flag);
						this.blockStart += num4;
						return !flag;
					}
				}
				return true;
			}

			// Token: 0x0600A73B RID: 42811 RVA: 0x004E2298 File Offset: 0x004E0498
			public bool Deflate(bool flush, bool finish)
			{
				bool flag;
				do
				{
					this.FillWindow();
					bool flush2 = flush && this.inputOff == this.inputEnd;
					flag = this.DeflateSlow(flush2, finish);
					if (!this.pending.IsFlushed)
					{
						break;
					}
				}
				while (flag);
				return flag;
			}

			// Token: 0x0600A73C RID: 42812 RVA: 0x0004F9F8 File Offset: 0x0004DBF8
			public void SetInput(byte[] buffer)
			{
				this.inputBuf = buffer;
				this.inputOff = 0;
				this.inputEnd = buffer.Length;
			}

			// Token: 0x0600A73D RID: 42813 RVA: 0x0004FA11 File Offset: 0x0004DC11
			public bool NeedsInput()
			{
				return this.inputEnd == this.inputOff;
			}

			// Token: 0x040056C4 RID: 22212
			private const int MAX_MATCH = 258;

			// Token: 0x040056C5 RID: 22213
			private const int MIN_MATCH = 3;

			// Token: 0x040056C6 RID: 22214
			private const int WSIZE = 32768;

			// Token: 0x040056C7 RID: 22215
			private const int WMASK = 32767;

			// Token: 0x040056C8 RID: 22216
			private const int HASH_SIZE = 32768;

			// Token: 0x040056C9 RID: 22217
			private const int HASH_MASK = 32767;

			// Token: 0x040056CA RID: 22218
			private const int HASH_SHIFT = 5;

			// Token: 0x040056CB RID: 22219
			private const int MIN_LOOKAHEAD = 262;

			// Token: 0x040056CC RID: 22220
			private const int MAX_DIST = 32506;

			// Token: 0x040056CD RID: 22221
			private const int TOO_FAR = 4096;

			// Token: 0x040056CE RID: 22222
			private int ins_h;

			// Token: 0x040056CF RID: 22223
			private short[] head;

			// Token: 0x040056D0 RID: 22224
			private short[] prev;

			// Token: 0x040056D1 RID: 22225
			private int matchStart;

			// Token: 0x040056D2 RID: 22226
			private int matchLen;

			// Token: 0x040056D3 RID: 22227
			private bool prevAvailable;

			// Token: 0x040056D4 RID: 22228
			private int blockStart;

			// Token: 0x040056D5 RID: 22229
			private int strstart;

			// Token: 0x040056D6 RID: 22230
			private int lookahead;

			// Token: 0x040056D7 RID: 22231
			private byte[] window;

			// Token: 0x040056D8 RID: 22232
			private byte[] inputBuf;

			// Token: 0x040056D9 RID: 22233
			private int totalIn;

			// Token: 0x040056DA RID: 22234
			private int inputOff;

			// Token: 0x040056DB RID: 22235
			private int inputEnd;

			// Token: 0x040056DC RID: 22236
			private SimpleZip.DeflaterPending pending;

			// Token: 0x040056DD RID: 22237
			private SimpleZip.DeflaterHuffman huffman;
		}

		// Token: 0x0200128F RID: 4751
		internal sealed class DeflaterPending
		{
			// Token: 0x0600A73E RID: 42814 RVA: 0x004E22DC File Offset: 0x004E04DC
			public void WriteShort(int s)
			{
				this.buf[this.end++] = (byte)s;
				this.buf[this.end++] = (byte)(s >> 8);
			}

			// Token: 0x0600A73F RID: 42815 RVA: 0x0004FA21 File Offset: 0x0004DC21
			public void WriteBlock(byte[] block, int offset, int len)
			{
				Array.Copy(block, offset, this.buf, this.end, len);
				this.end += len;
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x0600A740 RID: 42816 RVA: 0x0004FA45 File Offset: 0x0004DC45
			public int BitCount
			{
				get
				{
					return this.bitCount;
				}
			}

			// Token: 0x0600A741 RID: 42817 RVA: 0x004E2320 File Offset: 0x004E0520
			public void AlignToByte()
			{
				if (this.bitCount > 0)
				{
					this.buf[this.end++] = (byte)this.bits;
					if (this.bitCount > 8)
					{
						this.buf[this.end++] = (byte)(this.bits >> 8);
					}
				}
				this.bits = 0u;
				this.bitCount = 0;
			}

			// Token: 0x0600A742 RID: 42818 RVA: 0x004E2390 File Offset: 0x004E0590
			public void WriteBits(int b, int count)
			{
				this.bits |= (uint)((uint)b << this.bitCount);
				this.bitCount += count;
				if (this.bitCount >= 16)
				{
					this.buf[this.end++] = (byte)this.bits;
					this.buf[this.end++] = (byte)(this.bits >> 8);
					this.bits >>= 16;
					this.bitCount -= 16;
				}
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x0600A743 RID: 42819 RVA: 0x0004FA4D File Offset: 0x0004DC4D
			public bool IsFlushed
			{
				get
				{
					return this.end == 0;
				}
			}

			// Token: 0x0600A744 RID: 42820 RVA: 0x004E242C File Offset: 0x004E062C
			public int Flush(byte[] output, int offset, int length)
			{
				if (this.bitCount >= 8)
				{
					this.buf[this.end++] = (byte)this.bits;
					this.bits >>= 8;
					this.bitCount -= 8;
				}
				if (length > this.end - this.start)
				{
					length = this.end - this.start;
					Array.Copy(this.buf, this.start, output, offset, length);
					this.start = 0;
					this.end = 0;
				}
				else
				{
					Array.Copy(this.buf, this.start, output, offset, length);
					this.start += length;
				}
				return length;
			}

			// Token: 0x040056DE RID: 22238
			protected byte[] buf = new byte[65536];

			// Token: 0x040056DF RID: 22239
			private int start = 0;

			// Token: 0x040056E0 RID: 22240
			private int end = 0;

			// Token: 0x040056E1 RID: 22241
			private uint bits = 0u;

			// Token: 0x040056E2 RID: 22242
			private int bitCount = 0;
		}

		// Token: 0x02001290 RID: 4752
		internal sealed class ZipStream : MemoryStream
		{
			// Token: 0x0600A746 RID: 42822 RVA: 0x0004FA8C File Offset: 0x0004DC8C
			public void WriteShort(int value)
			{
				this.WriteByte((byte)(value & 255));
				this.WriteByte((byte)(value >> 8 & 255));
			}

			// Token: 0x0600A747 RID: 42823 RVA: 0x0004FAAC File Offset: 0x0004DCAC
			public void WriteInt(int value)
			{
				this.WriteShort(value);
				this.WriteShort(value >> 16);
			}

			// Token: 0x0600A748 RID: 42824 RVA: 0x0004FABF File Offset: 0x0004DCBF
			public int ReadShort()
			{
				return this.ReadByte() | this.ReadByte() << 8;
			}

			// Token: 0x0600A749 RID: 42825 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
			public int ReadInt()
			{
				return this.ReadShort() | this.ReadShort() << 16;
			}

			// Token: 0x0600A74A RID: 42826 RVA: 0x0004FAE2 File Offset: 0x0004DCE2
			public ZipStream()
			{
			}

			// Token: 0x0600A74B RID: 42827 RVA: 0x00005B3B File Offset: 0x00003D3B
			public ZipStream(byte[] buffer) : base(buffer, false)
			{
			}
		}
	}
}
