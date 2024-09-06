using System;

// Token: 0x02000020 RID: 32
public class ReloadSceneButton : ButtonListener
{
	// Token: 0x0600008A RID: 138 RVA: 0x00002F14 File Offset: 0x00001114
	protected override void Handle()
	{
		SceneLoad.Restart();
	}
}
