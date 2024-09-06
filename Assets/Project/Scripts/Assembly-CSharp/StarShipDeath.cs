using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x0200000B RID: 11
[RequireComponent(typeof(StarShip))]
public class StarShipDeath : MonoBehaviour
{
	// Token: 0x06000032 RID: 50 RVA: 0x0000261B File Offset: 0x0000081B
	private void Awake()
	{
		Item<Asteroid>.Grabed += new Action(this.@ӕ);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002630 File Offset: 0x00000830
	private void OnDestroy()
	{
		Item<Asteroid>.Grabed -= new Action(this.@ӕ);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002645 File Offset: 0x00000845
	[CompilerGenerated]
	private void @ӕ()
	{
        Destroy(base.gameObject);
    }
}
