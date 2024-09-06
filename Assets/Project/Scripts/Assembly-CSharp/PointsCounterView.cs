using System;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class PointsCounterView : TextView<int>
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002A09 File Offset: 0x00000C09
	private void OnEnable()
	{
		PointsCounter pointsCounter = this.@ӓ;
		pointsCounter.Updated = (Action<int>)Delegate.Combine(pointsCounter.Updated, new Action<int>(this.@ӕ));
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002A33 File Offset: 0x00000C33
	private void @ӕ(int @ӓ)
	{
		base.UpdateText(@ӓ, this.@ӓ.TargetValue);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002A49 File Offset: 0x00000C49
	private void Start()
	{
		base.UpdateText(this.@ӓ.Value, this.@ӓ.TargetValue);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002A69 File Offset: 0x00000C69
	private void OnDisable()
	{
		PointsCounter pointsCounter = this.@ӓ;
		pointsCounter.Updated = (Action<int>)Delegate.Remove(pointsCounter.Updated, new Action<int>(this.@ӕ));
	}

	// Token: 0x0400002F RID: 47
	[SerializeField]
	private PointsCounter @ӓ;
}
