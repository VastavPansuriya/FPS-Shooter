using FPSShooter.Player;
using FPSShooter.Weapon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FPSShooter.Main
{
    public class ServiceLocator 
    {
        private PlayerService playerService;
        private WeaponService weaponService;
        public ServiceLocator(ServiceLocatorModel data)
        {
            InitializeServices(data);
            InjectDependencies();
        }
        private void InitializeServices(ServiceLocatorModel data)
        {

            playerService = new PlayerService(data.PlayerModel);

        }

        private void InjectDependencies()
        {
           
        }
        public void Start()
        {
        }
        public void Update()
        {

        }
    }

}