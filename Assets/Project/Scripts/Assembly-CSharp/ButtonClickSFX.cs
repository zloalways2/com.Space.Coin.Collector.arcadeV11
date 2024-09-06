using System;

// Token: 0x0200001D RID: 29
public class ButtonClickSFX : ButtonListener
{
	// Token: 0x06000081 RID: 129 RVA: 0x00002EB3 File Offset: 0x000010B3
	protected override void Handle()
	{
		ClickSFX.Play();
	}
}
