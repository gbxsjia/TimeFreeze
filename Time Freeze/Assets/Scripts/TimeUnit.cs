using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUnit : MonoBehaviour
{
    protected Rigidbody2D rb;
    protected Vector2 velocity;
    float angularVelocity;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    protected virtual void Start()
    {
        TimeManager.instance.RegistUnit(this);
        TimeManager.instance.TimeFreezeEvent += OnTimeFreeze;
        TimeManager.instance.TimeReleaseEvent += OnTimeRelease;
    }

    private void OnTimeRelease()
    {
        rb.isKinematic = false;
        rb.velocity = velocity;
        rb.angularVelocity = angularVelocity;

    }

    protected virtual void OnTimeFreeze()
    {
        velocity = rb.velocity;
        angularVelocity = rb.angularVelocity;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
        rb.isKinematic = true;
    }

    public virtual void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}
