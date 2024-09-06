using System;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class WinView : MonoBehaviour
{
	// Token: 0x0600005F RID: 95 RVA: 0x00002B7C File Offset: 0x00000D7C
	private void Awake()
	{
		SecondsCounter secondsCounter = this.@Ӕ;
		secondsCounter.TimeOver = (Action)Delegate.Combine(secondsCounter.TimeOver, new Action(this.@Ә));
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002C00 File Offset: 0x00000E00
	private void @Ә()
	{
		bool isAllCollected = this.@ӕ.IsAllCollected;
		if (isAllCollected)
		{
			this.@Ӗ.SetActive(true);
			this.@ӓ.Enable();
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002C38 File Offset: 0x00000E38
	private void OnDestroy()
	{
		SecondsCounter secondsCounter = this.@Ӕ;
		secondsCounter.TimeOver = (Action)Delegate.Remove(secondsCounter.TimeOver, new Action(this.@Ә));
	}

	// Token: 0x04000031 RID: 49
	[SerializeField]
	private Pause @ӓ;

	// Token: 0x04000032 RID: 50
	[SerializeField]
	private SecondsCounter @Ӕ;

	// Token: 0x04000033 RID: 51
	[SerializeField]
	private PointsCounter @ӕ;

	// Token: 0x04000034 RID: 52
	[SerializeField]
	private GameObject @Ӗ;
}
