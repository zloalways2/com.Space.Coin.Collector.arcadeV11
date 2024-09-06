using System;

// Token: 0x02000025 RID: 37
public class ToggleClick : ToggleListener
{
	// Token: 0x0600009B RID: 155 RVA: 0x00002EB3 File Offset: 0x000010B3
	protected override void Handle()
	{
		ClickSFX.Play();
	}
}
