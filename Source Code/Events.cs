using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bl4ckdev {
    public class Events : MonoBehaviour
    {
        protected bool lf;

        protected private void UpdateEvents()
        {
            if (EventManager.IsPointerOverUIElement(gameObject))
            {
                Over();
                
                lf = true;
                if (Input.GetMouseButtonDown(0)) Down();
                if (Input.GetMouseButtonUp(0)) Up();
                if (Input.GetMouseButton(0)) Hold();
            }
            else if (lf)
            {
                lf = false;
                Exit();
            }
        }

        public virtual void Hold() { }
        public virtual void Exit() { }
        public virtual void Over() { }
        public virtual void Down() { }
        public virtual void Up() { }
    }
}