﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityTruckInteraction
{
    using Rage;

    internal static class ControlsToHelp
    {
        private static Dictionary<int, string> controls = new Dictionary<int, string>() 
        { 
            {0, "~INPUT_NEXT_CAMERA~"},
            {1, "~INPUT_LOOK_LR~"},
            {2, "~INPUT_LOOK_UD~"},
            {3, "~INPUT_LOOK_UP_ONLY~"},
            {4, "~INPUT_LOOK_DOWN_ONLY~"},
            {5, "~INPUT_LOOK_LEFT_ONLY~"},
            {6, "~INPUT_LOOK_RIGHT_ONLY~"},
            {7, "~INPUT_CINEMATIC_SLOWMO~"},
            {8, "~INPUT_SCRIPTED_FLY_UD~"},
            {9, "~INPUT_SCRIPTED_FLY_LR~"},
            {10, "~INPUT_SCRIPTED_FLY_ZUP~"},
            {11, "~INPUT_SCRIPTED_FLY_ZDOWN~"},
            {12, "~INPUT_WEAPON_WHEEL_UD~"},
            {13, "~INPUT_WEAPON_WHEEL_LR~"},
            {14, "~INPUT_WEAPON_WHEEL_NEXT~"},
            {15, "~INPUT_WEAPON_WHEEL_PREV~"},
            {16, "~INPUT_SELECT_NEXT_WEAPON~"},
            {17, "~INPUT_SELECT_PREV_WEAPON~"},
            {18, "~INPUT_SKIP_CUTSCENE~"},
            {19, "~INPUT_CHARACTER_WHEEL~"},
            {20, "~INPUT_MULTIPLAYER_INFO~"},
            {21, "~INPUT_SPRINT~"},
            {22, "~INPUT_JUMP~"},
            {23, "~INPUT_ENTER~"},
            {24, "~INPUT_ATTACK~"},
            {25, "~INPUT_AIM~"},
            {26, "~INPUT_LOOK_BEHIND~"},
            {27, "~INPUT_PHONE~"},
            {28, "~INPUT_SPECIAL_ABILITY~"},
            {29, "~INPUT_SPECIAL_ABILITY_SECONDARY~"},
            {30, "~INPUT_MOVE_LR~"},
            {31, "~INPUT_MOVE_UD~"},
            {32, "~INPUT_MOVE_UP_ONLY~"},
            {33, "~INPUT_MOVE_DOWN_ONLY~"},
            {34, "~INPUT_MOVE_LEFT_ONLY~"},
            {35, "~INPUT_MOVE_RIGHT_ONLY~"},
            {36, "~INPUT_DUCK~"},
            {37, "~INPUT_SELECT_WEAPON~"},
            {38, "~INPUT_PICKUP~"},
            {39, "~INPUT_SNIPER_ZOOM~"},
            {40, "~INPUT_SNIPER_ZOOM_IN_ONLY~"},
            {41, "~INPUT_SNIPER_ZOOM_OUT_ONLY~"},
            {42, "~INPUT_SNIPER_ZOOM_IN_SECONDARY~"},
            {43, "~INPUT_SNIPER_ZOOM_OUT_SECONDARY~"},
            {44, "~INPUT_COVER~"},
            {45, "~INPUT_RELOAD~"},
            {46, "~INPUT_TALK~"},
            {47, "~INPUT_DETONATE~"},
            {48, "~INPUT_HUD_SPECIAL~"},
            {49, "~INPUT_ARREST~"},
            {50, "~INPUT_ACCURATE_AIM~"},
            {51, "~INPUT_CONTEXT~"},
            {52, "~INPUT_CONTEXT_SECONDARY~"},
            {53, "~INPUT_WEAPON_SPECIAL~"},
            {54, "~INPUT_WEAPON_SPECIAL_TWO~"},
            {55, "~INPUT_DIVE~"},
            {56, "~INPUT_DROP_WEAPON~"},
            {57, "~INPUT_DROP_AMMO~"},
            {58, "~INPUT_THROW_GRENADE~"},
            {59, "~INPUT_VEH_MOVE_LR~"},
            {60, "~INPUT_VEH_MOVE_UD~"},
            {61, "~INPUT_VEH_MOVE_UP_ONLY~"},
            {62, "~INPUT_VEH_MOVE_DOWN_ONLY~"},
            {63, "~INPUT_VEH_MOVE_LEFT_ONLY~"},
            {64, "~INPUT_VEH_MOVE_RIGHT_ONLY~"},
            {65, "~INPUT_VEH_SPECIAL~"},
            {66, "~INPUT_VEH_GUN_LR~"},
            {67, "~INPUT_VEH_GUN_UD~"},
            {68, "~INPUT_VEH_AIM~"},
            {69, "~INPUT_VEH_ATTACK~"},
            {70, "~INPUT_VEH_ATTACK2~"},
            {71, "~INPUT_VEH_ACCELERATE~"},
            {72, "~INPUT_VEH_BRAKE~"},
            {73, "~INPUT_VEH_DUCK~"},
            {74, "~INPUT_VEH_HEADLIGHT~"},
            {75, "~INPUT_VEH_EXIT~"},
            {76, "~INPUT_VEH_HANDBRAKE~"},
            {77, "~INPUT_VEH_HOTWIRE_LEFT~"},
            {78, "~INPUT_VEH_HOTWIRE_RIGHT~"},
            {79, "~INPUT_VEH_LOOK_BEHIND~"},
            {80, "~INPUT_VEH_CIN_CAM~"},
            {81, "~INPUT_VEH_NEXT_RADIO~"},
            {82, "~INPUT_VEH_PREV_RADIO~"},
            {83, "~INPUT_VEH_NEXT_RADIO_TRACK~"},
            {84, "~INPUT_VEH_PREV_RADIO_TRACK~"},
            {85, "~INPUT_VEH_RADIO_WHEEL~"},
            {86, "~INPUT_VEH_HORN~"},
            {87, "~INPUT_VEH_FLY_THROTTLE_UP~"},
            {88, "~INPUT_VEH_FLY_THROTTLE_DOWN~"},
            {89, "~INPUT_VEH_FLY_YAW_LEFT~"},
            {90, "~INPUT_VEH_FLY_YAW_RIGHT~"},
            {91, "~INPUT_VEH_PASSENGER_AIM~"},
            {92, "~INPUT_VEH_PASSENGER_ATTACK~"},
            {93, "~INPUT_VEH_SPECIAL_ABILITY_FRANKLIN~"},
            {94, "~INPUT_VEH_STUNT_UD~"},
            {95, "~INPUT_VEH_CINEMATIC_UD~"},
            {96, "~INPUT_VEH_CINEMATIC_UP_ONLY~"},
            {97, "~INPUT_VEH_CINEMATIC_DOWN_ONLY~"},
            {98, "~INPUT_VEH_CINEMATIC_LR~"},
            {99, "~INPUT_VEH_SELECT_NEXT_WEAPON~"},
            {100, "~INPUT_VEH_SELECT_PREV_WEAPON~"},
            {101, "~INPUT_VEH_ROOF~"},
            {102, "~INPUT_VEH_JUMP~"},
            {103, "~INPUT_VEH_GRAPPLING_HOOK~"},
            {104, "~INPUT_VEH_SHUFFLE~"},
            {105, "~INPUT_VEH_DROP_PROJECTILE~"},
            {106, "~INPUT_VEH_MOUSE_CONTROL_OVERRIDE~"},
            {107, "~INPUT_VEH_FLY_ROLL_LR~"},
            {108, "~INPUT_VEH_FLY_ROLL_LEFT_ONLY~"},
            {109, "~INPUT_VEH_FLY_ROLL_RIGHT_ONLY~"},
            {110, "~INPUT_VEH_FLY_PITCH_UD~"},
            {111, "~INPUT_VEH_FLY_PITCH_UP_ONLY~"},
            {112, "~INPUT_VEH_FLY_PITCH_DOWN_ONLY~"},
            {113, "~INPUT_VEH_FLY_UNDERCARRIAGE~"},
            {114, "~INPUT_VEH_FLY_ATTACK~"},
            {115, "~INPUT_VEH_FLY_SELECT_NEXT_WEAPON~"},
            {116, "~INPUT_VEH_FLY_SELECT_PREV_WEAPON~"},
            {117, "~INPUT_VEH_FLY_SELECT_TARGET_LEFT~"},
            {118, "~INPUT_VEH_FLY_SELECT_TARGET_RIGHT~"},
            {119, "~INPUT_VEH_FLY_VERTICAL_FLIGHT_MODE~"},
            {120, "~INPUT_VEH_FLY_DUCK~"},
            {121, "~INPUT_VEH_FLY_ATTACK_CAMERA~"},
            {122, "~INPUT_VEH_FLY_MOUSE_CONTROL_OVERRIDE~"},
            {123, "~INPUT_VEH_SUB_TURN_LR~"},
            {124, "~INPUT_VEH_SUB_TURN_LEFT_ONLY~"},
            {125, "~INPUT_VEH_SUB_TURN_RIGHT_ONLY~"},
            {126, "~INPUT_VEH_SUB_PITCH_UD~"},
            {127, "~INPUT_VEH_SUB_PITCH_UP_ONLY~"},
            {128, "~INPUT_VEH_SUB_PITCH_DOWN_ONLY~"},
            {129, "~INPUT_VEH_SUB_THROTTLE_UP~"},
            {130, "~INPUT_VEH_SUB_THROTTLE_DOWN~"},
            {131, "~INPUT_VEH_SUB_ASCEND~"},
            {132, "~INPUT_VEH_SUB_DESCEND~"},
            {133, "~INPUT_VEH_SUB_TURN_HARD_LEFT~"},
            {134, "~INPUT_VEH_SUB_TURN_HARD_RIGHT~"},
            {135, "~INPUT_VEH_SUB_MOUSE_CONTROL_OVERRIDE~"},
            {136, "~INPUT_VEH_PUSHBIKE_PEDAL~"},
            {137, "~INPUT_VEH_PUSHBIKE_SPRINT~"},
            {138, "~INPUT_VEH_PUSHBIKE_FRONT_BRAKE~"},
            {139, "~INPUT_VEH_PUSHBIKE_REAR_BRAKE~"},
            {140, "~INPUT_MELEE_ATTACK_LIGHT~"},
            {141, "~INPUT_MELEE_ATTACK_HEAVY~"},
            {142, "~INPUT_MELEE_ATTACK_ALTERNATE~"},
            {143, "~INPUT_MELEE_BLOCK~"},
            {144, "~INPUT_PARACHUTE_DEPLOY~"},
            {145, "~INPUT_PARACHUTE_DETACH~"},
            {146, "~INPUT_PARACHUTE_TURN_LR~"},
            {147, "~INPUT_PARACHUTE_TURN_LEFT_ONLY~"},
            {148, "~INPUT_PARACHUTE_TURN_RIGHT_ONLY~"},
            {149, "~INPUT_PARACHUTE_PITCH_UD~"},
            {150, "~INPUT_PARACHUTE_PITCH_UP_ONLY~"},
            {151, "~INPUT_PARACHUTE_PITCH_DOWN_ONLY~"},
            {152, "~INPUT_PARACHUTE_BRAKE_LEFT~"},
            {153, "~INPUT_PARACHUTE_BRAKE_RIGHT~"},
            {154, "~INPUT_PARACHUTE_SMOKE~"},
            {155, "~INPUT_PARACHUTE_PRECISION_LANDING~"},
            {156, "~INPUT_MAP~"},
            {157, "~INPUT_SELECT_WEAPON_UNARMED~"},
            {158, "~INPUT_SELECT_WEAPON_MELEE~"},
            {159, "~INPUT_SELECT_WEAPON_HANDGUN~"},
            {160, "~INPUT_SELECT_WEAPON_SHOTGUN~"},
            {161, "~INPUT_SELECT_WEAPON_SMG~"},
            {162, "~INPUT_SELECT_WEAPON_AUTO_RIFLE~"},
            {163, "~INPUT_SELECT_WEAPON_SNIPER~"},
            {164, "~INPUT_SELECT_WEAPON_HEAVY~"},
            {165, "~INPUT_SELECT_WEAPON_SPECIAL~"},
            {166, "~INPUT_SELECT_CHARACTER_MICHAEL~"},
            {167, "~INPUT_SELECT_CHARACTER_FRANKLIN~"},
            {168, "~INPUT_SELECT_CHARACTER_TREVOR~"},
            {169, "~INPUT_SELECT_CHARACTER_MULTIPLAYER~"},
            {170, "~INPUT_SAVE_REPLAY_CLIP~"},
            {171, "~INPUT_SPECIAL_ABILITY_PC~"},
            {172, "~INPUT_CELLPHONE_UP~"},
            {173, "~INPUT_CELLPHONE_DOWN~"},
            {174, "~INPUT_CELLPHONE_LEFT~"},
            {175, "~INPUT_CELLPHONE_RIGHT~"},
            {176, "~INPUT_CELLPHONE_SELECT~"},
            {177, "~INPUT_CELLPHONE_CANCEL~"},
            {178, "~INPUT_CELLPHONE_OPTION~"},
            {179, "~INPUT_CELLPHONE_EXTRA_OPTION~"},
            {180, "~INPUT_CELLPHONE_SCROLL_FORWARD~"},
            {181, "~INPUT_CELLPHONE_SCROLL_BACKWARD~"},
            {182, "~INPUT_CELLPHONE_CAMERA_FOCUS_LOCK~"},
            {183, "~INPUT_CELLPHONE_CAMERA_GRID~"},
            {184, "~INPUT_CELLPHONE_CAMERA_SELFIE~"},
            {185, "~INPUT_CELLPHONE_CAMERA_DOF~"},
            {186, "~INPUT_CELLPHONE_CAMERA_EXPRESSION~"},
            {187, "~INPUT_FRONTEND_DOWN~"},
            {188, "~INPUT_FRONTEND_UP~"},
            {189, "~INPUT_FRONTEND_LEFT~"},
            {190, "~INPUT_FRONTEND_RIGHT~"},
            {191, "~INPUT_FRONTEND_RDOWN~"},
            {192, "~INPUT_FRONTEND_RUP~"},
            {193, "~INPUT_FRONTEND_RLEFT~"},
            {194, "~INPUT_FRONTEND_RRIGHT~"},
            {195, "~INPUT_FRONTEND_AXIS_X~"},
            {196, "~INPUT_FRONTEND_AXIS_Y~"},
            {197, "~INPUT_FRONTEND_RIGHT_AXIS_X~"},
            {198, "~INPUT_FRONTEND_RIGHT_AXIS_Y~"},
            {199, "~INPUT_FRONTEND_PAUSE~"},
            {200, "~INPUT_FRONTEND_PAUSE_ALTERNATE~"},
            {201, "~INPUT_FRONTEND_ACCEPT~"},
            {202, "~INPUT_FRONTEND_CANCEL~"},
            {203, "~INPUT_FRONTEND_X~"},
            {204, "~INPUT_FRONTEND_Y~"},
            {205, "~INPUT_FRONTEND_LB~"},
            {206, "~INPUT_FRONTEND_RB~"},
            {207, "~INPUT_FRONTEND_LT~"},
            {208, "~INPUT_FRONTEND_RT~"},
            {209, "~INPUT_FRONTEND_LS~"},
            {210, "~INPUT_FRONTEND_RS~"},
            {211, "~INPUT_FRONTEND_LEADERBOARD~"},
            {212, "~INPUT_FRONTEND_SOCIAL_CLUB~"},
            {213, "~INPUT_FRONTEND_SOCIAL_CLUB_SECONDARY~"},
            {214, "~INPUT_FRONTEND_DELETE~"},
            {215, "~INPUT_FRONTEND_ENDSCREEN_ACCEPT~"},
            {216, "~INPUT_FRONTEND_ENDSCREEN_EXPAND~"},
            {217, "~INPUT_FRONTEND_SELECT~"},
            {218, "~INPUT_SCRIPT_LEFT_AXIS_X~"},
            {219, "~INPUT_SCRIPT_LEFT_AXIS_Y~"},
            {220, "~INPUT_SCRIPT_RIGHT_AXIS_X~"},
            {221, "~INPUT_SCRIPT_RIGHT_AXIS_Y~"},
            {222, "~INPUT_SCRIPT_RUP~"},
            {223, "~INPUT_SCRIPT_RDOWN~"},
            {224, "~INPUT_SCRIPT_RLEFT~"},
            {225, "~INPUT_SCRIPT_RRIGHT~"},
            {226, "~INPUT_SCRIPT_LB~"},
            {227, "~INPUT_SCRIPT_RB~"},
            {228, "~INPUT_SCRIPT_LT~"},
            {229, "~INPUT_SCRIPT_RT~"},
            {230, "~INPUT_SCRIPT_LS~"},
            {231, "~INPUT_SCRIPT_RS~"},
            {232, "~INPUT_SCRIPT_PAD_UP~"},
            {233, "~INPUT_SCRIPT_PAD_DOWN~"},
            {234, "~INPUT_SCRIPT_PAD_LEFT~"},
            {235, "~INPUT_SCRIPT_PAD_RIGHT~"},
            {236, "~INPUT_SCRIPT_SELECT~"},
            {237, "~INPUT_CURSOR_ACCEPT~"},
            {238, "~INPUT_CURSOR_CANCEL~"},
            {239, "~INPUT_CURSOR_X~"},
            {240, "~INPUT_CURSOR_Y~"},
            {241, "~INPUT_CURSOR_SCROLL_UP~"},
            {242, "~INPUT_CURSOR_SCROLL_DOWN~"},
            {243, "~INPUT_ENTER_CHEAT_CODE~"},
            {244, "~INPUT_INTERACTION_MENU~"},
            {245, "~INPUT_MP_TEXT_CHAT_ALL~"},
            {246, "~INPUT_MP_TEXT_CHAT_TEAM~"},
            {247, "~INPUT_MP_TEXT_CHAT_FRIENDS~"},
            {248, "~INPUT_MP_TEXT_CHAT_CREW~"},
            {249, "~INPUT_PUSH_TO_TALK~"},
            {250, "~INPUT_CREATOR_LS~"},
            {251, "~INPUT_CREATOR_RS~"},
            {252, "~INPUT_CREATOR_LT~"},
            {253, "~INPUT_CREATOR_RT~"},
            {254, "~INPUT_CREATOR_MENU_TOGGLE~"},
            {255, "~INPUT_CREATOR_ACCEPT~"},
            {256, "~INPUT_CREATOR_DELETE~"},
            {257, "~INPUT_ATTACK2~"},
            {258, "~INPUT_RAPPEL_JUMP~"},
            {259, "~INPUT_RAPPEL_LONG_JUMP~"},
            {260, "~INPUT_RAPPEL_SMASH_WINDOW~"},
            {261, "~INPUT_PREV_WEAPON~"},
            {262, "~INPUT_NEXT_WEAPON~"},
            {263, "~INPUT_MELEE_ATTACK1~"},
            {264, "~INPUT_MELEE_ATTACK2~"},
            {265, "~INPUT_WHISTLE~"},
            {266, "~INPUT_MOVE_LEFT~"},
            {267, "~INPUT_MOVE_RIGHT~"},
            {268, "~INPUT_MOVE_UP~"},
            {269, "~INPUT_MOVE_DOWN~"},
            {270, "~INPUT_LOOK_LEFT~"},
            {271, "~INPUT_LOOK_RIGHT~"},
            {272, "~INPUT_LOOK_UP~"},
            {273, "~INPUT_LOOK_DOWN~"},
            {274, "~INPUT_SNIPER_ZOOM_IN~"},
            {275, "~INPUT_SNIPER_ZOOM_OUT~"},
            {276, "~INPUT_SNIPER_ZOOM_IN_ALTERNATE~"},
            {277, "~INPUT_SNIPER_ZOOM_OUT_ALTERNATE~"},
            {278, "~INPUT_VEH_MOVE_LEFT~"},
            {279, "~INPUT_VEH_MOVE_RIGHT~"},
            {280, "~INPUT_VEH_MOVE_UP~"},
            {281, "~INPUT_VEH_MOVE_DOWN~"},
            {282, "~INPUT_VEH_GUN_LEFT~"},
            {283, "~INPUT_VEH_GUN_RIGHT~"},
            {284, "~INPUT_VEH_GUN_UP~"},
            {285, "~INPUT_VEH_GUN_DOWN~"},
            {286, "~INPUT_VEH_LOOK_LEFT~"},
            {287, "~INPUT_VEH_LOOK_RIGHT~"},
            {288, "~INPUT_REPLAY_START_STOP_RECORDING~"},
            {289, "~INPUT_REPLAY_START_STOP_RECORDING_SECONDARY~"},
            {290, "~INPUT_SCALED_LOOK_LR~"},
            {291, "~INPUT_SCALED_LOOK_UD~"},
            {292, "~INPUT_SCALED_LOOK_UP_ONLY~"},
            {293, "~INPUT_SCALED_LOOK_DOWN_ONLY~"},
            {294, "~INPUT_SCALED_LOOK_LEFT_ONLY~"},
            {295, "~INPUT_SCALED_LOOK_RIGHT_ONLY~"},
            {296, "~INPUT_REPLAY_MARKER_DELETE~"},
            {297, "~INPUT_REPLAY_CLIP_DELETE~"},
            {298, "~INPUT_REPLAY_PAUSE~"},
            {299, "~INPUT_REPLAY_REWIND~"},
            {300, "~INPUT_REPLAY_FFWD~"},
            {301, "~INPUT_REPLAY_NEWMARKER~"},
            {302, "~INPUT_REPLAY_RECORD~"},
            {303, "~INPUT_REPLAY_SCREENSHOT~"},
            {304, "~INPUT_REPLAY_HIDEHUD~"},
            {305, "~INPUT_REPLAY_STARTPOINT~"},
            {306, "~INPUT_REPLAY_ENDPOINT~"},
            {307, "~INPUT_REPLAY_ADVANCE~"},
            {308, "~INPUT_REPLAY_BACK~"},
            {309, "~INPUT_REPLAY_TOOLS~"},
            {310, "~INPUT_REPLAY_RESTART~"},
            {311, "~INPUT_REPLAY_SHOWHOTKEY~"},
            {312, "~INPUT_REPLAY_CYCLEMARKERLEFT~"},
            {313, "~INPUT_REPLAY_CYCLEMARKERRIGHT~"},
            {314, "~INPUT_REPLAY_FOVINCREASE~"},
            {315, "~INPUT_REPLAY_FOVDECREASE~"},
            {316, "~INPUT_REPLAY_CAMERAUP~"},
            {317, "~INPUT_REPLAY_CAMERADOWN~"},
            {318, "~INPUT_REPLAY_SAVE~"},
            {319, "~INPUT_REPLAY_TOGGLETIME~"},
            {320, "~INPUT_REPLAY_TOGGLETIPS~"},
            {321, "~INPUT_REPLAY_PREVIEW~"},
            {322, "~INPUT_REPLAY_TOGGLE_TIMELINE~"},
            {323, "~INPUT_REPLAY_TIMELINE_PICKUP_CLIP~"},
            {324, "~INPUT_REPLAY_TIMELINE_DUPLICATE_CLIP~"},
            {325, "~INPUT_REPLAY_TIMELINE_PLACE_CLIP~"},
            {326, "~INPUT_REPLAY_CTRL~"},
            {327, "~INPUT_REPLAY_TIMELINE_SAVE~"},
            {328, "~INPUT_REPLAY_PREVIEW_AUDIO~"},
            {329, "~INPUT_VEH_DRIVE_LOOK~"},
            {330, "~INPUT_VEH_DRIVE_LOOK2~"},
            {331, "~INPUT_VEH_FLY_ATTACK2~"},
            {332, "~INPUT_RADIO_WHEEL_UD~"},
            {333, "~INPUT_RADIO_WHEEL_LR~"},
            {334, "~INPUT_VEH_SLOWMO_UD~"},
            {335, "~INPUT_VEH_SLOWMO_UP_ONLY~"},
            {336, "~INPUT_VEH_SLOWMO_DOWN_ONLY~"},
            {337, "~INPUT_VEH_HYDRAULICS_CONTROL_TOGGLE~"},
            {338, "~INPUT_VEH_HYDRAULICS_CONTROL_LEFT~"},
            {339, "~INPUT_VEH_HYDRAULICS_CONTROL_RIGHT~"},
            {340, "~INPUT_VEH_HYDRAULICS_CONTROL_UP~"},
            {341, "~INPUT_VEH_HYDRAULICS_CONTROL_DOWN~"},
            {342, "~INPUT_VEH_HYDRAULICS_CONTROL_UD~"},
            {343, "~INPUT_VEH_HYDRAULICS_CONTROL_LR~"},
            {344, "~INPUT_SWITCH_VISOR~"},
            {345, "~INPUT_VEH_MELEE_HOLD~"},
            {346, "~INPUT_VEH_MELEE_LEFT~"},
            {347, "~INPUT_VEH_MELEE_RIGHT~"},
            {348, "~INPUT_MAP_POI~"},
            {349, "~INPUT_REPLAY_SNAPMATIC_PHOTO~"},
            {350, "~INPUT_VEH_CAR_JUMP~"},
            {351, "~INPUT_VEH_ROCKET_BOOST~"},
            {352, "~INPUT_VEH_FLY_BOOST~"},
            {353, "~INPUT_VEH_PARACHUTE~"},
            {354, "~INPUT_VEH_BIKE_WINGS~"},
            {355, "~INPUT_VEH_FLY_BOMB_BAY~"},
            {356, "~INPUT_VEH_FLY_COUNTER~"},
            {357, "~INPUT_VEH_TRANSFORM~"},
        };

        public static string GetControlHelpText(this GameControl control)
        {
            if(controls.TryGetValue((int)control, out string help))
            {
                return help;
            }
            return "[unknown control]";
        }
    }
}
