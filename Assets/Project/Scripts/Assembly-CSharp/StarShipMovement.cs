using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
[RequireComponent(typeof(Rigidbody2D))]
public class StarShipMovement : MonoBehaviour
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002654 File Offset: 0x00000854
	private void Awake()
	{
		this.@Ӕ = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002664 File Offset: 0x00000864
	public void Move(float xDirection)
	{
		bool isPaused = Pause.IsPaused;
		if (!isPaused)
		{
			bool flag = this.@Ӕ == null;
			if (!flag)
			{
				Vector2 position = this.@Ӕ.position;
				Vector2 vector = Vector2.right * xDirection * this.@ӓ * Time.deltaTime;
				this.@Ӕ.MovePosition(position + vector);
			}
		}
	}

	// Token: 0x0400001B RID: 27
	[SerializeField]
	[Min(0.1f)]
	private float @ӓ = 1f;

	// Token: 0x0400001C RID: 28
	private Rigidbody2D @Ӕ;
}
