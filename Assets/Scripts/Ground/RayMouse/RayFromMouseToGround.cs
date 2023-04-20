using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayFromMouseToGround : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mouseWorldPos, Vector2.zero);
            /* 
            ! Lỗi nằm ở GetComponent<Tilemap>
            ? Nên thay bằng gì
            * T đã thử thay những cái khác như Ground thì ko được. Nhưng cái tên class trong Ground thì được
             */
            if (hit.collider != null && hit.collider.gameObject.GetComponent<Tilemap>() != null)
            {
                Tilemap clickedTilemap = hit.collider.gameObject.GetComponent<Tilemap>();
                Debug.Log("Tilemap clicked: " + clickedTilemap.name);
            }
        }
    }

}
