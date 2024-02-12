using UnityEngine;namespace CrazyMinnow.SALSA.OneClicks{
    public class OneClickBoxHead : OneClickBase
    {
























































































































        /// <summary>        /// RELEASE NOTES:        ///		2.0.0-BETA : Initial release.        /// ==========================================================================        /// PURPOSE: This script provides simple, simulated lip-sync input to the        ///		Salsa component from text/string values. For the latest information        ///		visit crazyminnowstudio.com.        /// ==========================================================================        /// DISCLAIMER: While every attempt has been made to ensure the safe content        ///		and operation of these files, they are provided as-is, without        ///		warranty or guarantee of any kind. By downloading and using these        ///		files you are accepting any and all risks associated and release        ///		Crazy Minnow Studio, LLC of any and all liability.        /// ==========================================================================        /// </summary>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            public static void Setup(GameObject gameObject, AudioClip clip)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //	SETUP Requirements:
            //		use NewExpression("expression name") to start a new viseme/emote expression.
            //		use AddShapeComponent to add blendshape configurations, passing:
            //			- string array of shape names to look for.
            //			  : string array can be a single element.
            //			  : string array can be a single regex search string.
            //			    note: useRegex option must be set true.
            //			- optional string name prefix for the component.
            //			- optional blend amount (default = 1.0f).
            //			- optional regex search option (default = false).

            Init();









            #region SALSA-Configuration                                                                                                                                                                            NewConfiguration(OneClickConfiguration.ConfigType.Salsa);
            {
                ////////////////////////////////////////////////////////
                // SMR regex searches (enable/disable/add as required).
                AddSmrSearch("^.*$");

                ////////////////////////////////////////////////////////
                // Adjust SALSA settings to taste...
                // - data analysis settings
                autoAdjustAnalysis = true;
                autoAdjustMicrophone = false;

                // - advanced dynamics settings
                loCutoff = 0.015f;
                hiCutoff = 0.75f;
                useAdvDyn = true;
                advDynPrimaryBias = 0.5f;
                useAdvDynJitter = true;
                advDynJitterAmount = 0.10f;
                advDynJitterProb = 0.20f;
                advDynSecondaryMix = 0f;
                emphasizerTrigger = 0f;

                ////////////////////////////////////////////////////////
                // Viseme setup...

                NewExpression("saySmall");
                AddShapeComponent(new[] { "saySml" }, 0.12f, 0f, 0.06f, "saySml", 1f, false);

                NewExpression("sayMedium");
                AddShapeComponent(new[] { "sayMed" }, 0.12f, 0f, 0.06f, "sayMed", 1f, false);

                NewExpression("sayLarge");
                AddShapeComponent(new[] { "sayLrg" }, 0.12f, 0f, 0.06f, "sayLrg", 1f, false);
            }
















            #endregion // SALSA-configuration
            #region EmoteR-Configuration                                                                                                                                                                                NewConfiguration(OneClickConfiguration.ConfigType.Emoter);
            {
                ////////////////////////////////////////////////////////
                // SMR regex searches (enable/disable/add as required).
                AddSmrSearch("^.*$");

                useRandomEmotes = false;
                isChancePerEmote = true;
                numRandomEmotesPerCycle = 0;
                randomEmoteMinTimer = 1f;
                randomEmoteMaxTimer = 2f;
                randomChance = 0.5f;
                useRandomFrac = false;
                randomFracBias = 0.5f;
                useRandomHoldDuration = false;
                randomHoldDurationMin = 0.1f;
                randomHoldDurationMax = 0.5f;

                ////////////////////////////////////////////////////////
                // Emote setup...

                NewExpression("furrow");
                AddEmoteFlags(false, true, false, 1f);
                AddShapeComponent(new[] { "furrowedBrow" }, 0.3f, 0.1f, 0.2f, "furrowedBrow", 1f, false);

                NewExpression("brows up");
                AddEmoteFlags(false, false, false, 1f);
                AddShapeComponent(new[] { "browsUpLeft" }, 0.3f, 0.1f, 0.2f, "browsUpLeft", 1f, false);
                AddShapeComponent(new[] { "browsUpRight" }, 0.3f, 0.1f, 0.2f, "browsUpRight", 1f, false);

                NewExpression("brow up R");
                AddEmoteFlags(false, true, false, 0.37f);
                AddShapeComponent(new[] { "browsUpRight" }, 0.3f, 0.1f, 0.2f, "browsUpRight", 1f, false);

                NewExpression("brow up L");
                AddEmoteFlags(false, true, false, 0.37f);
                AddShapeComponent(new[] { "browsUpLeft" }, 0.3f, 0.1f, 0.2f, "browsUpLeft", 1f, false);

                NewExpression("eyes wide");
                AddEmoteFlags(false, true, false, 1f);
                AddShapeComponent(new[] { "eyesWide" }, 0.3f, 0.1f, 0.2f, "eyesWide", 1f, false);
            }


            #endregion // EmoteR-configuration
            DoOneClickiness(gameObject, clip);
        }
    }}