using System;
using TMPro;
using UnityEngine;

// Token: 0x02000017 RID: 23
public class LoadLevelButton : ButtonListener
{
	// Token: 0x06000063 RID: 99 RVA: 0x00002CA4 File Offset: 0x00000EA4
	protected override void OnInitialized()
	{
		base.Button.interactable = (Level.MaxUnlocked >= this.@ӓ);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002CC4 File Offset: 0x00000EC4
	protected override void Handle()
	{
		bool flag = Level.TrySetValue(this.@ӓ);
		if (flag)
		{
			SceneLoad.Load("Gameplay");
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002CF0 File Offset: 0x00000EF0
	private void OnValidate()
	{
		bool flag = this.@Ӕ != null;
		if (flag)
		{
			this.@Ӕ.text = string.Format(this.@ӕ, this.@ӓ);
		}
	}

	// Token: 0x04000035 RID: 53
	[SerializeField]
	[Range(1f, 15f)]
	private int @ӓ = 1;

	// Token: 0x04000036 RID: 54
	[SerializeField]
	private TextMeshProUGUI @Ӕ;

	// Token: 0x04000037 RID: 55
	[SerializeField]
	private string @ӕ;
}
