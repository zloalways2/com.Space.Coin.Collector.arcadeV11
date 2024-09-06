using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

// Token: 0x02000003 RID: 3
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public abstract class Item<T> : MonoBehaviour where T : Item<T>
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
	// (remove) Token: 0x06000003 RID: 3 RVA: 0x00002090 File Offset: 0x00000290
	
	public static event Action Grabed;

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000004 RID: 4 RVA: 0x000020C3 File Offset: 0x000002C3
	// (set) Token: 0x06000005 RID: 5 RVA: 0x000020CA File Offset: 0x000002CA
	public static bool IsGrabed { get; private set; }

	// Token: 0x06000006 RID: 6 RVA: 0x000020D2 File Offset: 0x000002D2
	protected virtual void HandleStarShipContacted()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020D8 File Offset: 0x000002D8
	private void Start()
	{
		this._rigidbody = base.GetComponent<Rigidbody2D>();
		this._rigidbody.gravityScale = 0f;
		this.Respawn();
		Pause.Enabled += new Action(this.PauseMovement);
		Pause.Disabled += new Action(this.ResumeMovement);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002130 File Offset: 0x00000330
	private void OnTriggerEnter2D(Collider2D collision)
	{
		StarShip starShip;
		bool flag = collision.TryGetComponent<StarShip>(out starShip);
		if (flag)
		{
			Action grabed = Item<T>.Grabed;
			if (grabed != null)
			{
				grabed.Invoke();
			}
			Item<T>.IsGrabed = true;
			this.HandleStarShipContacted();
		}
		else
		{
			ItemBorder itemBorder;
			bool flag2 = collision.TryGetComponent<ItemBorder>(out itemBorder);
			if (flag2)
			{
				this.Respawn();
			}
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002182 File Offset: 0x00000382
	private void PauseMovement()
	{
		this._velocity = this._rigidbody.velocity;
		this._rigidbody.velocity = Vector2.zero;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000021A7 File Offset: 0x000003A7
	private void ResumeMovement()
	{
		this._rigidbody.velocity = this._velocity;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000021BC File Offset: 0x000003BC
	protected void Respawn()
	{
		Item<T>.IsGrabed = false;
		float num = Random.Range(-this._xAmplitude, this._xAmplitude);
		base.transform.localPosition = Vector3.right * num;
		this._rigidbody.velocity = Vector2.zero;
		base.StartCoroutine(this.RespawnCoroutine());
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002219 File Offset: 0x00000419
	private IEnumerator RespawnCoroutine()
	{
		float randomDelay = Random.Range(this._minRespawnDelay, this._maxRespawnDelay);
		WaitForSecondsRealtime wait = new WaitForSecondsRealtime(randomDelay);
		yield return wait;
		float speed = Random.Range(this._minFallingSpeed, this._maxFallingSpeed);
		this._rigidbody.velocity = Vector2.down * speed;
		yield break;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002228 File Offset: 0x00000428
	private void OnDestroy()
	{
		Pause.Enabled -= new Action(this.PauseMovement);
		Pause.Disabled -= new Action(this.ResumeMovement);
	}

	// Token: 0x04000001 RID: 1
	private const float ZeroGravityValue = 0f;

	// Token: 0x04000003 RID: 3
	[SerializeField]
	[Min(0f)]
	private float _minFallingSpeed = 1f;

	// Token: 0x04000004 RID: 4
	[SerializeField]
	[Min(0.1f)]
	private float _maxFallingSpeed = 2f;

	// Token: 0x04000005 RID: 5
	[Min(0f)]
	[SerializeField]
	private float _minRespawnDelay = 1f;

	// Token: 0x04000006 RID: 6
	[Min(0.1f)]
	[SerializeField]
	private float _maxRespawnDelay = 2f;

	// Token: 0x04000007 RID: 7
	[Min(0.1f)]
	[SerializeField]
	private float _xAmplitude = 1f;

	// Token: 0x04000008 RID: 8
	private Rigidbody2D _rigidbody;

	// Token: 0x04000009 RID: 9
	private Vector2 _velocity;
}
