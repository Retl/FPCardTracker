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
            // Card order roughly follows Revo's collection order for Carol All Cards as of 21 September 2020
            RoomToCardMap.Add(ROOMID.DV1, new List<int>(new int[] { 1, 2, 3, 4 })); // Switch Skipper
            RoomToCardMap.Add(ROOMID.DV2, new List<int>(new int[] { 5, 6 }));
            RoomToCardMap.Add(ROOMID.DV3, new List<int>(new int[] { 7, 10, 8, 9 }));

            RoomToCardMap.Add(ROOMID.RM1, new List<int>(new int[] { 11, 12, 13 }));
            RoomToCardMap.Add(ROOMID.RM2, new List<int>(new int[] { 14, 15, 16 }));
            RoomToCardMap.Add(ROOMID.RM3, new List<int>(new int[] { 17, 19, 18}));
            RoomToCardMap.Add(ROOMID.RM4, new List<int>(new int[] { })); // Bone Seleton Here
            RoomToCardMap.Add(ROOMID.RM5, new List<int>(new int[] { 20 })); // Mantalith Here

            RoomToCardMap.Add(ROOMID.FN1, new List<int>(new int[] { 20 }));
            RoomToCardMap.Add(ROOMID.FN2, new List<int>(new int[] { 20 }));
            RoomToCardMap.Add(ROOMID.FN3, new List<int>(new int[] { 20 }));
            RoomToCardMap.Add(ROOMID.FN4, new List<int>(new int[] { 20 }));
            RoomToCardMap.Add(ROOMID.FN5, new List<int>(new int[] { 20 }));
            RoomToCardMap.Add(ROOMID.FN6, new List<int>(new int[] { }));
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
