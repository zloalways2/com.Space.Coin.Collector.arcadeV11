using System;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class SecondsCounterView : TextView<int>
{
	// Token: 0x06000059 RID: 89 RVA: 0x00002A9C File Offset: 0x00000C9C
	private void OnEnable()
	{
		SecondsCounter secondsCounter = this.@ӓ;
		secondsCounter.Refreshed = (Action<int>)Delegate.Combine(secondsCounter.Refreshed, new Action<int>(base.UpdateText));
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002AF2 File Offset: 0x00000CF2
	private void Start()
	{
		base.UpdateText(this.@ӓ.Value);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002B1D File Offset: 0x00000D1D
	private void OnDisable()
	{
		SecondsCounter secondsCounter = this.@ӓ;
		secondsCounter.Refreshed = (Action<int>)Delegate.Remove(secondsCounter.Refreshed, new Action<int>(base.UpdateText));
	}

	// Token: 0x04000030 RID: 48
	[SerializeField]
	private SecondsCounter @ӓ;
}
