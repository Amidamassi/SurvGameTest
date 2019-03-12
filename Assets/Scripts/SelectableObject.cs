using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    bool selected = false;
    GameObject selectParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if (!selected) {
            GameObject particle = Resources.Load<GameObject>("Particles/SelectedObject");
            particle.transform.position = gameObject.transform.position;
            ParticleSystem.ShapeModule shapeModule = particle.GetComponent<ParticleSystem>().shape;
            shapeModule.radius = gameObject.transform.lossyScale.x;
            selectParticle = Instantiate(particle);
            selected = true;
        } else {
            Destroy(selectParticle);
            selected = false;
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
