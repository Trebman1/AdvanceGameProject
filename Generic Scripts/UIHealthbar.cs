using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthbar : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public Image foreground;
    public Image background;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Camera.main.WorldToScreenPoint(target.position + offset);

    }

    public void ShowHealthBarPercentage(float percent){
        float pareWidth = GetComponent<RectTransform>().rect.width;
        float width = pareWidth * percent;
        foreground.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
    }
}
