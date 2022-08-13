using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_player_1 : MonoBehaviour
{
    // Start is called before the first frame update
    bool isNen_dat;
    public GameObject skill;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(-0.2f, 0.2f, 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Time.deltaTime * 5, 0, 0);
            transform.localScale = new Vector3(0.2f, 0.2f, 1f); 
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isNen_dat)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                isNen_dat = false;
            }
            
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
            Debug.Log(thanh_mana.time_addmana);

            if (thanh_mana.time_addmana >= 100)
            {
                Instantiate(skill, new Vector2(transform.localPosition.x, transform.localPosition.y + 1), transform.localRotation);
                thanh_mana.time_addmana = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "map" || collision.gameObject.tag == "cuc_da")
        {
            isNen_dat = true;
        }
    }

}

