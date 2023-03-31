namespace ESL_Tool
{
    public class Structure
    {
        public struct ESL_struct
        {
            public byte Active;
            public byte EnemyType;
            public byte Subtype;
            public byte Animation;
            public byte SightRange;
            public byte Equip1;
            public byte Equip2;
            public byte Weapon;
            public short Health;
            public byte unk1;
            public byte ReturnSpawn;
            public short PosX;
            public short PosY;
            public short PosZ;
            public short RotX;
            public short RotY;
            public short RotZ;
            public byte RoomID;
            public byte StageID;
            public byte unk2;
            public byte unk3;
            public byte unk4;
            public byte unk5;
            public byte unk6;
            public byte unk7;
        };
    }
    public class EnemyData
    {
        public Dictionary<string, string[]> emleon = new Dictionary<string, string[]>
        {
            { "em00: Invalid", new[] { "0x00 ---", "0x01 segundo" } },
            { "em01: Invalid", new[] { "0x00 ---" } },
            { "em02: Leon",    new[] { "0x00 Leon" }},
            { "em03: Ashley (HUD)", new[] { "0x00 Ashley" }},
            { "em04: Luis",    new[] { "0x00 Partner" }},
            { "em05: Ashley",  new[] { "0x00 Ashley" }},
            { "em06: Invalid", new[] { "0x00 Invalid" }},
            { "em07: Invalid", new[] { "0x00 Invalid" }},
            { "em08: Invalid", new[] { "0x00 Invalid" }},
            { "em09: Invalid", new[] { "0x00 Invalid" }},
            { "em0A: Invalid", new[] { "0x00 Invalid" }},
            { "em0B: Invalid", new[] { "0x00 Invalid" }},
            { "em0C: Invalid", new[] { "0x00 Invalid" }},
            { "em0D: Invalid", new[] { "0x00 Invalid" }},
            { "em0E: Jet-ski", new[] { "0x00 Jet-ski" }},
            { "em0F: Boat",    new[] { "0x00 Boat", "0x01 Boat", "0x02 Boat", "0x03 Boat", "0x04 Boat", "0x05 Boat", }},
            { "em10: Ganado",  new[] { "0x00 ???" }},
            { "em11: Zealot",  new[] { "0x07 Black", "0x08 Red" }},
            { "em12: Ganado",  new[] { "0x00 Don Jose", "0x01 Don Manuel", "0x03 Don Esteban", "0x04 Don Diego", "0x0B Maria", "0x0C Isabel" }},
            { "em13: Ganado",  new[] { "0x00 Don Jose", "0x01 Don Manuel", "0x03 Don Esteban", "0x04 Don Diego", "0x06 Merchant" }},
            { "em14: Zealot",  new[] { "0x06 Merchant", "0x07 Black", "0x08 Red" }},
            { "em15: Ganado",  new[] { "0x00 Don Jose", "0x03 Don Esteban", "0x04 Don Diego", "0x0B Maria" }},
            { "em16: Ganado",  new[] { "0x03 Don Esteban", "0x04 Don Diego", "0x0B Maria", "0x0C Isabel" }},
            { "em17: Ganado",  new[] { "0x00 Don Jose", "0x01 Don Manuel", "0x03 Don Esteban", "0x04 Don Diego", "0x0C Isabel" }},
            { "em18: Merchant",new[] { "0x00 Merchant", "0x01 Merchant", "0x06 Merchant", "0x07 Merchant" }},
            { "em19: Zealot",  new[] { "0x07 Black" }},
            { "em1A: Zealot",  new[] { "0x07 Black", "0x08 Red", "0x09 Blue" }},
            { "em1B: Zealot",  new[] { "0x07 Black", "0x0A Garrador" }},
            { "em1C: Zealot",  new[] { "0x09 Blue", "0x0A Garrador", "0x0D Armor Garrador" }},
            { "em1D: Soldier", new[] { "0x02 J.J", "0x0E Soldier 1", "0x0F Soldier 2", "0x10 Soldier 3", "0x11 Soldier 4", "0x12 Soldier 5", "0x13 Soldier 6", "0x14 Soldier 7", "0x15 Soldier 8" }},
            { "em1E: Soldier", new[] { "0x00 Soldier 1", "0x06 Merchant", "0x0E Soldier 2", "0x0F Soldier 3", "0x17 Soldier 4", "0x18 Soldier 5" }},
            { "em1F: Soldier", new[] { "0x0E Soldier 1", "0x0F Soldier 2", "0x10 Soldier 3", "0x18 Heavy Soldier" }},
            { "em20: Soldier", new[] { "0x0E Soldier 1", "0x0F Soldier 2", "0x10 Soldier 3", "0x11 Soldier 4", "0x12 Soldier 5", "0x13 Soldier 6", "0x14 Soldier 7", "0x15 Soldier 8", "0x16 Mega Salvador", "0x17 Soldier 8" } },
            { "em21: Dog",       new[] { "0x00 Farm dog", "0x01 Injured dog" } },
            { "em22: Colmillo",  new[] { "0x00 Colmillo" } },
            { "em23: Crow",      new[] { "0x00 Crow" } },
            { "em24: Snake ",    new[] { "0x00 Snake" } },
            { "em25: Parasite",  new[] { "0x00 Type 1", "0x07 Type 2" , "0x09 Type 3" } },
            { "em26: Cow",       new[] { "0x00 Black & white", "0x01 Brown" } },
            { "em27: Black Bass",new[] { "0x00 Small", "0x01 Big" } },
            { "em28: Chicken",   new[] { "0x00 Bright", "0x01 Dark" } },
            { "em29: Bat",       new[] { "0x00 Bat" } },
            { "em2A: Trap",      new[] { "0x00 Bear Trap", "0x02 Explosive" } },
            { "em2B: El Gigante",new[] { "0x00 Normal", "0x01 With Mask", "0x02 Second", "0x03 Chained" } },
            { "em2C: Verdugo",   new[] { "0x00 Normal", "0x01 Random Ceiling" } },
            { "em2D: Novistador",new[] { "0x00 Normal", "0x02 White", "0x04 Flying"} },
            { "em2E: Spider",    new[] { "0x00 Spider" } },
            { "em2F: Del Lago",  new[] { "0x00 Normal" } },
            { "em30: Saddler",   new[] { "0x00 Body/Legs", "0x01 Head" } },
            { "em31: Saddler v2",new[] { "0x00"} },
            { "em32: Unknown",   new[] { "0x00" } },
            { "em33: Invalid",   new[] { "0x00" } },
            { "em34: No. & No.", new[] { "0x00" } },
            { "em35: Bitores",   new[] { "0x00 1st Form", "0x01 2nd Form", "0x02 Legs" } },
            { "em36: Regenerator",  new[] { "0x00 Normal", "0x01 Normal", "0x02 Iron Maiden", "0x03 Iron Maiden" } },
            { "em37: Invalid",      new[] { "0x00" } },
            { "em38: Salazar",    new[] { "0x00 Boss", "0x01 Tentacle", "0x02 Tentacle", "0x03 Human" } },
            { "em39: Krauser",      new[] { "0x00 Human", "0x01 Human (story)", "0x02 Mutated", "0x03 Mutated (Ada)"} },
            { "em3A: Robot",        new[] { "0x00 Flying", "0x01 Flying", "0x02 Ground" } },
            { "em3B: Truck/Wagon",  new[] { "0x00 Truck", "0x01 Wagon (moves)", "0x02 Wagon (explodes)"} },
            { "em3C: Knight",       new[] { "0x00 Rusty", "0x01 Rusty", "0x02 Type 2", "0x03 Type 2" } },
            { "em3D: Helicopter",   new[] { "0x00 Helicopter" } },
            { "em3E: r22c Mark",    new[] { "0x00"} },
            { "em3F: Saddler Human",new[] { "0x00 Saddler"} },
            { "em40: Unknown",      new[] { "0x00"} },
            { "em41: Unknown",      new[] { "0x00"} },
            { "em42: SW Ganado",    new[] { "0x00 Don Jose", "0x01 Don Manuel", "0x03 Don Esteban", "0x0B Maria", "0x0C Isabel"} },
            { "em43: SW Soldier",   new[] { "0x00 Soldier (voice)" } },
            { "em44: SW Ganado",    new[] { "0x00 Don Jose", "0x03 Don Esteban", "0x04 Don Manuel", "0x0B Maria", "0x1A Don Manuel"} },
            { "em4E: SW Ship",      new[] { "0x00 Cannon", "0x01 Cannon" } },
        };

    }
}
