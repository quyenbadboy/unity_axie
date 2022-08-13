using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chon_nhanvat : MonoBehaviour
{
    // Start is called before the first frame update
    public  GameObject nv1, nv2, nv3, nv4, nv5,nv6, nv7;
    static float posNhanVat;
    void Start()
    {
        posNhanVat = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(posNhanVat == 1)
        {
            nv1.SetActive(true);
            nv2.SetActive(false);
            nv3.SetActive(false);
            nv4.SetActive(false);
            nv5.SetActive(false);
            nv6.SetActive(false);
            nv7.SetActive(false);
        }
        else if(posNhanVat == 2)
        {
            nv1.SetActive(false);
            nv2.SetActive(true);
            nv3.SetActive(false);
            nv4.SetActive(false);
            nv5.SetActive(false);
            nv6.SetActive(false);
            nv7.SetActive(false);
        }
        else if(posNhanVat == 3)
        {
            nv1.SetActive(false);
            nv2.SetActive(false);
            nv3.SetActive(true);
            nv4.SetActive(false);
            nv5.SetActive(false);
            nv6.SetActive(false);
            nv7.SetActive(false);
        }
        else if(posNhanVat == 4)
        {
            nv1.SetActive(false);
            nv2.SetActive(false);
            nv3.SetActive(false);
            nv4.SetActive(true);
            nv5.SetActive(false);
            nv6.SetActive(false);
            nv7.SetActive(false);
        }
        else if(posNhanVat == 5)
        {
            nv1.SetActive(false);
            nv2.SetActive(false);
            nv3.SetActive(false);
            nv4.SetActive(false);
            nv5.SetActive(true);
            nv6.SetActive(false);
            nv7.SetActive(false);
        }
        else if(posNhanVat == 6)
        {
            nv1.SetActive(false);
            nv2.SetActive(false);
            nv3.SetActive(false);
            nv4.SetActive(false);
            nv5.SetActive(false);
            nv6.SetActive(true);
            nv7.SetActive(false);
        }
        else if (posNhanVat == 7)
        {
            nv1.SetActive(false);
            nv2.SetActive(false);
            nv3.SetActive(false);
            nv4.SetActive(false);
            nv5.SetActive(false);
            nv6.SetActive(false);
            nv7.SetActive(true);
        }
    }

    public void btn_trai_changeNV()
    {
        if(posNhanVat <= 1)
        {
            posNhanVat = 7;
        }
        else
        {
            posNhanVat -= 1;
        }
        Debug.Log(posNhanVat);
    }

    public void btn_phai_changeNV()
    {
        if (posNhanVat >= 7)
        {
            posNhanVat = 1;
        }
        else
        {
            posNhanVat += 1;
        }
        Debug.Log(posNhanVat);

    }

    //fagasgasgasgdfgdfgdf
    //    sdfsdfsfs
}
