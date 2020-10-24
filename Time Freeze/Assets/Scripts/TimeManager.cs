using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager instance;
    private void Awake()
    {
        instance = this;
    }
    public List<TimeUnit> Units= new List<TimeUnit>();

    public void RegistUnit(TimeUnit u)
    {
        Units.Add(u);
    }
    public event System.Action TimeFreezeEvent;
    public event System.Action TimeReleaseEvent;
    public bool IsTimeFreeze;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            IsTimeFreeze = !IsTimeFreeze;
            if (IsTimeFreeze)
            {
                TimeFreezeEvent();
            }
            else
            {
                TimeReleaseEvent();
            }
        }
    }
}
