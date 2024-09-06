using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000026 RID: 38
[RequireComponent(typeof(Toggle))]
public abstract class ToggleListener : UIListener
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600009D RID: 157 RVA: 0x00003075 File Offset: 0x00001275
	// (set) Token: 0x0600009E RID: 158 RVA: 0x0000307D File Offset: 0x0000127D
	protected Toggle Toggle { get; private set; }

	// Token: 0x0600009F RID: 159 RVA: 0x000020D2 File Offset: 0x000002D2
	protected virtual void Handle(bool value)
	{
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x000020D2 File Offset: 0x000002D2
	protected virtual void HandleSubscribed()
	{
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00003088 File Offset: 0x00001288
	private void Start()
	{
		this.Toggle = base.GetComponent<Toggle>();
		this.Toggle.onValueChanged.AddListener(new UnityAction<bool>(this.@Ӗ));
		this.Toggle.onValueChanged.AddListener(new UnityAction<bool>(this.Handle));
		this.HandleSubscribed();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000030E5 File Offset: 0x000012E5
	[CompilerGenerated]
	private void @Ӗ(bool @ӓ)
	{
		this.Handle();
	}

	// Token: 0x0400003F RID: 63
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Toggle @ӓ;
}
