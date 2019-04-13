using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
        float height = Screen.height;
        float width = Screen.width;
        //RectTransform rt = (RectTransform)this.transform;
        RectTransform rt = GetComponent<RectTransform>();
        Rect rect = rt.rect;
        //CanvasScaler canvasScaler = GetComponentInParent<CanvasScaler>();
        //mousePos =

        Vector2 relativeMousePos = mousePos - (Vector2)rt.position;
        Vector2 normalizedMousePos = new Vector2(relativeMousePos.x / rt.rect.width, relativeMousePos.y / rt.rect.height);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("M: " + mousePos);
            Debug.Log("Mr: " + relativeMousePos);
            //Debug.Log(localPoint);
            Debug.Log("R: " + rt.position + ", " + rt.rect);
            Debug.Log("N: " + normalizedMousePos);
            GetNote(normalizedMousePos.x, normalizedMousePos.y);
        }
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


    //private static bool GetLocalMouse(RectTransform rt, out Vector2 result)
    //{
    //    Vector2 mousePosition;
    //    RectTransformUtility.ScreenPointToLocalPointInRectangle(rt, Input.mousePosition, Camera.main, out mousePosition);
    //    result.x = Mathf.Clamp(mousePosition.x, rt.rect.min.x, rt.rect.max.x);
    //    result.y = Mathf.Clamp(mousePosition.y, rt.rect.min.y, rt.rect.max.y);
    //    //Debug.Log(rt.rect.Contains(mousePosition));
    //    return rt.rect.Contains(mousePosition);
    //}

    //public static Rect RectTransformToScreenSpace(RectTransform transform)
    //{
    //    Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
    //    float x = transform.position.x + transform.anchoredPosition.x;
    //    float y = Screen.height - transform.position.y - transform.anchoredPosition.y;
    //    return new Rect(x, y, size.x, size.y);
    //}
}
