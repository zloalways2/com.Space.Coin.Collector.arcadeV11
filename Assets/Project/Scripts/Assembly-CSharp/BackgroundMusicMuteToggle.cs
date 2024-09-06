using System;

// Token: 0x02000023 RID: 35
public class BackgroundMusicMuteToggle : ToggleListener
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000093 RID: 147 RVA: 0x00002FC8 File Offset: 0x000011C8
	private BackgroundMusic @ӓ
	{
		get
		{
			return Audio<BackgroundMusic>.StaticInstance;
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002FCF File Offset: 0x000011CF
	protected override void HandleSubscribed()
	{
		base.Toggle.SetIsOnWithoutNotify(!this.@ӓ.IsMuted);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002FEC File Offset: 0x000011EC
	protected override void Handle(bool value)
	{
		if (value)
		{
			this.@ӓ.UnMute();
		}
		else
		{
			this.@ӓ.Mute();
		}
	}
}
