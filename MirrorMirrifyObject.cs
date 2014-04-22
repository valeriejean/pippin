using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class MirrorMirrifyObject : MonoBehaviour
{
    public GameObject objectBeforeMirror;
    public GameObject mirrorPlane;
    
    void Update ()
    {
        if (null != mirrorPlane) {
            if (null != objectBeforeMirror) {
                transform.position = objectBeforeMirror.transform.position;
                transform.rotation = objectBeforeMirror.transform.rotation;
 
                Vector3 positionInMirrorSpace = mirrorPlane.transform.InverseTransformPoint( objectBeforeMirror.transform.position );
                
                // move camera forward
                positionInMirrorSpace.y = -positionInMirrorSpace.y;
                positionInMirrorSpace.z = (positionInMirrorSpace.z)/2.5f;
                                
                transform.position = mirrorPlane.transform.TransformPoint( positionInMirrorSpace );
                
                /** object is now in correct position, but looking in parallel look direction to original */
                /* So, cast a ray from the original object along look-direction until you hit the plane,
                 * then make the cloned object "look at" that position */
                Vector3 mirrorsNormal = mirrorPlane.transform.localRotation * new Vector3( 0f, 1, 0f ); // Unity planes always start with normal pointing up
                Plane planeOfMirror = new Plane(  mirrorsNormal, mirrorPlane.transform.position );
                float intersectionDistance;
                Ray rayToMirror = new Ray( objectBeforeMirror.transform.position, objectBeforeMirror.transform.forward );
                planeOfMirror.Raycast( rayToMirror, out intersectionDistance );
                Vector3 hitPoint = rayToMirror.GetPoint( intersectionDistance );
                
                transform.LookAt( hitPoint );
            }
        }
    }
}