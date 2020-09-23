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

    class RoomStatus
    {
        static Dictionary<ROOMID, List<int>> roomToCardMap = new Dictionary<ROOMID, List<int>>();
        static List<int> empty = new List<int>();

        public static Dictionary<ROOMID, List<int>> RoomToCardMap { get => roomToCardMap; set => roomToCardMap = value; }

        public static void InitializeRoomToCardMap() 
        {
            // Card order roughly follows Revo's collection order for Carol All Cards as of 21 September 2020 https://www.speedrun.com/fp/run/y2qe7x7y
            RoomToCardMap.Add(ROOMID.DV1, new List<int>(new int[] { 1, 2, 3, 4 })); // Switch Skipper
            RoomToCardMap.Add(ROOMID.DV2, new List<int>(new int[] { 5, 6 }));
            RoomToCardMap.Add(ROOMID.DV3, new List<int>(new int[] { 7, 10, 8, 9 }));
            // DV4  Special Move KO

            RoomToCardMap.Add(ROOMID.RM1, new List<int>(new int[] { 11, 12, 13 }));
            RoomToCardMap.Add(ROOMID.RM2, new List<int>(new int[] { 14, 15, 16 })); // Push Block KO
            RoomToCardMap.Add(ROOMID.RM3, new List<int>(new int[] { 17}));
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
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            RoomToCardMap.Add(ROOMID.FD1, new List<int>(new int[] { }));
            */
        }

        public static List<int> GetCardsInRoom(int roomID) 
        {
            if (RoomToCardMap.ContainsKey((ROOMID)roomID)) {
                return RoomToCardMap[(ROOMID)roomID];
            } else {
                return empty;
            }
        }
    }
}
