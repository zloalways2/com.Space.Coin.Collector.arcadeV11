using System;

// Token: 0x0200001A RID: 26
public class ClickSFX : Audio<ClickSFX>
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000078 RID: 120 RVA: 0x00002E51 File Offset: 0x00001051
	protected override string SaveKey
	{
		get
		{
			return "ClickSFX";
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000079 RID: 121 RVA: 0x00002E58 File Offset: 0x00001058
	protected override bool PlayOnAwake
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600007A RID: 122 RVA: 0x00002E58 File Offset: 0x00001058
	protected override bool Loop
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002E5B File Offset: 0x0000105B
	public static void Play()
	{
		Audio<ClickSFX>.StaticInstance.Source.Play();
	}
}
