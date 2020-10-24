using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Camera cam;
    Vector2 MousePosition;
    Vector2 DeltaMousePosition;
    private void Start()
    {
        cam = Camera.main;
    }
    public TimeUnit selectUnit;
    void Update()
    {
        //Converting Mouse Pos to 2D (vector2) World Pos
        Vector2 newPos = cam.ScreenToWorldPoint(Input.mousePosition);
        DeltaMousePosition = newPos - MousePosition;
        MousePosition = newPos;

        if (!Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit)
            {
                TimeUnit u = hit.collider.GetComponent<TimeUnit>();
                selectUnit = u;
            }
            else
            {
                selectUnit = null;
            }
        }

        if (selectUnit && Input.GetMouseButton(0))
        {
            selectUnit.SetPosition((Vector3)MousePosition);
        }
    }

}
