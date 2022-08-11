using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_naruto : MonoBehaviour
{
    private Animator player;
    public float speed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SetBool("running", true);
            player.SetBool("Idle", false);
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) {
            player.SetBool("running", true);
            player.SetBool("Idle", false);
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
