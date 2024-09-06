using System;
using UnityEngine;

// Token: 0x0200001F RID: 31
public class ExitButton : ButtonListener
{
	// Token: 0x06000088 RID: 136 RVA: 0x00002F0B File Offset: 0x0000110B
	protected override void Handle()
	{
		Application.Quit();
	}
}
