using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer_try : MonoBehaviour
{
    [SerializeField] private LineRenderer line_renderer;
    [SerializeField] private Transform line_Start;
    [SerializeField] private Transform line_end;

    void Start()
    {
        line_renderer = GetComponent<LineRenderer>();
        line_renderer.SetWidth(1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        line_renderer.SetPosition(0, line_Start.position);
        line_renderer.SetPosition(1, line_end.position);

        
        line_renderer.SetWidth(20, 20);
    }
}
