using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x02000480 RID: 1152
	public sealed class Stream1 : Stream
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0000945D File Offset: 0x0000765D
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000C0340 File Offset: 0x000BE540
		public override long Length
		{
			get
			{
				return this.long_1;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000C0358 File Offset: 0x000BE558
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0001235F File Offset: 0x0001055F
		public override long Position
		{
			get;
			set;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00012368 File Offset: 0x00010568
		public Stream1()
		{
			this.Position = 0L;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00012399 File Offset: 0x00010599
		public Stream1(byte[] byte_0)
		{
			this.Write(byte_0, 0, byte_0.Length);
			this.Position = 0L;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000C0370 File Offset: 0x000BE570
		protected byte[] method_0()
		{
			while ((long)this.list_0.Count <= this.method_1())
			{
				this.list_0.Add(new byte[this.long_2]);
			}
			return this.list_0[(int)this.method_1()];
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x000C03C4 File Offset: 0x000BE5C4
		protected long method_1()
		{
			return this.Position / this.long_2;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x000C03E0 File Offset: 0x000BE5E0
		protected long method_2()
		{
			return this.Position % this.long_2;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public override void Flush()
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000C03FC File Offset: 0x000BE5FC
		public override int Read(byte[] buffer, int offset, int count)
		{
			long num = (long)count;
			if (num < 0L)
			{
				throw new ArgumentOutOfRangeException("count", num, "Number of bytes to copy cannot be negative.");
			}
			long num2 = this.long_1 - this.Position;
			if (num > num2)
			{
				num = num2;
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer", "Buffer cannot be null.");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", offset, "Destination offset cannot be negative.");
			}
			int num3 = 0;
			do
			{
				long num4 = Math.Min(num, this.long_2 - this.method_2());
				Buffer.BlockCopy(this.method_0(), (int)this.method_2(), buffer, offset, (int)num4);
				num -= num4;
				offset += (int)num4;
				num3 += (int)num4;
				this.Position += num4;
			}
			while (num > 0L);
			return num3;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000C04E0 File Offset: 0x000BE6E0
		public override long Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
			case SeekOrigin.Begin:
				this.Position = offset;
				break;
			case SeekOrigin.Current:
				this.Position += offset;
				break;
			case SeekOrigin.End:
				this.Position = this.Length - offset;
				break;
			}
			return this.Position;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000123D5 File Offset: 0x000105D5
		public override void SetLength(long value)
		{
			this.long_1 = value;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000C0534 File Offset: 0x000BE734
		public override void Write(byte[] buffer, int offset, int count)
		{
			long position = this.Position;
			try
			{
				do
				{
					int num = Math.Min(count, (int)(this.long_2 - this.method_2()));
					this.method_3(this.Position + (long)num);
					Buffer.BlockCopy(buffer, offset, this.method_0(), (int)this.method_2(), num);
					count -= num;
					offset += num;
					this.Position += (long)num;
				}
				while (count > 0);
			}
			catch (Exception ex)
			{
				this.Position = position;
				throw ex;
			}
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x000C05C0 File Offset: 0x000BE7C0
		public override int ReadByte()
		{
			int result;
			if (this.Position >= this.long_1)
			{
				result = -1;
			}
			else
			{
				int num = (int)this.method_0()[(int)((IntPtr)this.method_2())];
				long position = this.Position;
				this.Position = position + 1L;
				result = num;
			}
			return result;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000C0614 File Offset: 0x000BE814
		public override void WriteByte(byte value)
		{
			this.method_3(this.Position + 1L);
			this.method_0()[(int)((IntPtr)this.method_2())] = value;
			long position = this.Position;
			this.Position = position + 1L;
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000123DE File Offset: 0x000105DE
		protected void method_3(long long_3)
		{
			if (long_3 > this.long_1)
			{
				this.long_1 = long_3;
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000123F5 File Offset: 0x000105F5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000C0668 File Offset: 0x000BE868
		public byte[] ToArray()
		{
			long position = this.Position;
			this.Position = 0L;
			byte[] array = new byte[this.Length];
			this.Read(array, 0, (int)this.Length);
			this.Position = position;
			return array;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x000C06B4 File Offset: 0x000BE8B4
		public void Copy(Stream stream_)
		{
			long position = this.Position;
			this.Position = 0L;
			base.CopyTo(stream_);
			this.Position = position;
		}

		// Token: 0x04000D52 RID: 3410
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04000D53 RID: 3411
		protected long long_1;

		// Token: 0x04000D54 RID: 3412
		protected long long_2 = 65536L;

		// Token: 0x04000D55 RID: 3413
		protected List<byte[]> list_0 = new List<byte[]>();
	}
}
