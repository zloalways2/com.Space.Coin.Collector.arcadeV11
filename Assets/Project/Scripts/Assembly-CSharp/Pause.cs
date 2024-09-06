using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class Pause : MonoBehaviour
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x0600001F RID: 31 RVA: 0x00002460 File Offset: 0x00000660
	// (remove) Token: 0x06000020 RID: 32 RVA: 0x00002494 File Offset: 0x00000694
	public static event Action Enabled
	{
		[CompilerGenerated]
		add
		{
			Action action = Pause.@ӓ;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Pause.@ӓ, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = Pause.@ӓ;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Pause.@ӓ, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000021 RID: 33 RVA: 0x000024C8 File Offset: 0x000006C8
	// (remove) Token: 0x06000022 RID: 34 RVA: 0x000024FC File Offset: 0x000006FC
	public static event Action Disabled
	{
		[CompilerGenerated]
		add
		{
			Action action = Pause.@Ӕ;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Pause.@Ӕ, action3, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = Pause.@Ӕ;
			Action action2;
			do
			{
				action2 = action;
				Action action3 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action>(ref Pause.@Ӕ, action3, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000023 RID: 35 RVA: 0x0000252F File Offset: 0x0000072F
	// (set) Token: 0x06000024 RID: 36 RVA: 0x00002536 File Offset: 0x00000736
	public static bool IsPaused { get; private set; }

	// Token: 0x06000025 RID: 37 RVA: 0x0000253E File Offset: 0x0000073E
	public void Enable()
	{
		Pause.IsPaused = true;
		Action action = Pause.@ӓ;
		if (action != null)
		{
			action.Invoke();
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002559 File Offset: 0x00000759
	public void Disable()
	{
		Pause.IsPaused = false;
		Action action = Pause.@Ӕ;
		if (action != null)
		{
			action.Invoke();
		}
	}

	// Token: 0x04000015 RID: 21
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action @ӓ;

	// Token: 0x04000016 RID: 22
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action @Ӕ;

	// Token: 0x04000017 RID: 23
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool @ӕ;
}
