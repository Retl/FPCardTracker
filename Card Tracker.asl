// Card Tracker for Freedom Planet. Only supports Beta 1.21.5, not the final release build.
// If you need a VAR Viewer: https://github.com/hawkerm/LiveSplit.ASLVarViewer

// 100 cards = 10 levels with 10 cards. (FD and SMA do not have cards)
// 8 achievements per row, 7 rows of achievements = 56 achievements.

state("FP", "steam-1.21.5-win")
{
    int roomID : 0x1938D40;
    int card1 : 0x018D7BF8, 0x4c;
    int card2 : 0x018D7BF8, 0x9c;
    int card3 : 0x018D7BF8, 0xec;
    int card4 : 0x018D7BF8, 0x13c;
    int card5 : 0x018D7BF8, 0x18c;
    int card6 : 0x018D7BF8, 0x1dc;
    int card7 : 0x018D7BF8, 0x22c;
    int card8 : 0x018D7BF8, 0x27c;
    int card9 : 0x018D7BF8, 0x2cc;
    int card10 : 0x018D7BF8, 0x31c;
    int card11 : 0x018D7BF8, 0x36c;
    int card12 : 0x018D7BF8, 0x3bc;
    int card13 : 0x018D7BF8, 0x40c;
    int card14 : 0x018D7BF8, 0x45c;
    int card15 : 0x018D7BF8, 0x4ac;
    int card16 : 0x018D7BF8, 0x4fc;
    int card17 : 0x018D7BF8, 0x54c;
    int card18 : 0x018D7BF8, 0x59c;
    int card19 : 0x018D7BF8, 0x5ec;
    int card20 : 0x018D7BF8, 0x63c;
    int card21 : 0x018D7BF8, 0x68c;
    int card22 : 0x018D7BF8, 0x6dc;
    int card23 : 0x018D7BF8, 0x72c;
    int card24 : 0x018D7BF8, 0x77c;
    int card25 : 0x018D7BF8, 0x7cc;
    int card26 : 0x018D7BF8, 0x81c;
    int card27 : 0x018D7BF8, 0x86c;
    int card28 : 0x018D7BF8, 0x8bc;
    int card29 : 0x018D7BF8, 0x90c;
    int card30 : 0x018D7BF8, 0x95c;
    int card31 : 0x018D7BF8, 0x9ac;
    int card32 : 0x018D7BF8, 0x9fc;
    int card33 : 0x018D7BF8, 0xa4c;
    int card34 : 0x018D7BF8, 0xa9c;
    int card35 : 0x018D7BF8, 0xaec;
    int card36 : 0x018D7BF8, 0xb3c;
    int card37 : 0x018D7BF8, 0xb8c;
    int card38 : 0x018D7BF8, 0xbdc;
    int card39 : 0x018D7BF8, 0xc2c;
    int card40 : 0x018D7BF8, 0xc7c;
    int card41 : 0x018D7BF8, 0xccc;
    int card42 : 0x018D7BF8, 0xd1c;
    int card43 : 0x018D7BF8, 0xd6c;
    int card44 : 0x018D7BF8, 0xdbc;
    int card45 : 0x018D7BF8, 0xe0c;
    int card46 : 0x018D7BF8, 0xe5c;
    int card47 : 0x018D7BF8, 0xeac;
    int card48 : 0x018D7BF8, 0xefc;
    int card49 : 0x018D7BF8, 0xf4c;
    int card50 : 0x018D7BF8, 0xf9c;
    int card51 : 0x018D7BF8, 0xfec;
    int card52 : 0x018D7BF8, 0x103c;
    int card53 : 0x018D7BF8, 0x108c;
    int card54 : 0x018D7BF8, 0x10dc;
    int card55 : 0x018D7BF8, 0x112c;
    int card56 : 0x018D7BF8, 0x117c;
    int card57 : 0x018D7BF8, 0x11cc;
    int card58 : 0x018D7BF8, 0x121c;
    int card59 : 0x018D7BF8, 0x126c;
    int card60 : 0x018D7BF8, 0x12bc;
    int card61 : 0x018D7BF8, 0x130c;
    int card62 : 0x018D7BF8, 0x135c;
    int card63 : 0x018D7BF8, 0x13ac;
    int card64 : 0x018D7BF8, 0x13fc;
    int card65 : 0x018D7BF8, 0x144c;
    int card66 : 0x018D7BF8, 0x149c;
    int card67 : 0x018D7BF8, 0x14ec;
    int card68 : 0x018D7BF8, 0x153c;
    int card69 : 0x018D7BF8, 0x158c;
    int card70 : 0x018D7BF8, 0x15dc;
    int card71 : 0x018D7BF8, 0x162c;
    int card72 : 0x018D7BF8, 0x167c;
    int card73 : 0x018D7BF8, 0x16cc;
    int card74 : 0x018D7BF8, 0x171c;
    int card75 : 0x018D7BF8, 0x176c;
    int card76 : 0x018D7BF8, 0x17bc;
    int card77 : 0x018D7BF8, 0x180c;
    int card78 : 0x018D7BF8, 0x185c;
    int card79 : 0x018D7BF8, 0x18ac;
    int card80 : 0x018D7BF8, 0x18fc;
    int card81 : 0x018D7BF8, 0x194c;
    int card82 : 0x018D7BF8, 0x199c;
    int card83 : 0x018D7BF8, 0x19ec;
    int card84 : 0x018D7BF8, 0x1a3c;
    int card85 : 0x018D7BF8, 0x1a8c;
    int card86 : 0x018D7BF8, 0x1adc;
    int card87 : 0x018D7BF8, 0x1b2c;
    int card88 : 0x018D7BF8, 0x1b7c;
    int card89 : 0x018D7BF8, 0x1bcc;
    int card90 : 0x018D7BF8, 0x1c1c;
    int card91 : 0x018D7BF8, 0x1c6c;
    int card92 : 0x018D7BF8, 0x1cbc;
    int card93 : 0x018D7BF8, 0x1d0c;
    int card94 : 0x018D7BF8, 0x1d5c;
    int card95 : 0x018D7BF8, 0x1dac;
    int card96 : 0x018D7BF8, 0x1dfc;
    int card97 : 0x018D7BF8, 0x1e4c;
    int card98 : 0x018D7BF8, 0x1e9c;
    int card99 : 0x018D7BF8, 0x1eec;
    int card100 : 0x018D7BF8, 0x1f3c;
    
    int achievement1 : 0x018D7BF8, 0x4;
    int achievement2 : 0x018D7BF8, 0x54;
    int achievement3 : 0x018D7BF8, 0xa4;
    int achievement4 : 0x018D7BF8, 0xf4;
    int achievement5 : 0x018D7BF8, 0x144;
    int achievement6 : 0x018D7BF8, 0x194;
    int achievement7 : 0x018D7BF8, 0x1e4;
    int achievement8 : 0x018D7BF8, 0x234;
    int achievement9 : 0x018D7BF8, 0x284;
    int achievement10 : 0x018D7BF8, 0x2d4;
    int achievement11 : 0x018D7BF8, 0x324;
    int achievement12 : 0x018D7BF8, 0x374;
    int achievement13 : 0x018D7BF8, 0x3c4;
    int achievement14 : 0x018D7BF8, 0x414;
    int achievement15 : 0x018D7BF8, 0x464;
    int achievement16 : 0x018D7BF8, 0x4b4;
    int achievement17 : 0x018D7BF8, 0x504;
    int achievement18 : 0x018D7BF8, 0x554;
    int achievement19 : 0x018D7BF8, 0x5a4;
    int achievement20 : 0x018D7BF8, 0x5f4;
    int achievement21 : 0x018D7BF8, 0x644;
    int achievement22 : 0x018D7BF8, 0x694;
    int achievement23 : 0x018D7BF8, 0x6e4;
    int achievement24 : 0x018D7BF8, 0x734;
    int achievement25 : 0x018D7BF8, 0x784;
    int achievement26 : 0x018D7BF8, 0x7d4;
    int achievement27 : 0x018D7BF8, 0x824;
    int achievement28 : 0x018D7BF8, 0x874;
    int achievement29 : 0x018D7BF8, 0x8c4;
    int achievement30 : 0x018D7BF8, 0x914;
    int achievement31 : 0x018D7BF8, 0x964;
    int achievement32 : 0x018D7BF8, 0x9b4;
    int achievement33 : 0x018D7BF8, 0xa04;
    int achievement34 : 0x018D7BF8, 0xa54;
    int achievement35 : 0x018D7BF8, 0xaa4;
    int achievement36 : 0x018D7BF8, 0xaf4;
    int achievement37 : 0x018D7BF8, 0xb44;
    int achievement38 : 0x018D7BF8, 0xb94;
    int achievement39 : 0x018D7BF8, 0xbe4;
    int achievement40 : 0x018D7BF8, 0xc34;
    int achievement41 : 0x018D7BF8, 0xc84;
    int achievement42 : 0x018D7BF8, 0xcd4;
    int achievement43 : 0x018D7BF8, 0xd24;
    int achievement44 : 0x018D7BF8, 0xd74;
    int achievement45 : 0x018D7BF8, 0xdc4;
    int achievement46 : 0x018D7BF8, 0xe14;
    int achievement47 : 0x018D7BF8, 0xe64;
    int achievement48 : 0x018D7BF8, 0xeb4;
    int achievement49 : 0x018D7BF8, 0xf04;
    int achievement50 : 0x018D7BF8, 0xf54;
    int achievement51 : 0x018D7BF8, 0xfa4;
    int achievement52 : 0x018D7BF8, 0xff4;
    int achievement53 : 0x018D7BF8, 0x1044;
    int achievement54 : 0x018D7BF8, 0x1094;
    int achievement55 : 0x018D7BF8, 0x10e4;
    int achievement56 : 0x018D7BF8, 0x1134;
    int achievement57 : 0x018D7BF8, 0x1184;
    int achievement58 : 0x018D7BF8, 0x11d4;
    int achievement59 : 0x018D7BF8, 0x1224;
    int achievement60 : 0x018D7BF8, 0x1274;
    int achievement61 : 0x018D7BF8, 0x12c4;
    int achievement62 : 0x018D7BF8, 0x1314;
    int achievement63 : 0x018D7BF8, 0x1364;
    int achievement64 : 0x018D7BF8, 0x13b4;
    int achievement65 : 0x018D7BF8, 0x1404;
    int achievement66 : 0x018D7BF8, 0x1454;
    int achievement67 : 0x018D7BF8, 0x14a4;
    int achievement68 : 0x018D7BF8, 0x14f4;
    int achievement69 : 0x018D7BF8, 0x1544;
    int achievement70 : 0x018D7BF8, 0x1594;
    int achievement71 : 0x018D7BF8, 0x15e4;
    int achievement72 : 0x018D7BF8, 0x1634;
    int achievement73 : 0x018D7BF8, 0x1684;
    int achievement74 : 0x018D7BF8, 0x16d4;
    int achievement75 : 0x018D7BF8, 0x1724;
    int achievement76 : 0x018D7BF8, 0x1774;
    int achievement77 : 0x018D7BF8, 0x17c4;
    int achievement78 : 0x018D7BF8, 0x1814;
    int achievement79 : 0x018D7BF8, 0x1864;
    int achievement80 : 0x018D7BF8, 0x18b4;
    int achievement81 : 0x018D7BF8, 0x1904;
    int achievement82 : 0x018D7BF8, 0x1954;
    int achievement83 : 0x018D7BF8, 0x19a4;
    int achievement84 : 0x018D7BF8, 0x19f4;
    int achievement85 : 0x018D7BF8, 0x1a44;
    int achievement86 : 0x018D7BF8, 0x1a94;
    int achievement87 : 0x018D7BF8, 0x1ae4;
    int achievement88 : 0x018D7BF8, 0x1b34;
    int achievement89 : 0x018D7BF8, 0x1b84;
    int achievement90 : 0x018D7BF8, 0x1bd4;
    int achievement91 : 0x018D7BF8, 0x1c24;
    int achievement92 : 0x018D7BF8, 0x1c74;
    int achievement93 : 0x018D7BF8, 0x1cc4;
    int achievement94 : 0x018D7BF8, 0x1d14;
    int achievement95 : 0x018D7BF8, 0x1d64;
    int achievement96 : 0x018D7BF8, 0x1db4;
    int achievement97 : 0x018D7BF8, 0x1e04;
    int achievement98 : 0x018D7BF8, 0x1e54;
    int achievement99 : 0x018D7BF8, 0x1ea4;
    int achievement100 : 0x018D7BF8, 0x1ef4;
}

