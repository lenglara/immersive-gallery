using System;
using UnityEngine;

namespace Trabbant
{
    public class Breakable : MonoBehaviour
    {

        [SerializeField] GameObject intactWall;
        [SerializeField] GameObject brokenWall;

        private BoxCollider _boxCollider;
        // Update is called once per frame
        private void Awake()
        {
            intactWall.SetActive(true);
            brokenWall.SetActive(false);
        
            _boxCollider = GetComponent<BoxCollider>();
        }

        private void OnMouseDown()
        {
            Break();
        }

        private void Start()
        {
            WaitForSeconds wait = new WaitForSeconds(1f);
            Break();
        }

        private void Break()
        {
            intactWall.SetActive(false);
            brokenWall.SetActive(true);
            _boxCollider.enabled = false;
        }
    
    }
}
