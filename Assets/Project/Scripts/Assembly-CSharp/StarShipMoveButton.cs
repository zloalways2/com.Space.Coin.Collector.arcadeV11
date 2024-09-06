using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000011 RID: 17
[RequireComponent(typeof(EventTrigger))]
public class StarShipMoveButton : MonoBehaviour
{
	// Token: 0x06000048 RID: 72 RVA: 0x00002878 File Offset: 0x00000A78
	private void Start()
	{
		EventTrigger component = base.GetComponent<EventTrigger>();
		EventTrigger.Entry entry = new EventTrigger.Entry();
		EventTrigger.Entry entry2 = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerDown;
		entry2.eventID = EventTriggerType.PointerUp;
		entry.callback.AddListener(new UnityAction<BaseEventData>(this.@Ӛ));
		entry2.callback.AddListener(new UnityAction<BaseEventData>(this.@ӛ));
		component.triggers.Add(entry);
		component.triggers.Add(entry2);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000028F4 File Offset: 0x00000AF4
	private void Update()
	{
		bool flag = !this.@ӕ;
		if (!flag)
		{
			this.@ӓ.Move((float)this.@Ӕ);
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002924 File Offset: 0x00000B24
	private void @Ә()
	{
		this.@ӕ = true;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000292E File Offset: 0x00000B2E
	private void @ә()
	{
		this.@ӕ = false;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002938 File Offset: 0x00000B38
	[CompilerGenerated]
	private void @Ӛ(BaseEventData @ӓ)
	{
		this.@Ә();
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002941 File Offset: 0x00000B41
	[CompilerGenerated]
	private void @ӛ(BaseEventData @ӓ)
	{
		this.@ә();
	}

	// Token: 0x04000028 RID: 40
	[SerializeField]
	private StarShipMovement @ӓ;

	// Token: 0x04000029 RID: 41
	[SerializeField]
	private StartShipMovementDirection @Ӕ;

	// Token: 0x0400002A RID: 42
	private bool @ӕ;
}
