using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_HeavyUnit : TimeUnit
{
 
    public override void SetPosition(Vector3 position)
    {
        position.y = transform.position.y;
        transform.position = position;
    }
}
