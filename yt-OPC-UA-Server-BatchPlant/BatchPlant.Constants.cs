/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BatchPlant
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the BatchPlantType_StartProcess Method.
        /// </summary>
        public const uint BatchPlantType_StartProcess = 323;

        /// <summary>
        /// The identifier for the BatchPlantType_StopProcess Method.
        /// </summary>
        public const uint BatchPlantType_StopProcess = 324;

        /// <summary>
        /// The identifier for the BatchPlant1_StartProcess Method.
        /// </summary>
        public const uint BatchPlant1_StartProcess = 452;

        /// <summary>
        /// The identifier for the BatchPlant1_StopProcess Method.
        /// </summary>
        public const uint BatchPlant1_StopProcess = 453;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator Object.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator = 79;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve Object.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve = 87;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator Object.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator = 101;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve Object.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve = 109;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator Object.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator = 123;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve Object.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve = 131;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter Object.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter = 145;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor Object.
        /// </summary>
        public const uint MixerType_MixerMotor = 159;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve Object.
        /// </summary>
        public const uint MixerType_MixerDischargeValve = 166;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator = 180;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor Object.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor = 189;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1 Object.
        /// </summary>
        public const uint BatchPlantType_Silo1 = 197;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator = 198;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve = 206;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_DischargeValve = 219;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2 Object.
        /// </summary>
        public const uint BatchPlantType_Silo2 = 221;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator = 222;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve = 230;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_DischargeValve = 243;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3 Object.
        /// </summary>
        public const uint BatchPlantType_Silo3 = 245;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator = 246;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve = 254;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_DischargeValve = 267;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer Object.
        /// </summary>
        public const uint BatchPlantType_Mixer = 269;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter = 270;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor = 284;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve = 291;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_DischargeValve = 304;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit Object.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit = 306;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = 307;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor Object.
        /// </summary>
        public const uint BatchPlantType_Conveyor = 315;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor Object.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor = 316;

        /// <summary>
        /// The identifier for the BatchPlant1 Object.
        /// </summary>
        public const uint BatchPlant1 = 325;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1 Object.
        /// </summary>
        public const uint BatchPlant1_Silo1 = 326;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator = 327;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve = 335;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_DischargeValve = 348;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2 Object.
        /// </summary>
        public const uint BatchPlant1_Silo2 = 350;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator = 351;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve = 359;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_DischargeValve = 372;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3 Object.
        /// </summary>
        public const uint BatchPlant1_Silo3 = 374;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator = 375;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve = 383;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_DischargeValve = 396;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer Object.
        /// </summary>
        public const uint BatchPlant1_Mixer = 398;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter = 399;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor = 413;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve = 420;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_DischargeValve = 433;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit Object.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit = 435;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = 436;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor Object.
        /// </summary>
        public const uint BatchPlant1_Conveyor = 444;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor Object.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor = 445;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 1;

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public const uint GenericActuatorType = 9;

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public const uint GenericMotorType = 22;

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public const uint LevelIndicatorType = 29;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public const uint LoadcellTransmitterType = 37;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 51;

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public const uint MixerMotorType = 64;

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public const uint ConveyorMotorType = 71;

        /// <summary>
        /// The identifier for the Silo1Type ObjectType.
        /// </summary>
        public const uint Silo1Type = 78;

        /// <summary>
        /// The identifier for the Silo2Type ObjectType.
        /// </summary>
        public const uint Silo2Type = 100;

        /// <summary>
        /// The identifier for the Silo3Type ObjectType.
        /// </summary>
        public const uint Silo3Type = 122;

        /// <summary>
        /// The identifier for the MixerType ObjectType.
        /// </summary>
        public const uint MixerType = 144;

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public const uint PackagingUnitType = 179;

        /// <summary>
        /// The identifier for the ConveyorType ObjectType.
        /// </summary>
        public const uint ConveyorType = 188;

        /// <summary>
        /// The identifier for the BatchPlantType ObjectType.
        /// </summary>
        public const uint BatchPlantType = 196;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 2;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EURange = 6;

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public const uint GenericSensorType_Units = 8;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public const uint GenericActuatorType_Input = 10;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Input_EURange = 14;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public const uint GenericActuatorType_Output = 16;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Output_EURange = 20;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public const uint GenericMotorType_Speed = 23;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint GenericMotorType_Speed_EURange = 27;

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public const uint LevelIndicatorType_Output_EURange = 34;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_Output_EURange = 42;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage = 45;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage_EURange = 49;

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public const uint ValveType_Input_EURange = 56;

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public const uint ValveType_Output_EURange = 62;

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint MixerMotorType_Speed_EURange = 69;

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint ConveyorMotorType_Speed_EURange = 76;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Output = 80;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Output_EURange = 84;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Units = 86;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Input = 88;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Input_EURange = 92;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Output = 94;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Output_EURange = 98;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Output = 102;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Output_EURange = 106;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Units = 108;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Input = 110;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Input_EURange = 114;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Output = 116;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Output_EURange = 120;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Output = 124;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Output_EURange = 128;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Units = 130;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Input = 132;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Input_EURange = 136;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Output = 138;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Output_EURange = 142;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Output = 146;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Output_EURange = 150;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Units = 152;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage = 153;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = 157;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed Variable.
        /// </summary>
        public const uint MixerType_MixerMotor_Speed = 160;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerMotor_Speed_EURange = 164;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Input = 167;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Input_EURange = 171;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Output = 173;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Output_EURange = 177;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output = 181;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = 185;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Units = 187;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor_Speed = 190;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor_Speed_EURange = 194;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output = 199;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = 203;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Units = 205;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input = 207;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = 211;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output = 213;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = 217;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_DischargeValve_Input = 220;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output = 223;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = 227;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Units = 229;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input = 231;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = 235;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output = 237;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = 241;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_DischargeValve_Input = 244;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output = 247;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = 251;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Units = 253;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input = 255;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = 259;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output = 261;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = 265;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_DischargeValve_Input = 268;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output = 271;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = 275;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Units = 277;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = 278;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 282;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor_Speed = 285;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor_Speed_EURange = 289;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input = 292;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = 296;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output = 298;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = 302;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_DischargeValve_Input = 305;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = 308;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 312;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = 314;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed = 317;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = 321;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output = 328;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = 332;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Units = 334;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input = 336;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = 340;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output = 342;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = 346;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_DischargeValve_Input = 349;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output = 352;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = 356;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Units = 358;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input = 360;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = 364;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output = 366;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = 370;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_DischargeValve_Input = 373;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output = 376;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = 380;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Units = 382;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input = 384;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = 388;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output = 390;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = 394;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_DischargeValve_Input = 397;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output = 400;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = 404;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Units = 406;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = 407;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 411;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor_Speed = 414;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor_Speed_EURange = 418;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input = 421;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = 425;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output = 427;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = 431;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_DischargeValve_Input = 434;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = 437;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 441;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = 443;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed = 446;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = 450;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the BatchPlantType_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StopProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StopProcess, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.MixerType_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.PackagingUnitType_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.ConveyorType_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType = new ExpandedNodeId(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MixerType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType = new ExpandedNodeId(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType = new ExpandedNodeId(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LevelIndicatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the BatchPlant1 component.
        /// </summary>
        public const string BatchPlant1 = "Batch Plant #1";

        /// <summary>
        /// The BrowseName for the BatchPlantType component.
        /// </summary>
        public const string BatchPlantType = "BatchPlantType";

        /// <summary>
        /// The BrowseName for the Conveyor component.
        /// </summary>
        public const string Conveyor = "ConveyorX001";

        /// <summary>
        /// The BrowseName for the ConveyorMotor component.
        /// </summary>
        public const string ConveyorMotor = "Motor02";

        /// <summary>
        /// The BrowseName for the ConveyorMotorType component.
        /// </summary>
        public const string ConveyorMotorType = "ConveyorMotorType";

        /// <summary>
        /// The BrowseName for the ConveyorType component.
        /// </summary>
        public const string ConveyorType = "ConveyorType";

        /// <summary>
        /// The BrowseName for the ExcitationVoltage component.
        /// </summary>
        public const string ExcitationVoltage = "ExcitationVoltage";

        /// <summary>
        /// The BrowseName for the GenericActuatorType component.
        /// </summary>
        public const string GenericActuatorType = "GenericActuatorType";

        /// <summary>
        /// The BrowseName for the GenericMotorType component.
        /// </summary>
        public const string GenericMotorType = "GenericMotorType";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the LevelIndicatorType component.
        /// </summary>
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <summary>
        /// The BrowseName for the LoadcellTransmitter component.
        /// </summary>
        public const string LoadcellTransmitter = "LT001";

        /// <summary>
        /// The BrowseName for the LoadcellTransmitterType component.
        /// </summary>
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";

        /// <summary>
        /// The BrowseName for the Mixer component.
        /// </summary>
        public const string Mixer = "MixerX001";

        /// <summary>
        /// The BrowseName for the MixerDischargeValve component.
        /// </summary>
        public const string MixerDischargeValve = "Valve004";

        /// <summary>
        /// The BrowseName for the MixerMotor component.
        /// </summary>
        public const string MixerMotor = "Motor01";

        /// <summary>
        /// The BrowseName for the MixerMotorType component.
        /// </summary>
        public const string MixerMotorType = "MixerMotorType";

        /// <summary>
        /// The BrowseName for the MixerType component.
        /// </summary>
        public const string MixerType = "MixerType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the PackagingUnit component.
        /// </summary>
        public const string PackagingUnit = "PackagingUnitX001";

        /// <summary>
        /// The BrowseName for the PackagingUnitLevelIndicator component.
        /// </summary>
        public const string PackagingUnitLevelIndicator = "LI004";

        /// <summary>
        /// The BrowseName for the PackagingUnitType component.
        /// </summary>
        public const string PackagingUnitType = "PackagingUnitType";

        /// <summary>
        /// The BrowseName for the Silo1 component.
        /// </summary>
        public const string Silo1 = "SiloX001";

        /// <summary>
        /// The BrowseName for the Silo1DischargeValve component.
        /// </summary>
        public const string Silo1DischargeValve = "Valve001";

        /// <summary>
        /// The BrowseName for the Silo1LevelIndicator component.
        /// </summary>
        public const string Silo1LevelIndicator = "LI001";

        /// <summary>
        /// The BrowseName for the Silo1Type component.
        /// </summary>
        public const string Silo1Type = "Silo1Type";

        /// <summary>
        /// The BrowseName for the Silo2 component.
        /// </summary>
        public const string Silo2 = "SiloX002";

        /// <summary>
        /// The BrowseName for the Silo2DischargeValve component.
        /// </summary>
        public const string Silo2DischargeValve = "Valve002";

        /// <summary>
        /// The BrowseName for the Silo2LevelIndicator component.
        /// </summary>
        public const string Silo2LevelIndicator = "LI002";

        /// <summary>
        /// The BrowseName for the Silo2Type component.
        /// </summary>
        public const string Silo2Type = "Silo2Type";

        /// <summary>
        /// The BrowseName for the Silo3 component.
        /// </summary>
        public const string Silo3 = "SiloX003";

        /// <summary>
        /// The BrowseName for the Silo3DischargeValve component.
        /// </summary>
        public const string Silo3DischargeValve = "Valve003";

        /// <summary>
        /// The BrowseName for the Silo3LevelIndicator component.
        /// </summary>
        public const string Silo3LevelIndicator = "LI003";

        /// <summary>
        /// The BrowseName for the Silo3Type component.
        /// </summary>
        public const string Silo3Type = "Silo3Type";

        /// <summary>
        /// The BrowseName for the Speed component.
        /// </summary>
        public const string Speed = "Speed";

        /// <summary>
        /// The BrowseName for the StartProcess component.
        /// </summary>
        public const string StartProcess = "StartProcess";

        /// <summary>
        /// The BrowseName for the StopProcess component.
        /// </summary>
        public const string StopProcess = "StopProcess";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the BatchPlant namespace (.NET code namespace is 'BatchPlant').
        /// </summary>
        public const string BatchPlant = "http://opcfoundation.org/BatchPlant";
    }
    #endregion
}