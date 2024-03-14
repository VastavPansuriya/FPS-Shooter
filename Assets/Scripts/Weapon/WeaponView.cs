using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FPSShooter.Weapon
{
    public class WeaponView : MonoBehaviour
    {
        private WeaponController weaponController;
        public void SetController(WeaponController controller)
        {
            this.weaponController = controller;
        }
        public void SetPosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}
