using System;
using UnityEngine;

// Token: 0x02000018 RID: 24
[RequireComponent(typeof(AudioSource))]
public abstract class Audio<T> : MonoBehaviour where T : Audio<T>
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000067 RID: 103 RVA: 0x00002D42 File Offset: 0x00000F42
	// (set) Token: 0x06000068 RID: 104 RVA: 0x00002D49 File Offset: 0x00000F49
	public static T StaticInstance { get; private set; }

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000069 RID: 105
	protected abstract string SaveKey { get; }

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600006A RID: 106
	protected abstract bool PlayOnAwake { get; }

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600006B RID: 107
	protected abstract bool Loop { get; }

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600006C RID: 108 RVA: 0x00002D51 File Offset: 0x00000F51
	// (set) Token: 0x0600006D RID: 109 RVA: 0x00002D59 File Offset: 0x00000F59
	protected AudioSource Source { get; private set; }

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00002D62 File Offset: 0x00000F62
	public bool IsMuted
	{
		get
		{
			return this.Source.mute;
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002D70 File Offset: 0x00000F70
	private void Awake()
	{
		this.Source = base.GetComponent<AudioSource>();
		this.Source.playOnAwake = this.PlayOnAwake;
		this.Source.loop = this.Loop;
		this.Source.volume = 0.5f;
		bool flag = PlayerPrefs.GetInt(this.SaveKey, 0) == 1;
		bool flag2 = flag;
		if (flag2)
		{
			this.Mute();
		}
		else
		{
			this.UnMute();
		}
		StaticInstance = FindObjectOfType<T>();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002DF0 File Offset: 0x00000FF0
	public void Mute()
	{
		this.Source.mute = true;
		this.SaveState();
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002E07 File Offset: 0x00001007
	public void UnMute()
	{
		this.Source.mute = false;
		this.SaveState();
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002E1E File Offset: 0x0000101E
	private void SaveState()
	{
		PlayerPrefs.SetInt(this.SaveKey, this.Source.mute ? 1 : 0);
	}
}
