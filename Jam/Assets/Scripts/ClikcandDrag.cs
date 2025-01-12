using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : ClickEvent
{
    bool selected = false;
    [SerializeField] bool yonly = false;
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) 
        {
            selected = false;
            Release();
        }
        if (selected)
        {
            FollowMouse();
        }
    }
    
    public virtual void Release()
    {

    }

    public void FollowMouse()
    {
        Vector3 pos  = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        
        if (yonly)
        {
            transform.position = new Vector3(transform.position.x, pos.y, 0);
        }
        else
        {
            transform.position = new Vector3(pos.x, pos.y, 0);
        }
        
    }

    public void OnSelected()
    {
        selected = true;
    }
}
