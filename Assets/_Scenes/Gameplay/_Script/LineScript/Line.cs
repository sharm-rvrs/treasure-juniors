using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{

    Vector2 pointer;
    Vector2 test;
    [SerializeField] private float speed = 20f;
    public GameObject target;
    [SerializeField] private float add;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(target.transform.position, transform.position);
        pointer = target.transform.position;
        
            Transform pointer2 = target.transform;
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(dist*add, this.GetComponent<RectTransform>().sizeDelta.y);

            Vector2 direction = pointer2.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);

        










    }

   

}
