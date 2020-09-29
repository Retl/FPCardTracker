using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPCardTracker
{
    public enum ROOMID {
        AT1 = 16,
        AT2 = 17,
        AT3 = 18,
        AT4 = 19,

        DV1 = 20,
        DV2 = 21,
        DV3 = 22,
        DV4 = 23,

        RM1 = 24,
        RM2 = 25,
        RM3 = 26,
        RM4 = 27,
        RM5 = 28,

        FN1 = 29,
        FN2 = 30,
        FN3 = 31,
        FN4 = 32,
        FN5 = 33,
        FN6 = 34,

        SBHUB = 35,
        SB1 = 36,
        SB2 = 37,
        SB3 = 38,

        JC1 = 39,
        JC2 = 40,
        JC3 = 41,
        JC4 = 42,
        JC5 = 43,

        TB1 = 44,
        TB2 = 45,
        TB3 = 46,
        TB4 = 47,
        TB5 = 48,
        TB6 = 49,

        PL1 = 50,
        PL2 = 51,
        PL3 = 52,
        PL4 = 53,
        PL5 = 54,
        PL6 = 55,

        TH1 = 56,
        TH2 = 57,
        TH3 = 58,

        BG1 = 59,
        BG2 = 60,
        BG3 = 61,
        BG4 = 62,
        BG5 = 63,
        BG6 = 64,

        FD1 = 65,
        FD2 = 66,
        FD3 = 67,
        FD4 = 68,
        FD5 = 69,
        FD6 = 70,
        FD7 = 71,
        FD8 = 72,
    }

    public enum ACHIEVEMENT_ID
    {
        NOTHING = 0,
        DRAGON_POWER = 1,
        CALL_OF_THE_WILDCAT = 2,
        SPIRIT_OF_THE_HOUND = 3,
        NO_DEATH = 4,
        SPEED_CLEAR = 5,
        GEM_HOARDER = 6,
        TARGET_MASTER_LILAC = 7,
        TARGET_MASTER_CAROL = 8,
        TARGET_MASTER_MILLA = 9,
        RISING_SLASH_FINISH = 10,
        DRAGON_CYCLONE_FINISH = 11,
        DRAGON_BOOST_FINISH = 12,
        WILD_CLAW_FINISH = 13,
        WILD_KICK_FINISH = 14,
        MOTORCYCLE_FINISH = 15,
        PHANTOM_BLOCK_FINISH = 16,
        SUPER_SHIELD_BURST_FINISH = 17,
        SWITCH_SKIPPER = 18,
        CLAW_BYPASS = 19, 
        DISCO_FEVER = 20,
        CPU_FINISH = 21,
        BOOST_PERFECTIONIST = 22,
        CARD_COLLECTOR_DV = 23,
        CARD_COLLECTOR_RM = 24,
        CARD_COLLECTOR_AT = 25,
        CARD_COLLECTOR_FN = 26,
        CARD_COLLECTOR_SB = 27,
        CARD_COLLECTOR_JC = 28,
        CARD_COLLECTOR_TB = 29,
        CARD_COLLECTOR_TH = 30,
        CARD_COLLECTOR_PL = 31,
        CARD_COLLECTOR_BG = 32,
        ROLLING_STONES = 33,
        PUSH_BLOCK_KO = 34,
        ALL_BONE_NO_BRAIN = 35,
        PREEMPTIVE_STRIKE_1 = 36,
        PREEMPTIVE_STRIKE_2 = 37,
        TREASURE_HUNTER = 38,
        LEDGE_TAUNT = 39,
        FREE_FALLER = 40,
        SECRET_MELODY = 41,
        MILLA_UNLOCKED = 42,
        SPEEDRUNNER_DV = 43,
        SPEEDRUNNER_RM = 44,
        SPEEDRUNNER_AT = 45,
        SPEEDRUNNER_FN = 46,
        SPEEDRUNNER_SB = 47,
        SPEEDRUNNER_JC = 48,
        SPEEDRUNNER_TB = 49,
        SPEEDRUNNER_TH = 50,
        SPEEDRUNNER_PL = 51,
        SPEEDRUNNER_BG = 52,
        SPEEDRUNNER_FD1 = 53,
        SPEEDRUNNER_FD2 = 54,
        SPEEDRUNNER_FD3 = 55,
        SPEEDRUNNER_FD4 = 56,
    }

    class RoomStatus
    {
        static Dictionary<ROOMID, List<int>> roomToCardMap = new Dictionary<ROOMID, List<int>>();
        static Dictionary<ROOMID, List<int>> roomToAchievementMap = new Dictionary<ROOMID, List<int>>();

        static List<int> empty = new List<int>();

        public static Dictionary<ROOMID, List<int>> RoomToCardMap { get => roomToCardMap; set => roomToCardMap = value; }
        public static Dictionary<ROOMID, List<int>> RoomToAchievementMap { get => roomToAchievementMap; set => roomToAchievementMap = value; }

        public static void InitializeRoomToCardMap() 
        {
            // Card order roughly follows Revo's collection order for Carol All Cards as of 21 September 2020 https://www.speedrun.com/fp/run/y2qe7x7y
            RoomToCardMap.Add(ROOMID.DV1, new List<int>(new int[] { 1, 2, 3, 4 })); // Switch Skipper
            RoomToCardMap.Add(ROOMID.DV2, new List<int>(new int[] { 5, 6 }));
            RoomToCardMap.Add(ROOMID.DV3, new List<int>(new int[] { 7, 10, 8, 9 }));
            // DV4  Special Move KO

            RoomToCardMap.Add(ROOMID.RM1, new List<int>(new int[] { 11, 12, 13 }));
            RoomToCardMap.Add(ROOMID.RM2, new List<int>(new int[] { 14, 15, 16 })); // Push Block KO
            RoomToCardMap.Add(ROOMID.RM3, new List<int>(new int[] { 17 }));
            RoomToCardMap.Add(ROOMID.RM4, new List<int>(new int[] { 19, 18 })); // Bone Seleton Here
            RoomToCardMap.Add(ROOMID.RM5, new List<int>(new int[] { 20 })); // Mantalith Preemptive Strike I Here, Special Move KO

            // Aqua Tunnel order from - https://www.speedrun.com/fp/run/y43d58dz 
            RoomToCardMap.Add(ROOMID.AT1, new List<int>(new int[] { 23, 21, 22 })); // Digspot
            RoomToCardMap.Add(ROOMID.AT2, new List<int>(new int[] { 24, 26, 25 }));
            RoomToCardMap.Add(ROOMID.AT3, new List<int>(new int[] { 27 }));
            RoomToCardMap.Add(ROOMID.AT4, new List<int>(new int[] { 28, 29, 30 }));

            RoomToCardMap.Add(ROOMID.FN1, new List<int>(new int[] { 31, 32 }));
            RoomToCardMap.Add(ROOMID.FN2, new List<int>(new int[] { 35, 34, 33 }));
            RoomToCardMap.Add(ROOMID.FN3, new List<int>(new int[] { 36 }));
            RoomToCardMap.Add(ROOMID.FN4, new List<int>(new int[] { 38, 37 })); // Piano and Dance here
            RoomToCardMap.Add(ROOMID.FN5, new List<int>(new int[] { 39, 40 })); // Piano and Dance here
            RoomToCardMap.Add(ROOMID.FN6, new List<int>(new int[] { })); // Assist KO RoboPanther, Special Move KO

            RoomToCardMap.Add(ROOMID.SBHUB, new List<int>(new int[] { })); // Dail, Special Move KO
            RoomToCardMap.Add(ROOMID.SB1, new List<int>(new int[] { 43, 42, 41 })); // Metal Ship. NO PLANE. Huge thanks to Deckard for testing this out!
            RoomToCardMap.Add(ROOMID.SB2, new List<int>(new int[] { 47, 46, 45, 44 })); // Fire Ship. Extremely hard for Carol. NO PLANE. Lilac Only: LEDGE TAUNT. Huge thanks to Deckard for testing this out!
            RoomToCardMap.Add(ROOMID.SB3, new List<int>(new int[] { 50, 49, 48 })); // Earth Ship. Carol wants Metal Shield here. NO PLANE.

            RoomToCardMap.Add(ROOMID.JC1, new List<int>(new int[] { 53, 52, 51 }));
            RoomToCardMap.Add(ROOMID.JC2, new List<int>(new int[] { 56, 55, 54 }));
            RoomToCardMap.Add(ROOMID.JC3, new List<int>(new int[] { 57 }));
            RoomToCardMap.Add(ROOMID.JC4, new List<int>(new int[] { 60, 59, 58}));
            // RoomToCardMap.Add(ROOMID.JC5, new List<int>(new int[] { })); // Serp. Special Move KO

            RoomToCardMap.Add(ROOMID.TB1, new List<int>(new int[] { 61 }));
            RoomToCardMap.Add(ROOMID.TB2, new List<int>(new int[] { 62 }));
            RoomToCardMap.Add(ROOMID.TB3, new List<int>(new int[] { 64, 63 }));
            RoomToCardMap.Add(ROOMID.TB4, new List<int>(new int[] { 66, 65 }));
            RoomToCardMap.Add(ROOMID.TB5, new List<int>(new int[] { 70, 67, 69, 68 })); // NICE. Syntax, Special Move KO
            // RoomToCardMap.Add(ROOMID.TB6, new List<int>(new int[] { }));

            // Pangu Lagoon order from: https://www.speedrun.com/fp/run/zqr34w5y
            RoomToCardMap.Add(ROOMID.PL1, new List<int>(new int[] { 82, 81 }));
            RoomToCardMap.Add(ROOMID.PL2, new List<int>(new int[] { 85, 84, 83 }));
            RoomToCardMap.Add(ROOMID.PL4, new List<int>(new int[] { 86, 87 }));
            RoomToCardMap.Add(ROOMID.PL3, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.PL5, new List<int>(new int[] { 89, 90, 88 }));
            RoomToCardMap.Add(ROOMID.PL6, new List<int>(new int[] { })); // Special Move KO

            RoomToCardMap.Add(ROOMID.TH1, new List<int>(new int[] { 71 }));
            RoomToCardMap.Add(ROOMID.TH2, new List<int>(new int[] { 75, 74, 73, 72 }));
            RoomToCardMap.Add(ROOMID.TH3, new List<int>(new int[] { 80, 79, 78, 77, 76 })); // Special Move KO

            RoomToCardMap.Add(ROOMID.BG1, new List<int>(new int[] { 91, 92 }));
            RoomToCardMap.Add(ROOMID.BG2, new List<int>(new int[] { 94, 93 }));
            RoomToCardMap.Add(ROOMID.BG3, new List<int>(new int[] { 96, 95 }));
            RoomToCardMap.Add(ROOMID.BG4, new List<int>(new int[] { 97, 98 }));
            RoomToCardMap.Add(ROOMID.BG5, new List<int>(new int[] { 100, 99 }));
            // RoomToCardMap.Add(ROOMID.BG6, new List<int>(new int[] { })); // Preemptive Strike II, Special Move KO

            /*
             * FD HAS NO CARDS.
            */
        }

        public static void InitializeRoomToAchievementMap()
        {
            // Card order roughly follows Revo's collection order for Carol All Cards as of 21 September 2020 https://www.speedrun.com/fp/run/y2qe7x7y
            RoomToAchievementMap.Add(ROOMID.DV1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_DV, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_DV, (int)ACHIEVEMENT_ID.SWITCH_SKIPPER })); // Switch Skipper


            RoomToAchievementMap.Add(ROOMID.DV2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_DV, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_DV }));


            RoomToAchievementMap.Add(ROOMID.DV3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_DV, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_DV }));


            RoomToAchievementMap.Add(ROOMID.DV4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_DV, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_DV,
                (int)ACHIEVEMENT_ID.ROLLING_STONES, (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Mantalith Preemptive Strike I Here, Special Move KO// DV4  Special Move KO


            RoomToAchievementMap.Add(ROOMID.RM1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_RM, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_RM }));


            RoomToAchievementMap.Add(ROOMID.RM2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_RM, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_RM, (int)ACHIEVEMENT_ID.PUSH_BLOCK_KO })); // Push Block KO


            RoomToAchievementMap.Add(ROOMID.RM3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_RM, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_RM, (int)ACHIEVEMENT_ID.CLAW_BYPASS }));


            RoomToAchievementMap.Add(ROOMID.RM4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_RM, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_RM, (int)ACHIEVEMENT_ID.ALL_BONE_NO_BRAIN })); // Bone Seleton Here


            RoomToAchievementMap.Add(ROOMID.RM5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_RM, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_RM, (int)ACHIEVEMENT_ID.PREEMPTIVE_STRIKE_1, (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH, 
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Mantalith Preemptive Strike I Here, Special Move KO


            // Aqua Tunnel order from - https://www.speedrun.com/fp/run/y43d58dz 
            RoomToAchievementMap.Add(ROOMID.AT1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_AT, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_AT, 
                (int)ACHIEVEMENT_ID.TREASURE_HUNTER })); // Digspot


            RoomToAchievementMap.Add(ROOMID.AT2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_AT, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_AT, 
                (int)ACHIEVEMENT_ID.TREASURE_HUNTER }));


            RoomToAchievementMap.Add(ROOMID.AT3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_AT, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_AT, 
                (int)ACHIEVEMENT_ID.TREASURE_HUNTER }));


            RoomToAchievementMap.Add(ROOMID.AT4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_AT, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_AT, 
                (int)ACHIEVEMENT_ID.TREASURE_HUNTER, (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH }));



            RoomToAchievementMap.Add(ROOMID.FN1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN }));


            RoomToAchievementMap.Add(ROOMID.FN2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN }));


            RoomToAchievementMap.Add(ROOMID.FN3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN }));


            RoomToAchievementMap.Add(ROOMID.FN4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN, 
                (int)ACHIEVEMENT_ID.SECRET_MELODY, (int)ACHIEVEMENT_ID.DISCO_FEVER})); // Piano and Dance here


            RoomToAchievementMap.Add(ROOMID.FN5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN, 
                (int)ACHIEVEMENT_ID.SECRET_MELODY, (int)ACHIEVEMENT_ID.DISCO_FEVER })); // Piano and Dance here


            RoomToAchievementMap.Add(ROOMID.FN6, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FN, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_FN, 
                (int)ACHIEVEMENT_ID.CPU_FINISH, (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Assist KO RoboPanther, Special Move KO



            RoomToAchievementMap.Add(ROOMID.SBHUB, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_SB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_SB,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH})); // Dail, Special Move KO


            RoomToAchievementMap.Add(ROOMID.SB1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_SB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_SB, 
                (int)ACHIEVEMENT_ID.FREE_FALLER })); // Metal Ship. NO PLANE. Huge thanks to Deckard for testing this out!


            RoomToAchievementMap.Add(ROOMID.SB2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_SB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_SB, 
                (int)ACHIEVEMENT_ID.LEDGE_TAUNT, (int)ACHIEVEMENT_ID.FREE_FALLER })); // Fire Ship. Extremely hard for Carol. NO PLANE. Lilac Only: LEDGE TAUNT. Huge thanks to Deckard for testing this out!


            RoomToAchievementMap.Add(ROOMID.SB3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_SB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_SB, 
                (int)ACHIEVEMENT_ID.FREE_FALLER })); // Earth Ship. Carol wants Metal Shield here. NO PLANE.



            RoomToAchievementMap.Add(ROOMID.JC1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_JC, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_JC }));


            RoomToAchievementMap.Add(ROOMID.JC2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_JC, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_JC }));


            RoomToAchievementMap.Add(ROOMID.JC3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_JC, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_JC }));


            RoomToAchievementMap.Add(ROOMID.JC4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_JC, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_JC }));


            RoomToAchievementMap.Add(ROOMID.JC5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_JC, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_JC,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Serp. Special Move KO

            RoomToAchievementMap.Add(ROOMID.TB1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB }));


            RoomToAchievementMap.Add(ROOMID.TB2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB }));


            RoomToAchievementMap.Add(ROOMID.TB3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB }));


            RoomToAchievementMap.Add(ROOMID.TB4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB }));


            RoomToAchievementMap.Add(ROOMID.TB5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // NICE. Syntax, Special Move KO


            RoomToAchievementMap.Add(ROOMID.TB6, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TB, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TB }));



            // Pangu Lagoon order from: https://www.speedrun.com/fp/run/zqr34w5y
            RoomToAchievementMap.Add(ROOMID.PL1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL }));


            RoomToAchievementMap.Add(ROOMID.PL2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL }));


            RoomToAchievementMap.Add(ROOMID.PL4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL }));


            RoomToAchievementMap.Add(ROOMID.PL3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL }));


            RoomToAchievementMap.Add(ROOMID.PL5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL }));


            RoomToAchievementMap.Add(ROOMID.PL6, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_PL, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_PL,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH})); // Special Move KO

            RoomToAchievementMap.Add(ROOMID.TH1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TH, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TH }));


            RoomToAchievementMap.Add(ROOMID.TH2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TH, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TH }));


            RoomToAchievementMap.Add(ROOMID.TH3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_TH, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_TH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Special Move KO

            RoomToAchievementMap.Add(ROOMID.BG1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG }));


            RoomToAchievementMap.Add(ROOMID.BG2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG, (int)ACHIEVEMENT_ID.BOOST_PERFECTIONIST }));


            RoomToAchievementMap.Add(ROOMID.BG3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG }));


            RoomToAchievementMap.Add(ROOMID.BG4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG }));


            RoomToAchievementMap.Add(ROOMID.BG5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG }));

            RoomToAchievementMap.Add(ROOMID.BG6, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_BG, (int)ACHIEVEMENT_ID.CARD_COLLECTOR_BG,
                (int)ACHIEVEMENT_ID.PREEMPTIVE_STRIKE_2, (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH })); // Preemptive Strike II, Special Move KO


            RoomToAchievementMap.Add(ROOMID.FD1, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD1}));

            RoomToAchievementMap.Add(ROOMID.FD2, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD1,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH }));


            RoomToAchievementMap.Add(ROOMID.FD3, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD2 }));

            RoomToAchievementMap.Add(ROOMID.FD4, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD2,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH }));


            RoomToAchievementMap.Add(ROOMID.FD5, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD3 }));

            RoomToAchievementMap.Add(ROOMID.FD6, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD3,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH }));


            RoomToAchievementMap.Add(ROOMID.FD7, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD4 }));

            RoomToAchievementMap.Add(ROOMID.FD8, new List<int>(new int[] { (int)ACHIEVEMENT_ID.SPEEDRUNNER_FD4,
                (int)ACHIEVEMENT_ID.RISING_SLASH_FINISH,
                (int)ACHIEVEMENT_ID.DRAGON_BOOST_FINISH, (int)ACHIEVEMENT_ID.DRAGON_CYCLONE_FINISH,
                (int)ACHIEVEMENT_ID.MOTORCYCLE_FINISH, (int)ACHIEVEMENT_ID.WILD_CLAW_FINISH, (int)ACHIEVEMENT_ID.WILD_KICK_FINISH,
                (int)ACHIEVEMENT_ID.PHANTOM_BLOCK_FINISH, (int)ACHIEVEMENT_ID.SUPER_SHIELD_BURST_FINISH }));
            
        }

        public static List<int> GetCardsInRoom(int roomID) 
        {
            if (RoomToCardMap.ContainsKey((ROOMID)roomID)) {
                return RoomToCardMap[(ROOMID)roomID];
            } else {
                return empty;
            }
        }

        public static List<int> GetAchievementsInRoom(int roomID)
        {
            if (RoomToAchievementMap.ContainsKey((ROOMID)roomID))
            {
                return RoomToAchievementMap[(ROOMID)roomID];
            }
            else
            {
                return empty;
            }
        }
    }
}
