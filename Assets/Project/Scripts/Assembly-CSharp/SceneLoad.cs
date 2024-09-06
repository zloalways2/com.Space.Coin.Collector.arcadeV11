using System;
using UnityEngine.SceneManagement;

// Token: 0x0200001C RID: 28
public static class SceneLoad
{
	// Token: 0x0600007F RID: 127 RVA: 0x00002E88 File Offset: 0x00001088
	public static void Restart()
	{
		Load(SceneManager.GetActiveScene().name);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002EA9 File Offset: 0x000010A9
	public static void Load(string name)
	{
		SceneManager.LoadScene(name);
	}
}
