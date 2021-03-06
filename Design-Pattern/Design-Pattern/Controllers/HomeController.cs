﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Design_Pattern.Models.Singleton;
using Design_Pattern.Models.Facade;
using Design_Pattern.Models.Factory_Method;
using Design_Pattern.Models.Builder;
using Design_Pattern.Models.Abstract_Factory;

namespace Design_Pattern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            #region Singleton
            Singleton.getInstance().userID = "180001";
            Singleton.getInstance().userPwd = "Pwd18001";
            Singleton.getInstance().userName = "User 18001";
            string userID = Singleton.getInstance().userID;
            string userPwd = Singleton.getInstance().userPwd;
            string userName = Singleton.getInstance().userName;
            #endregion

            #region Facade
            BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
            string ResultFacade = string.Empty;

            ResultFacade += accessingBank.withdrawCash(50.00);

            ResultFacade += accessingBank.withdrawCash(900.00);

            ResultFacade += accessingBank.depositCash(200.00);
            #endregion

            #region Factory Method

            EnemyShipFactory shipFactory = new EnemyShipFactory();
            EnemyShip theEnemy = null;
            theEnemy = shipFactory.makeEnemyShip("B");
            string resultFac = doStuffEnemy(theEnemy);


            #endregion

            #region Abstract Factory

            string resultAbstractFac = AbstractFactory.MainFn();

            #endregion

            #region Builder

            RobotBuilder oldStyleRobot = new OldRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);
            robotEngineer.makeRobot();
            Robot firstRobot = robotEngineer.getRobot();
            string resultBuilder = string.Empty;
            resultBuilder += firstRobot.getRobotHead() + "\n";
            resultBuilder += firstRobot.getRobotTorso() + "\n";
            resultBuilder += firstRobot.getRobotArms() + "\n";
            resultBuilder += firstRobot.getRobotLegs() + "\n";

            RobotBuilder newStyleRobot = new NewRobotBuilder();
            RobotEngineer robotEngineerNew = new RobotEngineer(newStyleRobot);
            robotEngineerNew.makeRobot();
            Robot secondRobot = robotEngineerNew.getRobot();
            string resultBuilderNew = string.Empty;
            resultBuilderNew += secondRobot.getRobotHead() + "\n";
            resultBuilderNew += secondRobot.getRobotTorso() + "\n";
            resultBuilderNew += secondRobot.getRobotArms() + "\n";
            resultBuilderNew += secondRobot.getRobotLegs() + "\n";
            #endregion

            #region State

            #endregion



            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application. <br />User ID : " 
                + userID + " <br />User Pwd : " + userPwd + " <br />User Name : " + userName;

            return View();
        }

        public static string doStuffEnemy(EnemyShip anEnemyShip)
        {
            string ret = "";
            ret += anEnemyShip.followHeroShip();
            ret += anEnemyShip.displayEnemyShip();
            ret += anEnemyShip.enemyShipShoots();
            return ret;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
