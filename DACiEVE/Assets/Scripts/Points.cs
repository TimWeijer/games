using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TMP_Text points;
    public TMP_Text winText;
    public int maxPoints;
    public int pointcount;
    // Start is called before the first frame update
    void Start()
    {
        points.text = "Points: " + pointcount;
    }

    // Update is called once per frame
    public void UpdatePoints()
    {
        pointcount += 1;
        points.text = "Points: " + pointcount;

        if(pointcount >= maxPoints)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
