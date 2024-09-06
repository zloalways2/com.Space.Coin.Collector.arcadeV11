using System;

// Token: 0x02000024 RID: 36
public class ClickSFXMuteToggle : ToggleListener
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000097 RID: 151 RVA: 0x00003022 File Offset: 0x00001222
	private ClickSFX @ӓ
	{
		get
		{
			return Audio<ClickSFX>.StaticInstance;
		}
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00003029 File Offset: 0x00001229
	protected override void HandleSubscribed()
	{
		base.Toggle.SetIsOnWithoutNotify(!this.@ӓ.IsMuted);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00003048 File Offset: 0x00001248
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
