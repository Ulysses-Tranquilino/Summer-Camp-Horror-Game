using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MaterialControl : MonoBehaviour
{
    public GameObject parentObject;
    private MeshRenderer meshRenderer;
    public Material transparentMaterial;
    private Material originalMaterial;
    private bool materialEnabled = true;

    void Start()
    {
        parentObject = transform.parent.gameObject;
        meshRenderer = parentObject.GetComponent<MeshRenderer>();
        originalMaterial = meshRenderer.materials[1];
    }
    
    void Update()
    {
        DisableMaterial();
    }
    
    public void DisableMaterial()
    {
        Material[] materials = meshRenderer.materials;
        materials[1] = transparentMaterial;
        meshRenderer.materials = materials;
    }

    public void EnableMaterial()
    {
        Material[] materials = meshRenderer.materials;
        materials[1] = originalMaterial;
        meshRenderer.materials = materials;
    }
}