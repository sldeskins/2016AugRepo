using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.IO;

namespace CSharp_Lab2_Test
{
    [TestClass]
    public class AdventurGameTest
    {
        string ResponseForplayerName = "Sandy";
        //
        Assembly design;// =  Assembly.LoadFile(@"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.Design.dll");
        Type consoleAppType;
        MethodInfo mainMethod;

        public AdventurGameTest()
        {
            design = Assembly.Load("CSharp_Lab2");
            consoleAppType = design.GetType("CSharp_Lab2.Program");
            mainMethod = consoleAppType.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);
        }
        [TestMethod]
        public void TestMethod_shortestGame()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "n" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "The story has ended for you " + ResponseForplayerName + ", before it could begin. Until next time." + Environment.NewLine
                    ;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }

        [TestMethod]
        public void TestMethod_GameToFaceTheDragon()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "The story has ended for you " + ResponseForplayerName + ". You ran away from the dragon." + Environment.NewLine
                   ;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_FaceTheDragon_Not_FaceTheBeastResponse()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "na na na " + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "The story has ended for you " + ResponseForplayerName + ". You ran away from the dragon." + Environment.NewLine
                   ;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }

        [TestMethod]
        public void TestMethod_Game_FaceTheDragon_FaceTheBeast()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The heads go beyond the imagination of this fantasy." + Environment.NewLine
                   ;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_DragonHead_responseOutOfRange()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "something Not a number for dragon heads" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The heads go beyond the imagination of this fantasy." + Environment.NewLine
                   ;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_DragonHead_responseInRange_2()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The eyes go beyond the imagination of this fantasy." + Environment.NewLine;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_Weapon_responseNotInSet()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine +
                "invalid response for weapon";

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The eyes go beyond the imagination of this fantasy." + Environment.NewLine
              ;
                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }

        [TestMethod]
        public void TestMethod_Game_Weapon_responseInSet_bowAndArrow()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine +
                "bow and arrow" + Environment.NewLine +
                "next response" + Environment.NewLine;
                
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The eyes go beyond the imagination of this fantasy." + Environment.NewLine;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }

        [TestMethod]
        public void TestMethod_Game_Eyes_responseNot_Red()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine +
                "bow and arrow" + Environment.NewLine +
                "brown" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):" + Environment.NewLine +
                    "The story has ended for you Sandy. The eyes go beyond the imagination of this fantasy." + Environment.NewLine;

                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_Eyes_response_Red()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine +
                "bow and arrow" + Environment.NewLine +
                "ReD" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):" + Environment.NewLine +
                    "Oh thank goodness!  ReD-eyed dragons are friendly.  You pet it and become friends.  You name the dragon ___. (enter a name):" + Environment.NewLine+
                    "Sandy and  live happily ever after." + Environment.NewLine 
                        ;
                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }
        [TestMethod]
        public void TestMethod_Game_DragonName()
        {
            //the input data
            string inputConsole =
                ResponseForplayerName + Environment.NewLine +
                "yes" + Environment.NewLine +
                "face the beast" + Environment.NewLine +
                "2" + Environment.NewLine +
                "bow and arrow" + Environment.NewLine +
                "ReD" + Environment.NewLine +
                "toothless" + Environment.NewLine;

            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader(inputConsole))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    // Act
                    object[] parameters = new object[1];
                    mainMethod.Invoke(null, parameters);

                    // Assert
                    var result = sw.ToString();

                    string expected =
                    "Welcome! What is your name? (enter your name):" + Environment.NewLine +
                    "Would you like to play a game? (enter “yes” or “no”):" + Environment.NewLine +
                    "Excellent!  You are walking across a field and you encounter a fire-breathing dragon!  What would you do? (enter “face the beast” or “run away”):" + Environment.NewLine +
                    "You approach the dragon.  You see that he has ___ heads.  (enter “1” or “2” or “3”):" + Environment.NewLine +
                    "No one has ever faced a 2-headed dragon before!  Choose your weapon. (enter “slingshot” or “sword” or “bow and arrow”):" + Environment.NewLine +
                    "Armed with your bow and arrow, you approach the dragon.  You can feel its fiery breath as you get closer.   It stares at you with its ___ eyes.  (enter “red” or “blue”):" + Environment.NewLine +
                    "Oh thank goodness!  ReD-eyed dragons are friendly.  You pet it and become friends.  You name the dragon ___. (enter a name):" + Environment.NewLine +
                    "Sandy and toothless live happily ever after." + Environment.NewLine
                        ;
                    //
                    Assert.AreEqual(expected, result);
                }
            }

        }

    }
}
