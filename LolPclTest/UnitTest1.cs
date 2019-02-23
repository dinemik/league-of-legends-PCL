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
            Player t = new Player("");
            Assert.AreEqual(t.GetPlayerInfoAsync("Dinemik", Regions.EUN1).Result.Name, "Dinemik");
        }

        [TestMethod]
        public void MathInfo()
        {
            Player t = new Player("");
            var accid = t.GetPlayerInfoAsync("Dinemik", Regions.EUN1).Result.AccountId;
            Assert.AreEqual(t.GetMarhInfoAsync(accid, Regions.EUN1).Result.EndIndex, 5);
        }

        [TestMethod]
        public void AccProfile()
        {
            Player t = new Player("");
            Assert.AreEqual(t.GetProfileImg("Dinemik"), @"https://avatar.leagueoflegends.com/EUN1/Dinemik.png");
        }

        [TestMethod]
        public void PlayerInfoNotFound()
        {
            Player t = new Player("");
            try
            {
                var player = t.GetPlayerInfoAsync("a", Regions.EUN1).Result.Name;
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
