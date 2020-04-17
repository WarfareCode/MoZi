using System;
using System.IO;
using ns32;

namespace ns31
{
	// Token: 0x020004A1 RID: 1185
	public class Stream2 : Stream
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x000128A2 File Offset: 0x00010AA2
		public override bool CanRead
		{
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x000081A2 File Offset: 0x000063A2
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000CA820 File Offset: 0x000C8A20
		public override long Length
		{
			get
			{
				return (long)this.class2453_0.method_0();
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x000CA83C File Offset: 0x000C8A3C
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x000128AF File Offset: 0x00010AAF
		public override long Position
		{
			get
			{
				return this.stream_0.Position;
			}
			set
			{
				throw new NotSupportedException("InflaterInputStream Position not supported");
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x000128BB File Offset: 0x00010ABB
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x000128C8 File Offset: 0x00010AC8
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("Seek not supported");
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000128D4 File Offset: 0x00010AD4
		public override void SetLength(long value)
		{
			throw new NotSupportedException("InflaterInputStream SetLength not supported");
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000128E0 File Offset: 0x00010AE0
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException("InflaterInputStream Write not supported");
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x000128EC File Offset: 0x00010AEC
		public override void WriteByte(byte value)
		{
			throw new NotSupportedException("InflaterInputStream WriteByte not supported");
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x000128F8 File Offset: 0x00010AF8
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00012904 File Offset: 0x00010B04
		public Stream2(Stream stream_1, Class2451 class2451_1) : this(stream_1, class2451_1, 4096)
		{
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x000CA858 File Offset: 0x000C8A58
		public Stream2(Stream stream_1, Class2451 class2451_1, int int_0)
		{
			if (stream_1 == null)
			{
				throw new ArgumentNullException("InflaterInputStream baseInputStream is null");
			}
			if (class2451_1 == null)
			{
				throw new ArgumentNullException("InflaterInputStream Inflater is null");
			}
			if (int_0 <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.stream_0 = stream_1;
			this.class2451_0 = class2451_1;
			this.class2453_0 = new Class2453(stream_1);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00012913 File Offset: 0x00010B13
		public override void Close()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				if (this.bool_1)
				{
					this.stream_0.Close();
				}
			}
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0001293A File Offset: 0x00010B3A
		protected void method_0()
		{
			this.class2453_0.method_4();
			this.class2453_0.method_3(this.class2451_0);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x000CA8CC File Offset: 0x000C8ACC
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = 0;
			while (true)
			{
				try
				{
					num = this.class2451_0.method_7(buffer, offset, count);
				}
				catch (Exception ex)
				{
					throw new Exception30(ex.ToString());
				}
				if (num > 0)
				{
					break;
				}
				if (this.class2451_0.method_9())
				{
					goto IL_68;
				}
				if (this.class2451_0.method_10())
				{
					goto IL_73;
				}
				if (!this.class2451_0.method_8())
				{
					goto IL_77;
				}
				this.method_0();
			}
			int result = num;
			return result;
			IL_68:
			throw new Exception30("Need a dictionary");
			IL_73:
			result = 0;
			return result;
			IL_77:
			throw new InvalidOperationException("Don't know what to do");
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x000CA96C File Offset: 0x000C8B6C
		public long method_1(long long_1)
		{
			if (long_1 <= 0L)
			{
				throw new ArgumentOutOfRangeException("n");
			}
			long result;
			if (this.stream_0.CanSeek)
			{
				this.stream_0.Seek(long_1, SeekOrigin.Current);
				result = long_1;
			}
			else
			{
				int num = 2048;
				if (long_1 < 2048L)
				{
					num = (int)long_1;
				}
				byte[] array = new byte[num];
				result = (long)this.stream_0.Read(array, 0, array.Length);
			}
			return result;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00012958 File Offset: 0x00010B58
		protected void method_2()
		{
			this.class2453_0.method_11(null);
		}

		// Token: 0x04000E21 RID: 3617
		protected Class2451 class2451_0;

		// Token: 0x04000E22 RID: 3618
		protected Class2453 class2453_0;

		// Token: 0x04000E23 RID: 3619
		protected Stream stream_0;

		// Token: 0x04000E24 RID: 3620
		protected long long_0;

		// Token: 0x04000E25 RID: 3621
		private bool bool_0 = false;

		// Token: 0x04000E26 RID: 3622
		private bool bool_1 = true;
	}
}
