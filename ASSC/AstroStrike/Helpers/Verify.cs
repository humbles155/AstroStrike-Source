using System;
using System.Linq;

namespace AstroStrike.Helpers
{
	// Token: 0x02000068 RID: 104
	public class Verify
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public static bool IsValidIPv4(string ip)
		{
			bool result;
			if (string.IsNullOrWhiteSpace(ip))
			{
				result = false;
			}
			else
			{
				string[] array = ip.Split(new char[]
				{
					'.'
				});
				byte tempForParsing;
				result = (array.Length == 4 && array.All((string r) => byte.TryParse(r, out tempForParsing)));
			}
			return result;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		public static bool IsValidInteger(string value)
		{
			int num;
			return int.TryParse(value, out num);
		}
	}
}
