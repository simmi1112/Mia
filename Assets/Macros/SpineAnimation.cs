using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpineAnimation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;

        Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);

        RaycastHit2D hit = Physics2D.Raycast(screenPos, Vector2.zero);

        if (hit)
        {

        }
    }
}
