using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HolographicMapController : MonoBehaviour
{
    private VisualEffect _visualEffect;
    // Start is called before the first frame update
    void Start()
    {
        _visualEffect = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            _visualEffect.SendEvent("OnPlayMinMap");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            _visualEffect.SendEvent("OnStopMinMap");
            _visualEffect.SendEvent("OnPlayMaxMap");
        }
    }
}
