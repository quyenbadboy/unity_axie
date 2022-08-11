using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-0.0997598f, 0.09536446f, 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(0.0997598f, 0.09536446f, 1f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
                transform.Translate(0, Time.deltaTime * 5, 0);
                transform.localScale = new Vector3(0.0997598f, 0.09536446f, 3f);
            }
        }
       
    }

