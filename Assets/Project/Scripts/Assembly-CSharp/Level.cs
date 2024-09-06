using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000007 RID: 7
public static class Level
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0000238D File Offset: 0x0000058D
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00002394 File Offset: 0x00000594
	public static int Value { get; private set; } = 1;

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001A RID: 26 RVA: 0x0000239C File Offset: 0x0000059C
	public static int MaxUnlocked
	{
		get
		{
			return PlayerPrefs.GetInt("LevelSaveKey", 1);
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000023AC File Offset: 0x000005AC
	public static bool TrySetValue(int value)
	{
		bool flag = value > 15;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			bool flag2 = value < 1;
			if (flag2)
			{
				result = false;
			}
			else
			{
				Level.Value = value;
				result = true;
			}
		}
		return result;
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000023E0 File Offset: 0x000005E0
	public static bool TryNextLevel()
	{
		bool flag = Level.Value >= 15;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			Level.TryUnlockNext();
			Level.Value++;
			result = true;
		}
		return result;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000241C File Offset: 0x0000061C
	public static bool TryUnlockNext()
	{
		bool flag = Level.Value != Level.MaxUnlocked;
		bool result;
		if (flag)
		{
			result = false;
		}
		else
		{
			PlayerPrefs.SetInt("LevelSaveKey", Level.Value + 1);
			result = true;
		}
		return result;
	}

	// Token: 0x04000011 RID: 17
	public const int Count = 15;

	// Token: 0x04000012 RID: 18
	public const int Min = 1;

	// Token: 0x04000013 RID: 19
	private const string @ӓ = "LevelSaveKey";

	// Token: 0x04000014 RID: 20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static int @Ӕ;
}
