using System;

// Token: 0x02000006 RID: 6
public class Point : Item<Point>
{
	// Token: 0x06000016 RID: 22 RVA: 0x0000237A File Offset: 0x0000057A
	protected override void HandleStarShipContacted()
	{
		base.Respawn();
	}
}
