using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class LoseView : MonoBehaviour
{
	// Token: 0x0600004F RID: 79 RVA: 0x0000294A File Offset: 0x00000B4A
	private void Awake()
	{
		Item<Asteroid>.Grabed += new Action(this.@Ә);
		SecondsCounter secondsCounter = this.@Ӕ;
		secondsCounter.TimeOver = (Action)Delegate.Combine(secondsCounter.TimeOver, new Action(this.@ә));
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002986 File Offset: 0x00000B86
	private void @Ә()
	{
		this.@Ӗ.SetActive(true);
		this.@ӓ.Enable();
	}

	// Token: 0x06000051 RID: 81 RVA: 0x000029A4 File Offset: 0x00000BA4
	private void @ә()
	{
		bool flag = !this.@ӕ.IsAllCollected;
		if (flag)
		{
			this.@Ә();
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000029CD File Offset: 0x00000BCD
	private void OnDestroy()
	{
		Item<Asteroid>.Grabed -= new Action(this.@Ә);
		SecondsCounter secondsCounter = this.@Ӕ;
		secondsCounter.TimeOver = (Action)Delegate.Remove(secondsCounter.TimeOver, new Action(this.@ә));
	}

	// Token: 0x0400002B RID: 43
	[SerializeField]
	private Pause @ӓ;

	// Token: 0x0400002C RID: 44
	[SerializeField]
	private SecondsCounter @Ӕ;

	// Token: 0x0400002D RID: 45
	[SerializeField]
	private PointsCounter @ӕ;

	// Token: 0x0400002E RID: 46
	[SerializeField]
	private GameObject @Ӗ;
}
