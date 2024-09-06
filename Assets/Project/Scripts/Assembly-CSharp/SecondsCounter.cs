using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200000E RID: 14
public class SecondsCounter : MonoBehaviour
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600003A RID: 58 RVA: 0x000026E3 File Offset: 0x000008E3
	// (set) Token: 0x0600003B RID: 59 RVA: 0x000026EB File Offset: 0x000008EB
	public int Value { get; private set; }

	// Token: 0x0600003C RID: 60 RVA: 0x000026F4 File Offset: 0x000008F4
	private void Awake()
	{
		base.StartCoroutine(this.@Ӗ());
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002704 File Offset: 0x00000904
	private IEnumerator @Ӗ()
	{
		this.Value = 30 + 30 * Level.Value / 4;
		while (this.Value > 0 && !Item<Asteroid>.IsGrabed)
		{
			yield return new WaitWhile(() => Pause.IsPaused);
			int value = this.Value;
			this.Value = value - 1;
			Action<int> refreshed = this.Refreshed;
			if (refreshed != null)
			{
				refreshed.Invoke(this.Value);
			}
			yield return new WaitForSecondsRealtime(1f);
		}
		Action timeOver = this.TimeOver;
		if (timeOver != null)
		{
			timeOver.Invoke();
		}
		Level.TryUnlockNext();
		yield break;
	}

	// Token: 0x04000020 RID: 32
	public Action<int> Refreshed;

	// Token: 0x04000021 RID: 33
	public Action TimeOver;

	// Token: 0x04000022 RID: 34
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int @ӓ;
}
