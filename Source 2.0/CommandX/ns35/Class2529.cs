using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AdvancedDataGridView;
using Command;
using Command_Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns15;
using ns29;
using ThreadSafeControls;

namespace ns35
{
	// Token: 0x02000A71 RID: 2673
	public sealed class Class2529
	{
		// Token: 0x060054C2 RID: 21698 RVA: 0x00234780 File Offset: 0x00232980
		public static Image smethod_0(Image image_0, float float_0)
		{
			Image result;
			Image image;
			if (float_0 == 1f)
			{
				result = image_0;
			}
			else if (Class2529.dictionary_0.TryGetValue(image_0, out image))
			{
				result = image;
			}
			else
			{
				Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
				Graphics graphics = Graphics.FromImage(bitmap);
				ColorMatrix colorMatrix = new ColorMatrix();
				colorMatrix.Matrix33 = float_0;
				ImageAttributes imageAttributes = new ImageAttributes();
				imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				graphics.DrawImage(image_0, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, image_0.Width, image_0.Height, GraphicsUnit.Pixel, imageAttributes);
				graphics.Dispose();
				Class2529.dictionary_0.Add(image_0, bitmap);
				result = bitmap;
			}
			return result;
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x00234838 File Offset: 0x00232A38
		public static string smethod_1(string string_0)
		{
			string text = string_0;
			char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
			string text2 = text;
			checked
			{
				for (int i = 0; i < text2.Length; i++)
				{
					char value = text2[i];
					char[] array = invalidFileNameChars;
					for (int j = 0; j < array.Length; j++)
					{
						char c = array[j];
						if (Operators.CompareString(c.ToString(), value.ToString(), false) == 0)
						{
							text = text.Replace(Conversions.ToString(value), "");
						}
					}
				}
				return text;
			}
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x002348C0 File Offset: 0x00232AC0
		public static Bitmap smethod_2(string string_0, Bitmap bitmap_0, double double_0)
		{
			return Class2529.smethod_3(string_0, bitmap_0, (float)double_0);
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x002348D8 File Offset: 0x00232AD8
		private static Bitmap smethod_3(string string_0, Image image_0, float float_0)
		{
			Bitmap result;
			if ((int)Math.Round((double)float_0) == 0)
			{
				result = (Bitmap)image_0;
			}
			else
			{
				if (image_0 == null)
				{
					throw new ArgumentNullException("image");
				}
				Image image = null;
				Client.dictionary_1.TryGetValue(string_0 + Conversions.ToString((int)Math.Round((double)float_0)), out image);
				if (Information.IsNothing(image))
				{
					Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height);
					Graphics graphics = Graphics.FromImage(bitmap);
					graphics.TranslateTransform((float)image_0.Width / 2f, (float)image_0.Height / 2f);
					graphics.RotateTransform((float)((int)Math.Round((double)float_0)));
					graphics.TranslateTransform(-(float)image_0.Width / 2f, -(float)image_0.Height / 2f);
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.DrawImage(image_0, new Point(0, 0));
					image = bitmap;
					Client.dictionary_1.Add(string_0 + Conversions.ToString((int)Math.Round((double)float_0)), image);
				}
				result = (Bitmap)image;
			}
			return result;
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x002349F0 File Offset: 0x00232BF0
		public static Image smethod_4(Image image, Size size, bool preserveAspectRatio = true)
		{
			int width2;
			int height2;
			if (preserveAspectRatio)
			{
				int width = image.Width;
				int height = image.Height;
				float num = (float)size.Width / (float)width;
				float num2 = (float)size.Height / (float)height;
				float num3 = (num2 < num) ? num2 : num;
				width2 = (int)Math.Round((double)((float)width * num3));
				height2 = (int)Math.Round((double)((float)height * num3));
			}
			else
			{
				width2 = size.Width;
				height2 = size.Height;
			}
			Image image2 = new Bitmap(width2, height2);
			using (Graphics graphics = Graphics.FromImage(image2))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.DrawImage(image, 0, 0, width2, height2);
			}
			return image2;
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00234AB4 File Offset: 0x00232CB4
		public static ReadOnlyCollection<TreeNode> smethod_5(TreeView treeView_0)
		{
			List<TreeNode> list = new List<TreeNode>();
			IEnumerator enumerator = treeView_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (!list.Contains(treeNode))
					{
						list.Add(treeNode);
					}
					Class2529.smethod_8(treeNode, list);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return list.AsReadOnly();
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00234B38 File Offset: 0x00232D38
		public static ReadOnlyCollection<ThreadSafeTreeNode> smethod_6(Class682 class682_0)
		{
			List<ThreadSafeTreeNode> list = new List<ThreadSafeTreeNode>();
			foreach (ThreadSafeTreeNode current in class682_0.Nodes)
			{
				if (!list.Contains(current))
				{
					list.Add(current);
				}
				Class2529.smethod_9(current, list);
			}
			return list.AsReadOnly();
		}

		// Token: 0x060054C9 RID: 21705 RVA: 0x00234BA8 File Offset: 0x00232DA8
		public static void smethod_7(WebBrowser theBrowser, string theHTML, Color theColor = default(Color))
		{
			try
			{
				theBrowser.DocumentText = theHTML;
				if (!Information.IsNothing(theColor))
				{
					theBrowser.Document.BackColor = Color.Black;
				}
				theBrowser.Document.Write(theHTML);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ex2.Data.Add("Error at 200101", ex2.Message);
				GameGeneral.LogException(ref ex2);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x00234C34 File Offset: 0x00232E34
		private static void smethod_8(TreeNode treeNode_0, List<TreeNode> list_0)
		{
			IEnumerator enumerator = treeNode_0.Nodes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					TreeNode treeNode = (TreeNode)enumerator.Current;
					if (!list_0.Contains(treeNode))
					{
						list_0.Add(treeNode);
					}
					Class2529.smethod_8(treeNode, list_0);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x00234CA8 File Offset: 0x00232EA8
		private static void smethod_9(ThreadSafeTreeNode threadSafeTreeNode_0, List<ThreadSafeTreeNode> list_0)
		{
			foreach (ThreadSafeTreeNode current in threadSafeTreeNode_0.Nodes)
			{
				if (!list_0.Contains(current))
				{
					list_0.Add(current);
				}
				Class2529.smethod_9(current, list_0);
			}
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x00234D0C File Offset: 0x00232F0C
		public static ReadOnlyCollection<TreeGridViewRow> smethod_10(TreeGridView treeGridView_0)
		{
			List<TreeGridViewRow> list = new List<TreeGridViewRow>();
			foreach (TreeGridViewRow current in treeGridView_0.Nodes)
			{
				if (!list.Contains(current))
				{
					list.Add(current);
				}
				Class2529.smethod_11(current, list);
			}
			return list.AsReadOnly();
		}

		// Token: 0x060054CD RID: 21709 RVA: 0x00234D7C File Offset: 0x00232F7C
		private static void smethod_11(TreeGridViewRow class2384_0, List<TreeGridViewRow> list_0)
		{
			foreach (TreeGridViewRow current in class2384_0.Nodes)
			{
				if (!list_0.Contains(current))
				{
					list_0.Add(current);
				}
				Class2529.smethod_11(current, list_0);
			}
		}

		// Token: 0x060054CE RID: 21710 RVA: 0x00234DE0 File Offset: 0x00232FE0
		public static int smethod_12(Scenario scenario_0)
		{
			List<string> list = new List<string>();
			Campaign.smethod_3(GameGeneral.strScenariosDir, list);
			int result = 0;
			List<string>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Campaign campaign = Campaign.GetCampaign(enumerator.Current);
					if (Operators.CompareString(campaign.ID, Client.GetClientScenario().CampaignID, false) == 0)
					{
						result = campaign.method_2(scenario_0.GetObjectID()).GetPassScore();
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			return result;
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00234E80 File Offset: 0x00233080
		public static bool IsIsolatedPOVObject(ActiveUnit activeUnit_)
		{
			bool result = false;
			try
			{
				result = (!string.IsNullOrEmpty(Client.GetMap().GetIsolatedPOVObjectID()) && Operators.CompareString(activeUnit_.GetGuid(), Client.GetMap().GetIsolatedPOVObjectID(), false) == 0);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Debugger.IsAttached)
				{
					Debugger.Break();
				}
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x040028FF RID: 10495
		private static Dictionary<Image, Image> dictionary_0 = new Dictionary<Image, Image>();
	}
}
