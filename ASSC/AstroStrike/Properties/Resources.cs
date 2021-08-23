using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AstroStrike.Properties
{
	// Token: 0x02000028 RID: 40
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00002072 File Offset: 0x00000272
		internal Resources()
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00006E84 File Offset: 0x00005084
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					ResourceManager resourceManager = new ResourceManager("AstroStrike.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000024E2 File Offset: 0x000006E2
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00006ED8 File Offset: 0x000050D8
		internal static Bitmap test
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("test", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000150 RID: 336
		private static ResourceManager resourceMan;

		// Token: 0x04000151 RID: 337
		private static CultureInfo resourceCulture;
	}
}
