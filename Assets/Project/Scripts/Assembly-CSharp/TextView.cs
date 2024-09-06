using System;
using TMPro;
using UnityEngine;

// Token: 0x02000022 RID: 34
public abstract class TextView<T> : MonoBehaviour
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600008E RID: 142 RVA: 0x00002F2C File Offset: 0x0000112C
	protected virtual T DefaultValue
	{
		get
		{
			return default(T);
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002F42 File Offset: 0x00001142
	protected void UpdateText(T value)
	{
		this._text.text = string.Format(this._stringFormat, value);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002F62 File Offset: 0x00001162
	protected void UpdateText(T value1, T value2)
	{
		this._text.text = string.Format(this._stringFormat, value1, value2);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002F88 File Offset: 0x00001188
	protected void UpdateText(T value1, T value2, T value3)
	{
		this._text.text = string.Format(this._stringFormat, value1, value2, value3);
	}

	// Token: 0x0400003D RID: 61
	[SerializeField]
	private TextMeshProUGUI _text;

	// Token: 0x0400003E RID: 62
	[SerializeField]
	private string _stringFormat = "{0}";
}
