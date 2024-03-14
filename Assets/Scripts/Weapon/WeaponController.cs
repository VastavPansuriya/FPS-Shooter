using UnityEngine;

namespace FPSShooter.Weapon
{
    public class WeaponController
    {
        private Weapon weapon;
        private WeaponView weaponView;
        private WeaponModel weaponModel;
        public WeaponController(WeaponModel model)
        {
            weaponModel = model;
            weapon = new Knife.KnifeWeapon();
        }
        public void InitView()
        {
            weaponView = Object.Instantiate(weaponModel.WeaponSO.WeaponView);
            weaponView.SetController(this);
        }
    }
}
