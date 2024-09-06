using System;

// Token: 0x02000015 RID: 21
public class NextLevelButton : ButtonListener
{
	// Token: 0x0600005D RID: 93 RVA: 0x00002B54 File Offset: 0x00000D54
	protected override void Handle()
	{
		bool flag = Level.TryNextLevel();
		if (flag)
		{
			SceneLoad.Restart();
		}
	}
}