state("FP", "steam-1.21.5-win-beta")
{
    int roomID : 0x14BDBC8;
    int card1 : 0x0148902C, 0x4c;
    int card2 : 0x0148902C, 0x9c;
    int card3 : 0x0148902C, 0xec;
    int card4 : 0x0148902C, 0x13c;
    int card5 : 0x0148902C, 0x18c;
    int card6 : 0x0148902C, 0x1dc;
    int card7 : 0x0148902C, 0x22c;
    int card8 : 0x0148902C, 0x27c;
    int card9 : 0x0148902C, 0x2cc;
    int card10 : 0x0148902C, 0x31c;
    int card11 : 0x0148902C, 0x36c;
    int card12 : 0x0148902C, 0x3bc;
    int card13 : 0x0148902C, 0x40c;
    int card14 : 0x0148902C, 0x45c;
    int card15 : 0x0148902C, 0x4ac;
    int card16 : 0x0148902C, 0x4fc;
    int card17 : 0x0148902C, 0x54c;
    int card18 : 0x0148902C, 0x59c;
    int card19 : 0x0148902C, 0x5ec;
    int card20 : 0x0148902C, 0x63c;
    int card21 : 0x0148902C, 0x68c;
    int card22 : 0x0148902C, 0x6dc;
    int card23 : 0x0148902C, 0x72c;
    int card24 : 0x0148902C, 0x77c;
    int card25 : 0x0148902C, 0x7cc;
    int card26 : 0x0148902C, 0x81c;
    int card27 : 0x0148902C, 0x86c;
    int card28 : 0x0148902C, 0x8bc;
    int card29 : 0x0148902C, 0x90c;
    int card30 : 0x0148902C, 0x95c;
    int card31 : 0x0148902C, 0x9ac;
    int card32 : 0x0148902C, 0x9fc;
    int card33 : 0x0148902C, 0xa4c;
    int card34 : 0x0148902C, 0xa9c;
    int card35 : 0x0148902C, 0xaec;
    int card36 : 0x0148902C, 0xb3c;
    int card37 : 0x0148902C, 0xb8c;
    int card38 : 0x0148902C, 0xbdc;
    int card39 : 0x0148902C, 0xc2c;
    int card40 : 0x0148902C, 0xc7c;
    int card41 : 0x0148902C, 0xccc;
    int card42 : 0x0148902C, 0xd1c;
    int card43 : 0x0148902C, 0xd6c;
    int card44 : 0x0148902C, 0xdbc;
    int card45 : 0x0148902C, 0xe0c;
    int card46 : 0x0148902C, 0xe5c;
    int card47 : 0x0148902C, 0xeac;
    int card48 : 0x0148902C, 0xefc;
    int card49 : 0x0148902C, 0xf4c;
    int card50 : 0x0148902C, 0xf9c;
    int card51 : 0x0148902C, 0xfec;
    int card52 : 0x0148902C, 0x103c;
    int card53 : 0x0148902C, 0x108c;
    int card54 : 0x0148902C, 0x10dc;
    int card55 : 0x0148902C, 0x112c;
    int card56 : 0x0148902C, 0x117c;
    int card57 : 0x0148902C, 0x11cc;
    int card58 : 0x0148902C, 0x121c;
    int card59 : 0x0148902C, 0x126c;
    int card60 : 0x0148902C, 0x12bc;
    int card61 : 0x0148902C, 0x130c;
    int card62 : 0x0148902C, 0x135c;
    int card63 : 0x0148902C, 0x13ac;
    int card64 : 0x0148902C, 0x13fc;
    int card65 : 0x0148902C, 0x144c;
    int card66 : 0x0148902C, 0x149c;
    int card67 : 0x0148902C, 0x14ec;
    int card68 : 0x0148902C, 0x153c;
    int card69 : 0x0148902C, 0x158c;
    int card70 : 0x0148902C, 0x15dc;
    int card71 : 0x0148902C, 0x162c;
    int card72 : 0x0148902C, 0x167c;
    int card73 : 0x0148902C, 0x16cc;
    int card74 : 0x0148902C, 0x171c;
    int card75 : 0x0148902C, 0x176c;
    int card76 : 0x0148902C, 0x17bc;
    int card77 : 0x0148902C, 0x180c;
    int card78 : 0x0148902C, 0x185c;
    int card79 : 0x0148902C, 0x18ac;
    int card80 : 0x0148902C, 0x18fc;
    int card81 : 0x0148902C, 0x194c;
    int card82 : 0x0148902C, 0x199c;
    int card83 : 0x0148902C, 0x19ec;
    int card84 : 0x0148902C, 0x1a3c;
    int card85 : 0x0148902C, 0x1a8c;
    int card86 : 0x0148902C, 0x1adc;
    int card87 : 0x0148902C, 0x1b2c;
    int card88 : 0x0148902C, 0x1b7c;
    int card89 : 0x0148902C, 0x1bcc;
    int card90 : 0x0148902C, 0x1c1c;
    int card91 : 0x0148902C, 0x1c6c;
    int card92 : 0x0148902C, 0x1cbc;
    int card93 : 0x0148902C, 0x1d0c;
    int card94 : 0x0148902C, 0x1d5c;
    int card95 : 0x0148902C, 0x1dac;
    int card96 : 0x0148902C, 0x1dfc;
    int card97 : 0x0148902C, 0x1e4c;
    int card98 : 0x0148902C, 0x1e9c;
    int card99 : 0x0148902C, 0x1eec;
    int card100 : 0x0148902C, 0x1f3c;
    
    int achievement1 : 0x0148902C, 0x4;
    int achievement2 : 0x0148902C, 0x54;
    int achievement3 : 0x0148902C, 0xa4;
    int achievement4 : 0x0148902C, 0xf4;
    int achievement5 : 0x0148902C, 0x144;
    int achievement6 : 0x0148902C, 0x194;
    int achievement7 : 0x0148902C, 0x1e4;
    int achievement8 : 0x0148902C, 0x234;
    int achievement9 : 0x0148902C, 0x284;
    int achievement10 : 0x0148902C, 0x2d4;
    int achievement11 : 0x0148902C, 0x324;
    int achievement12 : 0x0148902C, 0x374;
    int achievement13 : 0x0148902C, 0x3c4;
    int achievement14 : 0x0148902C, 0x414;
    int achievement15 : 0x0148902C, 0x464;
    int achievement16 : 0x0148902C, 0x4b4;
    int achievement17 : 0x0148902C, 0x504;
    int achievement18 : 0x0148902C, 0x554;
    int achievement19 : 0x0148902C, 0x5a4;
    int achievement20 : 0x0148902C, 0x5f4;
    int achievement21 : 0x0148902C, 0x644;
    int achievement22 : 0x0148902C, 0x694;
    int achievement23 : 0x0148902C, 0x6e4;
    int achievement24 : 0x0148902C, 0x734;
    int achievement25 : 0x0148902C, 0x784;
    int achievement26 : 0x0148902C, 0x7d4;
    int achievement27 : 0x0148902C, 0x824;
    int achievement28 : 0x0148902C, 0x874;
    int achievement29 : 0x0148902C, 0x8c4;
    int achievement30 : 0x0148902C, 0x914;
    int achievement31 : 0x0148902C, 0x964;
    int achievement32 : 0x0148902C, 0x9b4;
    int achievement33 : 0x0148902C, 0xa04;
    int achievement34 : 0x0148902C, 0xa54;
    int achievement35 : 0x0148902C, 0xaa4;
    int achievement36 : 0x0148902C, 0xaf4;
    int achievement37 : 0x0148902C, 0xb44;
    int achievement38 : 0x0148902C, 0xb94;
    int achievement39 : 0x0148902C, 0xbe4;
    int achievement40 : 0x0148902C, 0xc34;
    int achievement41 : 0x0148902C, 0xc84;
    int achievement42 : 0x0148902C, 0xcd4;
    int achievement43 : 0x0148902C, 0xd24;
    int achievement44 : 0x0148902C, 0xd74;
    int achievement45 : 0x0148902C, 0xdc4;
    int achievement46 : 0x0148902C, 0xe14;
    int achievement47 : 0x0148902C, 0xe64;
    int achievement48 : 0x0148902C, 0xeb4;
    int achievement49 : 0x0148902C, 0xf04;
    int achievement50 : 0x0148902C, 0xf54;
    int achievement51 : 0x0148902C, 0xfa4;
    int achievement52 : 0x0148902C, 0xff4;
    int achievement53 : 0x0148902C, 0x1044;
    int achievement54 : 0x0148902C, 0x1094;
    int achievement55 : 0x0148902C, 0x10e4;
    int achievement56 : 0x0148902C, 0x1134;
    int achievement57 : 0x0148902C, 0x1184;
    int achievement58 : 0x0148902C, 0x11d4;
    int achievement59 : 0x0148902C, 0x1224;
    int achievement60 : 0x0148902C, 0x1274;
    int achievement61 : 0x0148902C, 0x12c4;
    int achievement62 : 0x0148902C, 0x1314;
    int achievement63 : 0x0148902C, 0x1364;
    int achievement64 : 0x0148902C, 0x13b4;
    int achievement65 : 0x0148902C, 0x1404;
    int achievement66 : 0x0148902C, 0x1454;
    int achievement67 : 0x0148902C, 0x14a4;
    int achievement68 : 0x0148902C, 0x14f4;
    int achievement69 : 0x0148902C, 0x1544;
    int achievement70 : 0x0148902C, 0x1594;
    int achievement71 : 0x0148902C, 0x15e4;
    int achievement72 : 0x0148902C, 0x1634;
    int achievement73 : 0x0148902C, 0x1684;
    int achievement74 : 0x0148902C, 0x16d4;
    int achievement75 : 0x0148902C, 0x1724;
    int achievement76 : 0x0148902C, 0x1774;
    int achievement77 : 0x0148902C, 0x17c4;
    int achievement78 : 0x0148902C, 0x1814;
    int achievement79 : 0x0148902C, 0x1864;
    int achievement80 : 0x0148902C, 0x18b4;
    int achievement81 : 0x0148902C, 0x1904;
    int achievement82 : 0x0148902C, 0x1954;
    int achievement83 : 0x0148902C, 0x19a4;
    int achievement84 : 0x0148902C, 0x19f4;
    int achievement85 : 0x0148902C, 0x1a44;
    int achievement86 : 0x0148902C, 0x1a94;
    int achievement87 : 0x0148902C, 0x1ae4;
    int achievement88 : 0x0148902C, 0x1b34;
    int achievement89 : 0x0148902C, 0x1b84;
    int achievement90 : 0x0148902C, 0x1bd4;
    int achievement91 : 0x0148902C, 0x1c24;
    int achievement92 : 0x0148902C, 0x1c74;
    int achievement93 : 0x0148902C, 0x1cc4;
    int achievement94 : 0x0148902C, 0x1d14;
    int achievement95 : 0x0148902C, 0x1d64;
    int achievement96 : 0x0148902C, 0x1db4;
    int achievement97 : 0x0148902C, 0x1e04;
    int achievement98 : 0x0148902C, 0x1e54;
    int achievement99 : 0x0148902C, 0x1ea4;
    int achievement100 : 0x0148902C, 0x1ef4;
}

