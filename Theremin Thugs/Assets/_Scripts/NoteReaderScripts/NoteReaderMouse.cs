using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class NoteReaderMouse : NoteReader, IPointerEnterHandler, IPointerExitHandler
{
    private bool isHoverOver;

    private void Update()
    {
        if (isHoverOver)
        {
            OnPointerHover();
        }
    }

    public void OnPointerHover()
    {
        Vector2 mousePos = Input.mousePosition;
        //Debug.Log(mousePos);
        int height = Screen.height;
        int width = Screen.width;

        RectTransform rt = (RectTransform)this.transform;
        Rect r = RectTransformToScreenSpace(rt);
        Vector2 normalizedMousePos = new Vector2(mousePos.x / r.width, mousePos.y / r.height);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("rt Transform: " + rt.transform);
            Debug.Log("Mouse Position: " + (normalizedMousePos));
        }
    }

    public static Rect RectTransformToScreenSpace(RectTransform transform)
    {
        Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
        float x = transform.position.x + transform.anchoredPosition.x;
        float y = Screen.height - transform.position.y - transform.anchoredPosition.y;
        return new Rect(x, y, size.x, size.y);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Enter");
        isHoverOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Exit");
        isHoverOver = false;
    }
}
