using System;
using DotSpatial.Topology;
using ns24;

namespace ns23
{
	// Token: 0x0200068F RID: 1679
	public sealed class Key
	{
		// Token: 0x06002A9A RID: 10906 RVA: 0x0001745A File Offset: 0x0001565A
		public Key(IEnvelope ienvelope_1)
		{
			this.ComputeKey(ienvelope_1);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000FEE2C File Offset: 0x000FD02C
		public  int GetLevel()
		{
			return this._level;
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000FEE44 File Offset: 0x000FD044
		public  IEnvelope GetEnvelope()
		{
			return this._env;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000FEE5C File Offset: 0x000FD05C
		public static int ComputeQuadLevel(IEnvelope env)
		{
			double width = env.GetWidth();
			double height = env.GetHeight();
			double d = (width > height) ? width : height;
			return DoubleBits.GetExponent(d) + 1;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000FEE8C File Offset: 0x000FD08C
		public void ComputeKey(IEnvelope itemEnv)
		{
			this._level = Key.ComputeQuadLevel(itemEnv);
			this._env = new Envelope();
			this.ComputeKey(this._level, itemEnv);
			while (!Class2183.smethod_9(this._env, itemEnv))
			{
				this._level++;
				this.ComputeKey(this._level, itemEnv);
			}
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000FEEEC File Offset: 0x000FD0EC
		private void ComputeKey(int level, IEnvelope itemEnv)
		{
			double num = DoubleBits.PowerOf2(level);
			this._pt.X = Math.Floor(itemEnv.GetMinimum().X / num) * num;
			this._pt.Y = Math.Floor(itemEnv.GetMinimum().Y / num) * num;
			this._env = new Envelope(this._pt.X, this._pt.X + num, this._pt.Y, this._pt.Y + num);
		}

		// Token: 0x0400144A RID: 5194
		private readonly Coordinate _pt = new Coordinate();

		// Token: 0x0400144B RID: 5195
		private IEnvelope _env;

		// Token: 0x0400144C RID: 5196
		private int _level;
	}
}
