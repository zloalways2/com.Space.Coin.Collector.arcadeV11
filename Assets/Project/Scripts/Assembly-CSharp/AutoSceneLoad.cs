using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class AutoSceneLoad : MonoBehaviour
{
	// Token: 0x0600007D RID: 125 RVA: 0x00002E77 File Offset: 0x00001077
	private void Awake()
	{
		SceneLoad.Load(this.@ӓ);
	}

	// Token: 0x0400003A RID: 58
	[SerializeField]
	private string @ӓ;
}
