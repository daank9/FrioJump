using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Transform bg1;
    public Transform bg2;
    private float size;
    public Text scoreText;
    public Text FinalScore;


    void Start()
    {
        size = 9;
    }

    private void Update()
    {
        scoreText.text = ((int)(transform.position.y * 10)).ToString();
        FinalScore.text = ((int)(transform.position.y * 10)).ToString();
    }


    private void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
        }

        if(transform.position.y >= bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwitchBg();
        }
    }

    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
}