state("FP", "1.20.6")
{
    int frame : "FP.exe", 0x1DD4D50;
}

state("FP", "1.20.4")
{
    int frame : "FP.exe", 0x1DAE338;
}

startup
{
    // Occurs when the script starts, does not require the game to attach.
    // achievement38 is the Digspot achievement, the fastest to test.
	settings.Add("Display Card Tracker", false);
    settings.SetToolTip("Display Card Tracker", "Enable to display the Card Tracker window. Disable to hide it.");
    
    /* To highlights cards available on a level: 
    RoomDetails[roomID] = {Level Number, Array of IDs of Cards In Room, Array of IDs of Achievements Only Available In Room}
    LevelDetails[Level Number] = {Level Image}
    */
}

init 
{
    // Occurs on attaching to the game, and can happen more than once.
    vars.DetectVersion = new Action (() => 
	{
    
    // Version Detection
        vars.fp_size_1_20_6 = 32583680;
        vars.fp_size_1_20_4 = 32362496;
        vars.fp_size_1_21_5_beta = 1;
        vars.fp_size_1_21_5 = 28114944;
        
        version = "UNKNOWN";
        print("@@@@@ MODULE SIZE: " + modules.First().ModuleMemorySize.ToString());
        if (modules.First().ModuleMemorySize == vars.fp_size_1_20_6)
            version = "1.20.6";
        else if (modules.First().ModuleMemorySize == vars.fp_size_1_20_4)
            version = "1.20.4";
        else if (modules.First().ModuleMemorySize == vars.fp_size_1_21_5_beta)
            version = "steam-1.21.5-win-beta";
        else if (modules.First().ModuleMemorySize == vars.fp_size_1_21_5)
            version = "steam-1.21.5-win";
        print("@@@@@ Detected Version: " + version);
    });
    vars.DetectVersion();
}