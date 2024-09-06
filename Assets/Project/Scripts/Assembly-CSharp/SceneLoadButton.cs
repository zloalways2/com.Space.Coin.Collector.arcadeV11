using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class SceneLoadButton : ButtonListener
{
	// Token: 0x0600008C RID: 140 RVA: 0x00002F1C File Offset: 0x0000111C
	protected override void Handle()
	{
		SceneLoad.Load(this.@ӓ);
	}

	// Token: 0x0400003C RID: 60
	[SerializeField]
	private string @ӓ;
}
