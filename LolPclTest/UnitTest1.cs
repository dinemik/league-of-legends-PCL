using System;
using LolPcl.Class;
using LolPcl.Class.enums;
using LolPcl.Class.Json;
using LolPcl.Class.WebClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LolPclTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayerInfo()
        {
            Player t = new Player();
            Assert.AreEqual(t.GetPlayerInfo("Dinemik", Regions.EUN1).Name, "Dinemik");
        }

        [TestMethod]
        public void MathInfo()
        {
            Player t = new Player();
            var accid = t.GetPlayerInfo("Dinemik", Regions.EUN1).AccountId;
            Assert.AreEqual(t.GetMarhInfo(accid, Regions.EUN1).EndIndex, 5);
        }

        [TestMethod]
        public void AccProfile()
        {
            Player t = new Player();
            Assert.AreEqual(t.GetProfileImg("Dinemik"), @"https://avatar.leagueoflegends.com/EUN1/Dinemik.png");
        }

        [TestMethod]
        public void PlayerInfoNotFound()
        {
            Player t = new Player();
            try
            {
                var player = t.GetPlayerInfo("a", Regions.EUN1).Name;
                Assert.AreEqual(player, "a");
            }
            catch (Exception ex)
            {
                if (ex.Message == "The remote server returned an error: (404) Not Found.")
                    Assert.AreEqual(true, true);
            }
        }
    }
}
