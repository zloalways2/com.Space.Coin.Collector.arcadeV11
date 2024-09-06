using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200001E RID: 30
[RequireComponent(typeof(Button))]
public abstract class ButtonListener : UIListener
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000083 RID: 131 RVA: 0x00002EBC File Offset: 0x000010BC
	// (set) Token: 0x06000084 RID: 132 RVA: 0x00002EC4 File Offset: 0x000010C4
	protected Button Button { get; private set; }

	// Token: 0x06000085 RID: 133 RVA: 0x000020D2 File Offset: 0x000002D2
	protected virtual void OnInitialized()
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002ECD File Offset: 0x000010CD
	private void Start()
	{
		this.Button = base.GetComponent<Button>();
		this.Button.onClick.AddListener(new UnityAction(this.Handle));
		this.OnInitialized();
	}
}
