using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;
using UnityEngine.UIElements;
using Oculus.Interaction;
using Oculus.Interaction.HandGrab;

public class SliceObject : MonoBehaviour
{
    public Transform startSlicePoint;
    public Transform endSlicePoint;
    public VelocityEstimator velocityEstimator;
    public LayerMask sliceableLayer;

    public GameObject sliceObjects;

    public Material crossSectionMaterial;
    public float cutForce = 2000;

    private int cutCnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        cutCnt = 0;
        sliceObjects.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool hasHit = Physics.Linecast(startSlicePoint.position, endSlicePoint.position, out RaycastHit hit, sliceableLayer);
        if(hasHit)
        {
            GameObject target = hit.transform.gameObject;
            if(cutCnt < 3)
            {
                Slice(target);
                cutCnt++;
            } else
            {
                GameObject[] sliced = GameObject.FindGameObjectsWithTag("Slice");

                for(int i=0; i<sliced.Length; i++)
                {
                    Destroy(sliced[i]);
                }

                sliceObjects.SetActive(true);

            }
           
        }
    }

    public void Slice(GameObject target)
    {
        Vector3 velocity = velocityEstimator.GetVelocityEstimate();
        Vector3 planeNormal = Vector3.Cross(endSlicePoint.position - startSlicePoint.position, velocity);
        planeNormal.Normalize();

        SlicedHull hull = target.Slice(endSlicePoint.position, planeNormal);

        if(hull != null)
        {
            GameObject upperHull = hull.CreateUpperHull(target, crossSectionMaterial);
            SetupSlicedComponent(upperHull);
            //upperHull.transform.SetParent(sliceObjects.transform, true);

            GameObject lowerHull = hull.CreateLowerHull(target, crossSectionMaterial);
            SetupSlicedComponent(lowerHull);
            //lowerHull.transform.SetParent(sliceObjects.transform, true);

            Destroy(target);
        }
    }

    public void SetupSlicedComponent(GameObject slicedObject)
    {
        slicedObject.layer = 3;
        Rigidbody rb = slicedObject.AddComponent<Rigidbody>();
        
        MeshCollider collider = slicedObject.AddComponent<MeshCollider>();
        collider.convex = true;
        // rb.AddExplosionForce(cutForce, slicedObject.transform.position, 1);

        slicedObject.tag = "Slice";        
        
    }
}
