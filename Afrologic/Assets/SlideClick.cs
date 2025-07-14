using UnityEngine;
using UnityEngine.EventSystems;

public class SlideClick : MonoBehaviour, IPointerDownHandler
{
    public Transform a;
    public Transform b;

    Vector3 start_t, start_d;

    Collider2D tt = null, dd = null;

    static bool locker = false;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.frameCount);

        if (locker)
        {
            if (Time.frameCount % 30 == 0)
                locker = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        if (!locker)
        {
            locker = true;
            tt = null;

            Debug.Log("OnMouseDown happened!");

            tt = Physics2D.OverlapPoint(a.position);
            dd = Physics2D.OverlapPoint(b.position);


            if (tt != null && dd != null)
            {
                start_t = tt.transform.position;
                start_d = dd.transform.position;

                tt.gameObject.SendMessage("NewPoint", start_d);
                dd.gameObject.SendMessage("NewPoint", start_t);

            }
        }
    }
}
