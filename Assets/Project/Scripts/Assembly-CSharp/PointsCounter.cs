using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class PointsCounter : MonoBehaviour
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002574 File Offset: 0x00000774
	// (set) Token: 0x06000029 RID: 41 RVA: 0x0000257C File Offset: 0x0000077C
	public int Value { get; private set; }

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002585 File Offset: 0x00000785
	public int TargetValue
	{
		get
		{
			return 12 * Level.Value;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002B RID: 43 RVA: 0x0000258F File Offset: 0x0000078F
	public bool IsAllCollected
	{
		get
		{
			return this.Value >= this.TargetValue;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000025A2 File Offset: 0x000007A2
	private void Awake()
	{
		this.Value = 0;
		Item<Point>.Grabed += new Action(this.@Ӗ);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x000025C0 File Offset: 0x000007C0
	private void @Ӗ()
	{
		int value = this.Value;
		this.Value = value + 1;
		Action<int> updated = this.Updated;
		if (updated != null)
		{
			updated.Invoke(this.Value);
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x000025F7 File Offset: 0x000007F7
	private void OnDestroy()
	{
		Item<Point>.Grabed -= new Action(this.@Ӗ);
	}

	// Token: 0x04000018 RID: 24
	public Action<int> Updated;

	// Token: 0x04000019 RID: 25
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int @ӓ;
}
