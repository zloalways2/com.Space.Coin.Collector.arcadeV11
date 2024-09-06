using System;

// Token: 0x02000019 RID: 25
public class BackgroundMusic : Audio<BackgroundMusic>
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000074 RID: 116 RVA: 0x00002E3E File Offset: 0x0000103E
	protected override string SaveKey
	{
		get
		{
			return "BackgroundMusic";
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000075 RID: 117 RVA: 0x00002E45 File Offset: 0x00001045
	protected override bool PlayOnAwake
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000076 RID: 118 RVA: 0x00002E45 File Offset: 0x00001045
	protected override bool Loop
	{
		get
		{
			return true;
		}
	}
}
