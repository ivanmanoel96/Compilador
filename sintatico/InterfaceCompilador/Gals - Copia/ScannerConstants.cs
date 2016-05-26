﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCompilador.Gals
{
    public abstract class ScannerConstants
    {
        public int[] SCANNER_TABLE_INDEXES =
        {
            0,
            57,
            57,
            58,
            250,
            250,
            250,
            250,
            250,
            250,
            250,
            251,
            262,
            262,
            262,
            264,
            264,
            265,
            265,
            265,
            317,
            370,
            423,
            476,
            529,
            529,
            529,
            529,
            529,
            722,
            732,
            732,
            732,
            732,
            758,
            810,
            862,
            914,
            966,
            1159,
            1169,
            1231,
            1293,
            1355,
            1417,
            1417
        };

        public int[,] SCANNER_TABLE = new int[,]
        {
            {9, 1},
            {10, 1},
            {32, 1},
            {33, 2},
            {34, 3},
            {40, 4},
            {41, 5},
            {42, 6},
            {43, 7},
            {44, 8},
            {45, 9},
            {47, 10},
            {48, 11},
            {49, 11},
            {50, 11},
            {51, 11},
            {52, 11},
            {53, 11},
            {54, 11},
            {55, 11},
            {56, 11},
            {57, 11},
            {58, 12},
            {59, 13},
            {60, 14},
            {61, 15},
            {62, 16},
            {91, 17},
            {93, 18},
            {97, 19},
            {98, 20},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 21},
            {103, 19},
            {104, 19},
            {105, 22},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 23},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {123, 24},
            {125, 25},
            {61, 26},
            {9, 3},
            {13, 3},
            {32, 3},
            {33, 3},
            {34, 27},
            {35, 3},
            {36, 3},
            {37, 3},
            {38, 3},
            {39, 3},
            {40, 3},
            {41, 3},
            {42, 3},
            {43, 3},
            {44, 3},
            {45, 3},
            {46, 3},
            {47, 3},
            {48, 3},
            {49, 3},
            {50, 3},
            {51, 3},
            {52, 3},
            {53, 3},
            {54, 3},
            {55, 3},
            {56, 3},
            {57, 3},
            {58, 3},
            {59, 3},
            {60, 3},
            {61, 3},
            {62, 3},
            {63, 3},
            {64, 3},
            {65, 3},
            {66, 3},
            {67, 3},
            {68, 3},
            {69, 3},
            {70, 3},
            {71, 3},
            {72, 3},
            {73, 3},
            {74, 3},
            {75, 3},
            {76, 3},
            {77, 3},
            {78, 3},
            {79, 3},
            {80, 3},
            {81, 3},
            {82, 3},
            {83, 3},
            {84, 3},
            {85, 3},
            {86, 3},
            {87, 3},
            {88, 3},
            {89, 3},
            {90, 3},
            {91, 3},
            {92, 3},
            {93, 3},
            {94, 3},
            {95, 3},
            {96, 3},
            {97, 3},
            {98, 3},
            {99, 3},
            {100, 3},
            {101, 3},
            {102, 3},
            {103, 3},
            {104, 3},
            {105, 3},
            {106, 3},
            {107, 3},
            {108, 3},
            {109, 3},
            {110, 3},
            {111, 3},
            {112, 3},
            {113, 3},
            {114, 3},
            {115, 3},
            {116, 3},
            {117, 3},
            {118, 3},
            {119, 3},
            {120, 3},
            {121, 3},
            {122, 3},
            {123, 3},
            {124, 3},
            {125, 3},
            {126, 3},
            {161, 3},
            {162, 3},
            {163, 3},
            {164, 3},
            {165, 3},
            {166, 3},
            {167, 3},
            {168, 3},
            {169, 3},
            {170, 3},
            {171, 3},
            {172, 3},
            {173, 3},
            {174, 3},
            {175, 3},
            {176, 3},
            {177, 3},
            {178, 3},
            {179, 3},
            {180, 3},
            {181, 3},
            {182, 3},
            {183, 3},
            {184, 3},
            {185, 3},
            {186, 3},
            {187, 3},
            {188, 3},
            {189, 3},
            {190, 3},
            {191, 3},
            {192, 3},
            {193, 3},
            {194, 3},
            {195, 3},
            {196, 3},
            {197, 3},
            {198, 3},
            {199, 3},
            {200, 3},
            {201, 3},
            {202, 3},
            {203, 3},
            {204, 3},
            {205, 3},
            {206, 3},
            {207, 3},
            {208, 3},
            {209, 3},
            {210, 3},
            {211, 3},
            {212, 3},
            {213, 3},
            {214, 3},
            {215, 3},
            {216, 3},
            {217, 3},
            {218, 3},
            {219, 3},
            {220, 3},
            {221, 3},
            {222, 3},
            {223, 3},
            {224, 3},
            {225, 3},
            {226, 3},
            {227, 3},
            {228, 3},
            {229, 3},
            {230, 3},
            {231, 3},
            {232, 3},
            {233, 3},
            {234, 3},
            {235, 3},
            {236, 3},
            {237, 3},
            {238, 3},
            {239, 3},
            {240, 3},
            {241, 3},
            {242, 3},
            {243, 3},
            {244, 3},
            {245, 3},
            {246, 3},
            {247, 3},
            {248, 3},
            {249, 3},
            {250, 3},
            {251, 3},
            {252, 3},
            {253, 3},
            {254, 3},
            {255, 3},
            {42, 28},
            {44, 29},
            {48, 11},
            {49, 11},
            {50, 11},
            {51, 11},
            {52, 11},
            {53, 11},
            {54, 11},
            {55, 11},
            {56, 11},
            {57, 11},
            {45, 30},
            {61, 31},
            {61, 32},
            {65, 33},
            {66, 33},
            {67, 33},
            {68, 33},
            {69, 33},
            {70, 33},
            {71, 33},
            {72, 33},
            {73, 33},
            {74, 33},
            {75, 33},
            {76, 33},
            {77, 33},
            {78, 33},
            {79, 33},
            {80, 33},
            {81, 33},
            {82, 33},
            {83, 33},
            {84, 33},
            {85, 33},
            {86, 33},
            {87, 33},
            {88, 33},
            {89, 33},
            {90, 33},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {65, 33},
            {66, 33},
            {67, 33},
            {68, 33},
            {69, 33},
            {70, 33},
            {71, 33},
            {72, 33},
            {73, 33},
            {74, 33},
            {75, 33},
            {76, 33},
            {77, 33},
            {78, 33},
            {79, 33},
            {80, 33},
            {81, 33},
            {82, 33},
            {83, 33},
            {84, 33},
            {85, 33},
            {86, 33},
            {87, 33},
            {88, 33},
            {89, 33},
            {90, 33},
            {95, 34},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {65, 33},
            {66, 33},
            {67, 33},
            {68, 33},
            {69, 33},
            {70, 33},
            {71, 33},
            {72, 33},
            {73, 33},
            {74, 33},
            {75, 33},
            {76, 33},
            {77, 33},
            {78, 33},
            {79, 33},
            {80, 33},
            {81, 33},
            {82, 33},
            {83, 33},
            {84, 33},
            {85, 33},
            {86, 33},
            {87, 33},
            {88, 33},
            {89, 33},
            {90, 33},
            {95, 35},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {65, 33},
            {66, 33},
            {67, 33},
            {68, 33},
            {69, 33},
            {70, 33},
            {71, 33},
            {72, 33},
            {73, 33},
            {74, 33},
            {75, 33},
            {76, 33},
            {77, 33},
            {78, 33},
            {79, 33},
            {80, 33},
            {81, 33},
            {82, 33},
            {83, 33},
            {84, 33},
            {85, 33},
            {86, 33},
            {87, 33},
            {88, 33},
            {89, 33},
            {90, 33},
            {95, 36},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {65, 33},
            {66, 33},
            {67, 33},
            {68, 33},
            {69, 33},
            {70, 33},
            {71, 33},
            {72, 33},
            {73, 33},
            {74, 33},
            {75, 33},
            {76, 33},
            {77, 33},
            {78, 33},
            {79, 33},
            {80, 33},
            {81, 33},
            {82, 33},
            {83, 33},
            {84, 33},
            {85, 33},
            {86, 33},
            {87, 33},
            {88, 33},
            {89, 33},
            {90, 33},
            {95, 37},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {9, 28},
            {10, 28},
            {13, 28},
            {32, 28},
            {33, 28},
            {34, 28},
            {35, 28},
            {36, 28},
            {37, 28},
            {38, 28},
            {39, 28},
            {40, 28},
            {41, 28},
            {42, 38},
            {43, 28},
            {44, 28},
            {45, 28},
            {46, 28},
            {47, 28},
            {48, 28},
            {49, 28},
            {50, 28},
            {51, 28},
            {52, 28},
            {53, 28},
            {54, 28},
            {55, 28},
            {56, 28},
            {57, 28},
            {58, 28},
            {59, 28},
            {60, 28},
            {61, 28},
            {62, 28},
            {63, 28},
            {64, 28},
            {65, 28},
            {66, 28},
            {67, 28},
            {68, 28},
            {69, 28},
            {70, 28},
            {71, 28},
            {72, 28},
            {73, 28},
            {74, 28},
            {75, 28},
            {76, 28},
            {77, 28},
            {78, 28},
            {79, 28},
            {80, 28},
            {81, 28},
            {82, 28},
            {83, 28},
            {84, 28},
            {85, 28},
            {86, 28},
            {87, 28},
            {88, 28},
            {89, 28},
            {90, 28},
            {91, 28},
            {92, 28},
            {93, 28},
            {94, 28},
            {95, 28},
            {96, 28},
            {97, 28},
            {98, 28},
            {99, 28},
            {100, 28},
            {101, 28},
            {102, 28},
            {103, 28},
            {104, 28},
            {105, 28},
            {106, 28},
            {107, 28},
            {108, 28},
            {109, 28},
            {110, 28},
            {111, 28},
            {112, 28},
            {113, 28},
            {114, 28},
            {115, 28},
            {116, 28},
            {117, 28},
            {118, 28},
            {119, 28},
            {120, 28},
            {121, 28},
            {122, 28},
            {123, 28},
            {124, 28},
            {125, 28},
            {126, 28},
            {161, 28},
            {162, 28},
            {163, 28},
            {164, 28},
            {165, 28},
            {166, 28},
            {167, 28},
            {168, 28},
            {169, 28},
            {170, 28},
            {171, 28},
            {172, 28},
            {173, 28},
            {174, 28},
            {175, 28},
            {176, 28},
            {177, 28},
            {178, 28},
            {179, 28},
            {180, 28},
            {181, 28},
            {182, 28},
            {183, 28},
            {184, 28},
            {185, 28},
            {186, 28},
            {187, 28},
            {188, 28},
            {189, 28},
            {190, 28},
            {191, 28},
            {192, 28},
            {193, 28},
            {194, 28},
            {195, 28},
            {196, 28},
            {197, 28},
            {198, 28},
            {199, 28},
            {200, 28},
            {201, 28},
            {202, 28},
            {203, 28},
            {204, 28},
            {205, 28},
            {206, 28},
            {207, 28},
            {208, 28},
            {209, 28},
            {210, 28},
            {211, 28},
            {212, 28},
            {213, 28},
            {214, 28},
            {215, 28},
            {216, 28},
            {217, 28},
            {218, 28},
            {219, 28},
            {220, 28},
            {221, 28},
            {222, 28},
            {223, 28},
            {224, 28},
            {225, 28},
            {226, 28},
            {227, 28},
            {228, 28},
            {229, 28},
            {230, 28},
            {231, 28},
            {232, 28},
            {233, 28},
            {234, 28},
            {235, 28},
            {236, 28},
            {237, 28},
            {238, 28},
            {239, 28},
            {240, 28},
            {241, 28},
            {242, 28},
            {243, 28},
            {244, 28},
            {245, 28},
            {246, 28},
            {247, 28},
            {248, 28},
            {249, 28},
            {250, 28},
            {251, 28},
            {252, 28},
            {253, 28},
            {254, 28},
            {255, 28},
            {48, 39},
            {49, 39},
            {50, 39},
            {51, 39},
            {52, 39},
            {53, 39},
            {54, 39},
            {55, 39},
            {56, 39},
            {57, 39},
            {97, 19},
            {98, 19},
            {99, 19},
            {100, 19},
            {101, 19},
            {102, 19},
            {103, 19},
            {104, 19},
            {105, 19},
            {106, 19},
            {107, 19},
            {108, 19},
            {109, 19},
            {110, 19},
            {111, 19},
            {112, 19},
            {113, 19},
            {114, 19},
            {115, 19},
            {116, 19},
            {117, 19},
            {118, 19},
            {119, 19},
            {120, 19},
            {121, 19},
            {122, 19},
            {65, 40},
            {66, 40},
            {67, 40},
            {68, 40},
            {69, 40},
            {70, 40},
            {71, 40},
            {72, 40},
            {73, 40},
            {74, 40},
            {75, 40},
            {76, 40},
            {77, 40},
            {78, 40},
            {79, 40},
            {80, 40},
            {81, 40},
            {82, 40},
            {83, 40},
            {84, 40},
            {85, 40},
            {86, 40},
            {87, 40},
            {88, 40},
            {89, 40},
            {90, 40},
            {97, 40},
            {98, 40},
            {99, 40},
            {100, 40},
            {101, 40},
            {102, 40},
            {103, 40},
            {104, 40},
            {105, 40},
            {106, 40},
            {107, 40},
            {108, 40},
            {109, 40},
            {110, 40},
            {111, 40},
            {112, 40},
            {113, 40},
            {114, 40},
            {115, 40},
            {116, 40},
            {117, 40},
            {118, 40},
            {119, 40},
            {120, 40},
            {121, 40},
            {122, 40},
            {65, 41},
            {66, 41},
            {67, 41},
            {68, 41},
            {69, 41},
            {70, 41},
            {71, 41},
            {72, 41},
            {73, 41},
            {74, 41},
            {75, 41},
            {76, 41},
            {77, 41},
            {78, 41},
            {79, 41},
            {80, 41},
            {81, 41},
            {82, 41},
            {83, 41},
            {84, 41},
            {85, 41},
            {86, 41},
            {87, 41},
            {88, 41},
            {89, 41},
            {90, 41},
            {97, 41},
            {98, 41},
            {99, 41},
            {100, 41},
            {101, 41},
            {102, 41},
            {103, 41},
            {104, 41},
            {105, 41},
            {106, 41},
            {107, 41},
            {108, 41},
            {109, 41},
            {110, 41},
            {111, 41},
            {112, 41},
            {113, 41},
            {114, 41},
            {115, 41},
            {116, 41},
            {117, 41},
            {118, 41},
            {119, 41},
            {120, 41},
            {121, 41},
            {122, 41},
            {65, 42},
            {66, 42},
            {67, 42},
            {68, 42},
            {69, 42},
            {70, 42},
            {71, 42},
            {72, 42},
            {73, 42},
            {74, 42},
            {75, 42},
            {76, 42},
            {77, 42},
            {78, 42},
            {79, 42},
            {80, 42},
            {81, 42},
            {82, 42},
            {83, 42},
            {84, 42},
            {85, 42},
            {86, 42},
            {87, 42},
            {88, 42},
            {89, 42},
            {90, 42},
            {97, 42},
            {98, 42},
            {99, 42},
            {100, 42},
            {101, 42},
            {102, 42},
            {103, 42},
            {104, 42},
            {105, 42},
            {106, 42},
            {107, 42},
            {108, 42},
            {109, 42},
            {110, 42},
            {111, 42},
            {112, 42},
            {113, 42},
            {114, 42},
            {115, 42},
            {116, 42},
            {117, 42},
            {118, 42},
            {119, 42},
            {120, 42},
            {121, 42},
            {122, 42},
            {65, 43},
            {66, 43},
            {67, 43},
            {68, 43},
            {69, 43},
            {70, 43},
            {71, 43},
            {72, 43},
            {73, 43},
            {74, 43},
            {75, 43},
            {76, 43},
            {77, 43},
            {78, 43},
            {79, 43},
            {80, 43},
            {81, 43},
            {82, 43},
            {83, 43},
            {84, 43},
            {85, 43},
            {86, 43},
            {87, 43},
            {88, 43},
            {89, 43},
            {90, 43},
            {97, 43},
            {98, 43},
            {99, 43},
            {100, 43},
            {101, 43},
            {102, 43},
            {103, 43},
            {104, 43},
            {105, 43},
            {106, 43},
            {107, 43},
            {108, 43},
            {109, 43},
            {110, 43},
            {111, 43},
            {112, 43},
            {113, 43},
            {114, 43},
            {115, 43},
            {116, 43},
            {117, 43},
            {118, 43},
            {119, 43},
            {120, 43},
            {121, 43},
            {122, 43},
            {9, 28},
            {10, 28},
            {13, 28},
            {32, 28},
            {33, 28},
            {34, 28},
            {35, 28},
            {36, 28},
            {37, 28},
            {38, 28},
            {39, 28},
            {40, 28},
            {41, 28},
            {42, 38},
            {43, 28},
            {44, 28},
            {45, 28},
            {46, 28},
            {47, 44},
            {48, 28},
            {49, 28},
            {50, 28},
            {51, 28},
            {52, 28},
            {53, 28},
            {54, 28},
            {55, 28},
            {56, 28},
            {57, 28},
            {58, 28},
            {59, 28},
            {60, 28},
            {61, 28},
            {62, 28},
            {63, 28},
            {64, 28},
            {65, 28},
            {66, 28},
            {67, 28},
            {68, 28},
            {69, 28},
            {70, 28},
            {71, 28},
            {72, 28},
            {73, 28},
            {74, 28},
            {75, 28},
            {76, 28},
            {77, 28},
            {78, 28},
            {79, 28},
            {80, 28},
            {81, 28},
            {82, 28},
            {83, 28},
            {84, 28},
            {85, 28},
            {86, 28},
            {87, 28},
            {88, 28},
            {89, 28},
            {90, 28},
            {91, 28},
            {92, 28},
            {93, 28},
            {94, 28},
            {95, 28},
            {96, 28},
            {97, 28},
            {98, 28},
            {99, 28},
            {100, 28},
            {101, 28},
            {102, 28},
            {103, 28},
            {104, 28},
            {105, 28},
            {106, 28},
            {107, 28},
            {108, 28},
            {109, 28},
            {110, 28},
            {111, 28},
            {112, 28},
            {113, 28},
            {114, 28},
            {115, 28},
            {116, 28},
            {117, 28},
            {118, 28},
            {119, 28},
            {120, 28},
            {121, 28},
            {122, 28},
            {123, 28},
            {124, 28},
            {125, 28},
            {126, 28},
            {161, 28},
            {162, 28},
            {163, 28},
            {164, 28},
            {165, 28},
            {166, 28},
            {167, 28},
            {168, 28},
            {169, 28},
            {170, 28},
            {171, 28},
            {172, 28},
            {173, 28},
            {174, 28},
            {175, 28},
            {176, 28},
            {177, 28},
            {178, 28},
            {179, 28},
            {180, 28},
            {181, 28},
            {182, 28},
            {183, 28},
            {184, 28},
            {185, 28},
            {186, 28},
            {187, 28},
            {188, 28},
            {189, 28},
            {190, 28},
            {191, 28},
            {192, 28},
            {193, 28},
            {194, 28},
            {195, 28},
            {196, 28},
            {197, 28},
            {198, 28},
            {199, 28},
            {200, 28},
            {201, 28},
            {202, 28},
            {203, 28},
            {204, 28},
            {205, 28},
            {206, 28},
            {207, 28},
            {208, 28},
            {209, 28},
            {210, 28},
            {211, 28},
            {212, 28},
            {213, 28},
            {214, 28},
            {215, 28},
            {216, 28},
            {217, 28},
            {218, 28},
            {219, 28},
            {220, 28},
            {221, 28},
            {222, 28},
            {223, 28},
            {224, 28},
            {225, 28},
            {226, 28},
            {227, 28},
            {228, 28},
            {229, 28},
            {230, 28},
            {231, 28},
            {232, 28},
            {233, 28},
            {234, 28},
            {235, 28},
            {236, 28},
            {237, 28},
            {238, 28},
            {239, 28},
            {240, 28},
            {241, 28},
            {242, 28},
            {243, 28},
            {244, 28},
            {245, 28},
            {246, 28},
            {247, 28},
            {248, 28},
            {249, 28},
            {250, 28},
            {251, 28},
            {252, 28},
            {253, 28},
            {254, 28},
            {255, 28},
            {48, 39},
            {49, 39},
            {50, 39},
            {51, 39},
            {52, 39},
            {53, 39},
            {54, 39},
            {55, 39},
            {56, 39},
            {57, 39},
            {48, 40},
            {49, 40},
            {50, 40},
            {51, 40},
            {52, 40},
            {53, 40},
            {54, 40},
            {55, 40},
            {56, 40},
            {57, 40},
            {65, 40},
            {66, 40},
            {67, 40},
            {68, 40},
            {69, 40},
            {70, 40},
            {71, 40},
            {72, 40},
            {73, 40},
            {74, 40},
            {75, 40},
            {76, 40},
            {77, 40},
            {78, 40},
            {79, 40},
            {80, 40},
            {81, 40},
            {82, 40},
            {83, 40},
            {84, 40},
            {85, 40},
            {86, 40},
            {87, 40},
            {88, 40},
            {89, 40},
            {90, 40},
            {97, 40},
            {98, 40},
            {99, 40},
            {100, 40},
            {101, 40},
            {102, 40},
            {103, 40},
            {104, 40},
            {105, 40},
            {106, 40},
            {107, 40},
            {108, 40},
            {109, 40},
            {110, 40},
            {111, 40},
            {112, 40},
            {113, 40},
            {114, 40},
            {115, 40},
            {116, 40},
            {117, 40},
            {118, 40},
            {119, 40},
            {120, 40},
            {121, 40},
            {122, 40},
            {48, 41},
            {49, 41},
            {50, 41},
            {51, 41},
            {52, 41},
            {53, 41},
            {54, 41},
            {55, 41},
            {56, 41},
            {57, 41},
            {65, 41},
            {66, 41},
            {67, 41},
            {68, 41},
            {69, 41},
            {70, 41},
            {71, 41},
            {72, 41},
            {73, 41},
            {74, 41},
            {75, 41},
            {76, 41},
            {77, 41},
            {78, 41},
            {79, 41},
            {80, 41},
            {81, 41},
            {82, 41},
            {83, 41},
            {84, 41},
            {85, 41},
            {86, 41},
            {87, 41},
            {88, 41},
            {89, 41},
            {90, 41},
            {97, 41},
            {98, 41},
            {99, 41},
            {100, 41},
            {101, 41},
            {102, 41},
            {103, 41},
            {104, 41},
            {105, 41},
            {106, 41},
            {107, 41},
            {108, 41},
            {109, 41},
            {110, 41},
            {111, 41},
            {112, 41},
            {113, 41},
            {114, 41},
            {115, 41},
            {116, 41},
            {117, 41},
            {118, 41},
            {119, 41},
            {120, 41},
            {121, 41},
            {122, 41},
            {48, 42},
            {49, 42},
            {50, 42},
            {51, 42},
            {52, 42},
            {53, 42},
            {54, 42},
            {55, 42},
            {56, 42},
            {57, 42},
            {65, 42},
            {66, 42},
            {67, 42},
            {68, 42},
            {69, 42},
            {70, 42},
            {71, 42},
            {72, 42},
            {73, 42},
            {74, 42},
            {75, 42},
            {76, 42},
            {77, 42},
            {78, 42},
            {79, 42},
            {80, 42},
            {81, 42},
            {82, 42},
            {83, 42},
            {84, 42},
            {85, 42},
            {86, 42},
            {87, 42},
            {88, 42},
            {89, 42},
            {90, 42},
            {97, 42},
            {98, 42},
            {99, 42},
            {100, 42},
            {101, 42},
            {102, 42},
            {103, 42},
            {104, 42},
            {105, 42},
            {106, 42},
            {107, 42},
            {108, 42},
            {109, 42},
            {110, 42},
            {111, 42},
            {112, 42},
            {113, 42},
            {114, 42},
            {115, 42},
            {116, 42},
            {117, 42},
            {118, 42},
            {119, 42},
            {120, 42},
            {121, 42},
            {122, 42},
            {48, 43},
            {49, 43},
            {50, 43},
            {51, 43},
            {52, 43},
            {53, 43},
            {54, 43},
            {55, 43},
            {56, 43},
            {57, 43},
            {65, 43},
            {66, 43},
            {67, 43},
            {68, 43},
            {69, 43},
            {70, 43},
            {71, 43},
            {72, 43},
            {73, 43},
            {74, 43},
            {75, 43},
            {76, 43},
            {77, 43},
            {78, 43},
            {79, 43},
            {80, 43},
            {81, 43},
            {82, 43},
            {83, 43},
            {84, 43},
            {85, 43},
            {86, 43},
            {87, 43},
            {88, 43},
            {89, 43},
            {90, 43},
            {97, 43},
            {98, 43},
            {99, 43},
            {100, 43},
            {101, 43},
            {102, 43},
            {103, 43},
            {104, 43},
            {105, 43},
            {106, 43},
            {107, 43},
            {108, 43},
            {109, 43},
            {110, 43},
            {111, 43},
            {112, 43},
            {113, 43},
            {114, 43},
            {115, 43},
            {116, 43},
            {117, 43},
            {118, 43},
            {119, 43},
            {120, 43},
            {121, 43},
            {122, 43}
        };

        public int[] TOKEN_STATE = { -2, 0, -1, -1, 7, 8, 13, 11, 2, 12, 14, 27, 3, 4, 18, 16, 20, 5, 6, 22, 22, 22, 22, 22, 9, 10, 17, 29, -2, -1, 15, 19, 21, -1, -1, -1, -1, -1, -2, 28, 26, 24, 23, 25, 30 };

        public string[] SCANNER_ERROR =
        {
            "símbolo inválido",
            "",
            "Erro identificando \"!=\"",
            "constante string não finalizada",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "comentário de bloco não finalizado",
            "Erro identificando constanteFloat",
            "",
            "",
            "",
            "Erro identificando palavraReservada",
            "Erro identificando identificadorBool",
            "Erro identificando identificadorFloat",
            "Erro identificando identificadorInt",
            "Erro identificando identificadorString",
            "Erro identificando comentarioBloco",
            "",
            "",
            "",
            "",
            "",
            ""
        };
    }
}
