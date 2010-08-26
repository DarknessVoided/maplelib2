﻿using System;

namespace MapleLib.WzLib.WzStructure.Data
{
    [Flags]
    public enum ItemTypes
    {
        None = 0x0,
        Tiles = 0x1,
        Objects = 0x2,
        Mobs = 0x4,
        NPCs = 0x8,
        Ropes = 0x10,
        Footholds = 0x20,
        Portals = 0x40,
        Chairs = 0x80,
        Reactors = 0x100,
        ToolTips = 0x200,
        Backgrounds = 0x400,
        Misc = 0x800,

        All = 0xFFF
    }

    [Flags]
    public enum FieldLimit //Credits to Koolk, LightPepsi, Bui
    {
        FIELDOPT_NONE = 0,
        FIELDOPT_MOVELIMIT = 1,
        FIELDOPT_SKILLLIMIT = 2,
        FIELDOPT_SUMMONLIMIT = 4,
        FIELDOPT_MYSTICDOORLIMIT = 8,
        FIELDOPT_MIGRATELIMIT = 0x10,
        FIELDOPT_PORTALSCROLLLIMIT = 0x20,
        FIELDOPT_TELEPORTITEMLIMIT = 0x40,
        FIELDOPT_MINIGAMELIMIT = 0x80,
        FIELDOPT_SPECIFICPORTALSCROLLLIMIT = 0x100,
        FIELDOPT_TAMINGMOBLIMIT = 0x200,
        FIELDOPT_STATCHANGEITEMCONSUMELIMIT = 0x400,
        FIELDOPT_PARTYBOSSCHANGELIMIT = 0x800,
        FIELDOPT_NOMOBCAPACITYLIMIT = 0x1000,
        FIELDOPT_WEDDINGINVITATIONLIMIT = 0x2000,
        FIELDOPT_CASHWEATHERCONSUMELIMIT = 0x4000,
        FIELDOPT_NOPET = 0x8000,
        FIELDOPT_ANTIMACROLIMIT = 0x10000,
        FIELDOPT_FALLDOWNLIMIT = 0x20000,
        FIELDOPT_SUMMONNPCLIMIT = 0x40000,
        FIELDOPT_NOEXPDECREASE = 0x80000,
        FIELDOPT_NODAMAGEONFALLING = 0x100000,
        FIELDOPT_PARCELOPENLIMIT = 0x200000,
        FIELDOPT_DROPLIMIT = 0x400000
    }

    public enum FieldType //Credits to Koolk for about half of them and me for the rest
    {
        FIELDTYPE_DEFAULT = 0,
        FIELDTYPE_SNOWBALL = 1,
        FIELDTYPE_CONTIMOVE = 2,
        FIELDTYPE_TOURNAMENT = 3,
        FIELDTYPE_COCONUT = 4,
        FIELDTYPE_OXQUIZ = 5,
        FIELDTYPE_PERSONALTIMELIMIT = 6,
        FIELDTYPE_WAITINGROOM = 7,
        FIELDTYPE_GUILDBOSS = 8,
        FIELDTYPE_LIMITEDVIEW = 9,
        FIELDTYPE_MONSTERCARNIVAL = 0xA,
        FIELDTYPE_MONSTERCARNIVALREVIVE = 0xB,
        FIELDTYPE_ZAKUM = 0xC,
        FIELDTYPE_ARIANTARENA = 0xD,
        FIELDTYPE_DOJANG = 0xE,
        FIELDTYPE_MONSTERCARNIVAL_S2 = 0xF,
        FIELDTYPE_MONSTERCARNIVALWAITINGROOM = 0x10,
        FIELDTYPE_COOKIEHOUSE = 0x11,
        FIELDTYPE_BALROG = 0x12,
        FIELDTYPE_BATTLEFIELD = 0x13,
        FIELDTYPE_SPACEGAGA = 0x14,
        FIELDTYPE_WITCHTOWER = 0x15,
        FIELDTYPE_ARANTUTORIAL = 0x16,
        FIELDTYPE_MASSACRE = 0x17,
        FIELDTYPE_MASSACRE_RESULT = 0x18,
        FIELDTYPE_PARTYRAID = 0x19,
        FIELDTYPE_PARTYRAID_BOSS = 0x1A,
        FIELDTYPE_PARTYRAID_RESULT = 0x1B,
        FIELDTYPE_NODRAGON = 0x1C,
        FIELDTYPE_DYNAMICFOOTHOLD = 0x1D,
        FIELDTYPE_ESCORT = 0x1E,
        FIELDTYPE_ESCORT_RESULT = 0x1F,
        FIELDTYPE_HUNTINGADBALLOON = 0x20,
        FIELDTYPE_CHAOSZAKUM = 0x21,
        FIELDTYPE_KILLCOUNT = 0x22,
        FIELDTYPE_WEDDING = 0x3C,
        FIELDTYPE_WEDDINGPHOTO = 0x3D,
        FIELDTYPE_FISHINGKING = 0x4A,
        FIELDTYPE_SHOWABATH = 0x51,
        FIELDTYPE_BEGINNERCAMP = 0x52,
        FIELDTYPE_SNOWMAN = 1000,
        FIELDTYPE_SHOWASPA = 1001,
        FIELDTYPE_HORNTAILPQ = 1013,
        FIELDTYPE_CRIMSONWOODPQ = 1014
    }

    public enum PortalType //Credits to me and BluePoop
    {
        PORTALTYPE_STARTPOINT = 0x0, //sp
        PORTALTYPE_INVISIBLE = 0x1, //pi
        PORTALTYPE_VISIBLE = 0x2, //pv
        PORTALTYPE_COLLISION = 0x3, //pc
        PORTALTYPE_CHANGABLE = 0x4, //pg
        PORTALTYPE_CHANGABLE_INVISIBLE = 0x5, //pgi
        PORTALTYPE_TOWNPORTAL_POINT = 0x6, //tp
        PORTALTYPE_SCRIPT = 0x7, //ps
        PORTALTYPE_SCRIPT_INVISIBLE = 0x8, //psi
        PORTALTYPE_COLLISION_SCRIPT = 0x9, //pcs
        PORTALTYPE_HIDDEN = 0xA, //ph
        PORTALTYPE_SCRIPT_HIDDEN = 0xB, //psh
        PORTALTYPE_COLLISION_VERTICAL_JUMP = 0xC, //pcj
        PORTALTYPE_COLLISION_CUSTOM_IMPACT = 0xD, //pci
        PORTALTYPE_COLLISION_UNKNOWN_PCIG = 0xE //pcig
    }

    public enum MapType
    {
        RegularMap,
        MapLogin,
        CashShopPreview
    }

    public enum BackgroundType
    {
        Regular = 0,
        HorizontalTiling = 1,
        VerticalTiling = 2,
        HVTiling = 3,
        HorizontalMoving = 4,
        VerticalMoving = 5,
        HorizontalMovingHVTiling = 6,
        VerticalMovingHVTiling = 7
    }
}